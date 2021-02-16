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
    public partial class AgregarAlquiler : Form
    {
        //colecciones
        Estacionamiento ListaCocheras = new Estacionamiento();
        Alquileres alquileres = new Alquileres();
        Movimientos ListaMovimientos = new Movimientos();
        Cierres ListaCierres = new Cierres();

        //xmls
        XMLAlquileres managerAlquileres = new XMLAlquileres();
        XMLMovimientos managerMov = new XMLMovimientos();
        XMLCierres managerCierres = new XMLCierres();
        
        
        Button Seleccionado;
        Usuario Activo;
        Cochera coche;
        //Alquileres alquileres;
        
        


        public AgregarAlquiler(Button seleccionado,List<Cochera> ListaCocheras, Usuario user1,Cochera cocherita,List<Alquiler> alqui,List<Movimiento> movimiento)
        {
            InitializeComponent();
            Seleccionado = seleccionado;
            this.ListaCocheras.AgregarCocherasenLote(ListaCocheras);
            Activo = user1;
            coche= cocherita;
            alquileres.AgregarAlquileresenLote(alqui);
            ListaMovimientos.AgregarMovimientosenLote(movimiento);

        }

       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void radioButtonHora_CheckedChanged(object sender, EventArgs e)
        {
            btnRenovar.Visible = false;
        }

        private void radioButtonHora_Click(object sender, EventArgs e)
        {
            textBoxTitular.Enabled = false;
            numericUpDownCantMeses.Enabled = false;
            textBoxImporte.Visible = false;
            textBoxVencimiento.Visible = false;
            textBoxVencimiento.Enabled = false;
            textBoxImporte.Enabled = false;

        }

        private void radioButtonMes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMes.Checked == true)
            {
                textBoxTitular.Enabled = true;
                numericUpDownCantMeses.Enabled = true;
                textBoxVencimiento.Enabled = true;
                textBoxImporte.Enabled = true;
                //btnRenovar.Visible = true;
                textBoxImporte.Visible = true;
                textBoxVencimiento.Visible = true;
               

            }
            else
            {
                textBoxTitular.Enabled = false;
                numericUpDownCantMeses.Enabled = false;
                textBoxVencimiento.Enabled = false;
                textBoxImporte.Enabled = false;
                btnRenovar.Visible = false;


            }

        }

        private void radioButtonMes_Click(object sender, EventArgs e)
        {
            textBoxImporte.Text = (numericUpDownCantMeses.Value * 1500).ToString();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBoxVencimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarAlquiler_Load(object sender, EventArgs e)
        {
            try
            {


                Alquiler alquiler = alquileres.BuscarCocheraAlquiler(coche);
                comboBoxTipoVehiculo.Text = "Auto";

                textBoxVencimiento.Text = DateTime.Now.AddMonths((int)numericUpDownCantMeses.Value).ToString();
                //textBoxImporte.Text = (numericUpDownCantMeses.Value * 1500).ToString();
                if (coche.Estado) //cuando esta ocupada
                {
                    btnDesocupar.Enabled = true;
                    //btnRenovar.Enabled = true;
                    btnAlquilar.Enabled = false;
                    comboBoxTipoVehiculo.Enabled = false;
                    comboBoxTipoVehiculo.Text = coche.Vehiculo.TipoVehiculo.Descripcion;
                    comboBoxMarca.Enabled = false;
                    comboBoxMarca.Text = coche.Vehiculo.Marca;
                    maskedTextBoxPatente.Enabled = false;
                    maskedTextBoxPatente.Text = coche.Vehiculo.Dominio;
                    textBoxModelo.Enabled = false;
                    textBoxModelo.Text = coche.Vehiculo.Modelo;

                    textBoxTitular.Enabled = false;
                    numericUpDownCantMeses.Enabled = false;
                    //label2.Text = coche.Vehiculo.Modelo; para poder cambiarle el color a la letra

                    if (alquiler is AlquilerMensual)
                    {
                        radioButtonHora.Enabled = false;
                        radioButtonMes.Checked = true;
                        AlquilerMensual mes = alquiler as AlquilerMensual;
                        textBoxTitular.Text = mes.Titular;
                        textBoxTitular.Enabled = false;
                        numericUpDownCantMeses.Enabled = true;


                    }
                    else

                    {
                        if (alquiler is AlquilerHora)
                        {
                            radioButtonMes.Enabled = false;
                            AlquilerHora auxalqhora = (AlquilerHora)alquileres.BuscarCocheraAlquiler(coche);
                            auxalqhora.Hasta = DateTime.Now;
                        }
                    }






                } else
                {
                    btnDesocupar.Enabled = false;
                    btnRenovar.Enabled = false;
                    btnAlquilar.Enabled = true;
                }

                lblnumeroCochera.Text = coche.Ubicacion; //seteo ubicacion de la cochera
                                                         //textBoxImporte.Text = "0";
            }
            catch
            {
                MessageBox.Show("Error Load AgregarAlquiler");
            }
        }

        private void numericUpDownCantMeses_ValueChanged(object sender, EventArgs e)
        {
            textBoxVencimiento.Text = DateTime.Now.AddMonths((int)numericUpDownCantMeses.Value).ToString();
            textBoxImporte.Text = (numericUpDownCantMeses.Value * 1500).ToString();

            /*AlquilerMensual aux2 = null;
            Alquiler aux = alquileres.BuscarCocheraAlquiler(coche);//obtengo el alquiler de la cochera
            if (aux is AlquilerMensual)//si es mensual
            {
                aux2 = (AlquilerMensual)aux;//guardo en aux2 el alquiler
            }
            if (aux2 != null)//si es distinto de null pongo en el textbox  el vencimiento del alquiler aux2 y cada vez que toque el nud incremente en el text nomas
            {
                textBoxVencimiento.Text = aux2.Fechavencimiento.AddMonths((int)numericUpDownCantMeses.Value).ToString();//pone el vencimiento


                textBoxImporte.Text = (numericUpDownCantMeses.Value * 1500).ToString();//importe verificar
            }

            else
            {
                if (radioButtonMes.Checked)
                {
                    //sino cuando el alquiler mensual no este cargado incremento el de ahora en el textbox
                    //nota con hora no hace falta chequear ya que si es alquiler hora el textbox de vencimiento se oculta
                    textBoxVencimiento.Text = DateTime.Now.AddMonths((int)numericUpDownCantMeses.Value).ToString();
                    textBoxImporte.Text = (numericUpDownCantMeses.Value * 1500).ToString();
                }
               
            } */
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {

            if (maskedTextBoxPatente.Text == "" || textBoxModelo.Text == "" || comboBoxMarca.Text == "" || comboBoxTipoVehiculo.Text == "") //datos completos
            {
                MessageBox.Show("Datos incompletos");
            }
            else
            {
                string codigo = "";
                switch (comboBoxTipoVehiculo.Text)
                {
                    case "Moto":
                        codigo = "1";
                        break;

                    case "Auto":
                        codigo = "2";
                        break;

                    case "Camioneta":
                        codigo = "3";
                        break;
                }

                if (alquileres.BuscarPatente(maskedTextBoxPatente.Text))
                {



                    if (radioButtonHora.Checked)
                    {

                        TipoVehiculo tvehiculo = new TipoVehiculo(codigo, comboBoxTipoVehiculo.Text);
                        Vehiculo vehiculo = new Vehiculo(maskedTextBoxPatente.Text, comboBoxMarca.Text, textBoxModelo.Text, tvehiculo);
                        Cochera c = new Cochera(coche.Numero, coche.Ubicacion, true, vehiculo);

                        Alquiler alquiler = new AlquilerHora(DateTime.Now, c, DateTime.Now, DateTime.Now);
                        Movimiento mov = new Movimiento("AlquilerHora", alquiler.CalcularImporte(), DateTime.Now, true, Activo, null, alquiler);

                        alquileres.AgregarAlquiler(alquiler);
                        ListaMovimientos.AgregarMovimientos(mov);

                       // managerMov.AgregarXMLMovimientos(ListaMovimientos.MostrarMovimientos());
                       // managerAlquileres.AgregarAlquilerXML(alquileres.MostrarAlquileres());




                        Interface1 i = this.Owner as Interface1;  //los datos los saca de aca


                        if (i != null)
                        {
                            //el alquiler generado aca lo paso por medio de la interfaz a principal
                            i.AgregarAlquilerInterfaz(alquiler); //cuando entra en el metodo cambia el color


                        }

                        
                        this.Close();




                    }
                    else
                    {
                        if (radioButtonMes.Checked)
                        {
                            if (textBoxTitular.Text == "")
                            {
                                MessageBox.Show("Datos incompletos");
                            }
                            else
                            {
                               
                                TipoVehiculo tvehiculo = new TipoVehiculo(codigo, comboBoxTipoVehiculo.Text);
                                Vehiculo vehiculo = new Vehiculo(maskedTextBoxPatente.Text, comboBoxMarca.Text, textBoxModelo.Text, tvehiculo);
                                Cochera c = new Cochera(coche.Numero, coche.Ubicacion, true, vehiculo);


                                AlquilerMensual alquiler = new AlquilerMensual(DateTime.Now, c, textBoxTitular.Text, Convert.ToDateTime(DateTime.Now.AddMonths(Convert.ToInt32(numericUpDownCantMeses.Value))));
                                Movimiento mov = new Movimiento("AlquilerMensual", alquiler.CalcularImporte(), DateTime.Now, true, Activo, null, alquiler);

                                alquileres.AgregarAlquiler(alquiler); //agrega alquiler a la lista

                                //Realiza movimiento
                                //Cierre vacio = new Cierre();

                                ListaMovimientos.AgregarMovimientos(mov); //agrega movimientos a la lista
                                managerMov.AgregarXMLMovimientos(ListaMovimientos.MostrarMovimientos());
                                managerAlquileres.AgregarAlquilerXML(alquileres.MostrarAlquileres());



                                Interface1 i = this.Owner as Interface1;  //los datos los saca de aca


                                if (i != null)
                                {

                                    i.AgregarAlquilerInterfaz(alquiler); //agrega el alquiler por uno
                                    i.AgregarMovimientoInterfaz(mov); //agrega el movimiento por uno


                                }



                            }

                        }


                    }
                    //managerAlquileres.GenerarXMLAlquileres(alquileres.MostrarAlquileres());
                    //managerMov.GenerarXMLMovimientos(ListaMovimientos.MostrarMovimientos());
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Patente duplicada!");
                }
            }
        }

        private void btnDesocupar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea desocupar?", "Desocupar", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
               

                Alquiler alquiler = alquileres.BuscarCocheraAlquiler(coche); //busca el alquiler de una cochera por ubicacion y lo guarda en alquiler
                Interface1 i = this.Owner as Interface1;  //los datos los saca de aca
                if (radioButtonHora.Checked)
                {
                    Movimiento mov = new Movimiento("AlquilerHora", alquiler.CalcularImporte(), DateTime.Now, true, Activo, null, alquiler);
                    ListaMovimientos.AgregarMovimientos(mov); //agrega movimientos a la lista
                    managerMov.AgregarXMLMovimientos(ListaMovimientos.MostrarMovimientos()); //genera el xml de movimientos
                    MessageBox.Show("El importe es: " + mov.Importe.ToString());


                    if (i != null)
                    {


                        i.AgregarMovimientoInterfaz(mov);


                    }
                }


                if (i != null)
                {

                    i.BorrarAlquilerInterfaz(alquiler);



                }
                this.Close();

            }
            
           
        }

        private void textBoxImporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            //Renovar ren = new Renovar();
            //ren.ShowDialog(this);

            /*AlquilerMensual mes =(AlquilerMensual)alquileres.BuscarCocheraAlquiler(coche); //obtengo alquiler
            mes.Fecha = mes.Fechavencimiento;
            mes.Fechavencimiento=mes.Fechavencimiento.AddMonths(Convert.ToInt32(numericUpDownCantMeses.Value)); //obtengo meses
            Movimiento mov = new Movimiento("AlquilerMensual",mes.CalcularImporte(),DateTime.Now,true,Activo,null,mes); //instacio un movimiento

            Interface1 i = this.Owner as Interface1;  //los datos los saca de aca


            if (i != null)
            {

                i.RenovarAlquiler(mov);


            }
            this.Close();*/



        }
    }
}


    

