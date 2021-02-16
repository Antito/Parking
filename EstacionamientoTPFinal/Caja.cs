using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EstacionamientoTPFinal
{
    public partial class Caja : Form
    {
        //colecciones
        Movimientos ListaMovimientos = new Movimientos();
        Cierres ListaCierres = new Cierres();

        //xmls
        XMLMovimientos managerMov = new XMLMovimientos();
        XMLCierres managerCierres = new XMLCierres();

        Usuario Activo;

        public Caja(Usuario user1,List<Movimiento> movimientos)
        {
            InitializeComponent();
            Activo = user1; 
            ListaMovimientos.AgregarMovimientosenLote(movimientos);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] //Mouse Down
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {

            //bool paso = false;//flag utilizado para ver si cerro algo o no
            DialogResult dialogResult = MessageBox.Show("¿Desea cerrar caja?", "Cerrar Caja", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {



                foreach (Movimiento aux in ListaMovimientos.MostrarMovimientos())
                {
                    if (aux.Cierre == null) //si no esta hecho el cierre
                    {
                        //paso = true;
                        Cierre cie = new Cierre(DateTime.Now, Activo);
                        aux.Cierre = cie;

                        ListaCierres.AgregarCierre(cie); //agrego el cierre a la lista
                        managerCierres.AgregarXMLCierres(ListaCierres.ListarCierres()); //genera el xml

                        Interface1 i = this.Owner as Interface1;  //los datos los saca de aca


                        if (i != null)
                        {

                            i.AgregarCierreInterfaz(cie);


                        }

                    }

                }
                listBoxIngresos.DataSource = null;
                listBoxEgresos.DataSource = null;
                textBoxIngresos.Text = "0";
                textBoxEgresos.Text = "0";
                textBoxTotalCaja.Text = "0";
                
            }
            /*if (paso == false)
            {
                MessageBox.Show("No hay Movimientos para cerrar");
            }*/


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void Caja_Load(object sender, EventArgs e)
        {
            //seteo valores en listbox
            bindingSourceIngresos.DataSource = ListaMovimientos.Ingresos(); 
            listBoxIngresos.DataSource = bindingSourceIngresos;
            bindingSourceEgresos.DataSource = ListaMovimientos.Egresos();
            listBoxEgresos.DataSource = bindingSourceEgresos;

            textBoxIngresos.Text = ListaMovimientos.DevolverTotalIngreso().ToString();
            textBoxEgresos.Text = ListaMovimientos.DevolverTotalEgreso().ToString();

            textBoxTotalCaja.Text = DevolverTotalCaja().ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGenerarEgreso_Click(object sender, EventArgs e)
        {
            
            if (txtConcepto.Text == "" || numericUpDownImporteConcepto.Value == 0)
            {
                MessageBox.Show("Datos incompletos");
            }
            else
            {
                
                Movimiento mov = new Movimiento(txtConcepto.Text, Convert.ToDouble(numericUpDownImporteConcepto.Value), DateTime.Now, false, Activo, null);
                ListaMovimientos.AgregarMovimientos(mov);
                managerMov.AgregarXMLMovimientos(ListaMovimientos.MostrarMovimientos());

                Interface1 i = this.Owner as Interface1;  //los datos los saca de aca

                if (i != null)
                {


                    i.AgregarMovimientoInterfaz(mov);  //paso el movimiento a principal para actualizar la lista movimiento de principal


                }

                //MessageBox.Show("Egreso Cargado");
                txtConcepto.Text = "";
                numericUpDownImporteConcepto.Value = 0;

                listBoxEgresos.DataSource = ListaMovimientos.Egresos();
                textBoxEgresos.Text = ListaMovimientos.DevolverTotalEgreso().ToString(); //muestra el total egreso en el textBox
                textBoxTotalCaja.Text = DevolverTotalCaja().ToString();


            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public double DevolverTotalCaja() //ingreso - egreso
        {
            double ingreso = Convert.ToDouble(textBoxIngresos.Text);
            double egreso = Convert.ToDouble(textBoxEgresos.Text);
            return ingreso - egreso;

        }
    }
}
