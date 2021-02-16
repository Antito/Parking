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
    public partial class HistorialCierres : Form
    {
        //colecciones
        Movimientos ListaMovimientos = new Movimientos();
        Cierres ListaCierres = new Cierres();

        //xmls
        XMLMovimientos managerMov = new XMLMovimientos();
        XMLCierres managerCierres = new XMLCierres();

        Usuario Activo;

        public HistorialCierres(Usuario user1,List<Movimiento> movimientos,List<Cierre> cierres)
        {
            
            InitializeComponent();
            Activo = user1;
            ListaMovimientos.AgregarMovimientosenLote(movimientos);
            ListaCierres.AgregarCierresEnLotes(cierres);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void HistorialCierres_Load(object sender, EventArgs e)
        {
            bindingSourceCierre.DataSource = ListaCierres.ListarCierres(); //muestra los cierres
            listBoxCierres.DataSource = bindingSourceCierre;

        }

        private void listBoxCierres_SelectedValueChanged(object sender, EventArgs e)
        {
           

            try
            {
                string cierre = listBoxCierres.SelectedValue.ToString(); //ahi tengo al que selecciona
                bindingSourceIngresosCierres.DataSource = ListaMovimientos.IngresosCierre(cierre);
               

                bindingSourceEgresosCierres.DataSource = ListaMovimientos.EgresosCierres(cierre); 

                listBoxIngresosCierres.DataSource = bindingSourceIngresosCierres;
                listBoxEgresosCierres.DataSource = bindingSourceEgresosCierres;


                //bindingSourceMovimientos.DataSource = ListaMovimientos.Cierres(cierre);
                //listBoxMovimientos.DataSource = bindingSourceMovimientos;

                //textBoxTotal.Text =listamove.DevolverTotalFacturadoCerrados(cierre).ToString();

                //setea valores
                textBoxTotalCierres.Text = ListaMovimientos.DevolverTotalCierres(cierre).ToString();
                textBoxIngresosCierres.Text = ListaMovimientos.DevolverTotalIngresoCierre(cierre).ToString();
                textBoxEgresosCierres.Text = ListaMovimientos.DevolverTotalEgresoCierre(cierre).ToString();

            }
            catch
            {

            }
        }

        private void textBoxTotalCierres_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxEgresosCierres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
