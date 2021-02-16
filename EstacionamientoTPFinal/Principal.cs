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
    public partial class Principal : Form,Interface1
    {
        //colecciones
        Estacionamiento ListaCocheras = new Estacionamiento();
        Alquileres ListaAlquileres = new Alquileres();
        Movimientos ListaMovimientos = new Movimientos();
        Cierres ListaCierres = new Cierres();

        Alquileres alertas = new Alquileres();

        //xmls
        XMLAlquileres manager = new XMLAlquileres();
        XMLMovimientos managerMov = new XMLMovimientos();
        XMLCierres managerCierre = new XMLCierres();

        Usuario Activo;
        Button seleccionado; //declaro boton 

        public Principal(Usuario user1,List<Cochera> cocheritas)
        {
            InitializeComponent();
            Activo = user1; //guardp el usuario logueado
            try
            {
                manager.GenerarXMLAlquileres(ListaAlquileres.MostrarAlquileres());

            }
            catch
            {
                MessageBox.Show("Error en el XML Alquileres");
            }

            try
            {
                managerMov.GenerarXMLMovimientos(ListaMovimientos.MostrarMovimientos());
            }
            catch
            {
                MessageBox.Show("Error en el XML Movimientos");
            }

            try
            {
                managerCierre.GenerarXMLCierres(ListaCierres.ListarCierres());
            }
            catch
            {
                MessageBox.Show("Error en el XML Cierres");
            }

            try
            {
                //agrego los datos de los xml generados a las listas
                if (!manager.archivovacio())
                {
                    ListaCocheras.AgregarCocherasenLote(cocheritas);
                    ListaAlquileres.AgregarAlquileresenLote(manager.ObtenerAlquileres());
                    ListaMovimientos.AgregarMovimientosenLote(managerMov.ObtenerMovimientos());
                    ListaCierres.AgregarCierresEnLotes(managerCierre.ObtenerCierres());
                   
                    foreach (Alquiler aux in ListaAlquileres.MostrarAlquileres())
                    {
                        if (aux.Cochera.Estado == true)
                        {
                            ListaCocheras.AgregarCochera(aux.Cochera);
                        }
                    }
                }
                else
                {
                    ListaCocheras.AgregarCocherasenLote(cocheritas);
                }

            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();

            DialogResult dialogResult = MessageBox.Show("¿Desea salir?", "Saliendo del sistema", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]  //Mouse Down
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            

            seleccionado = sender as Button; //toma el objeto boton y tiene el texto del boton  
            Cochera cochera;
            cochera = ListaCocheras.DevolverCochera(seleccionado.Text); //busco la cochera utilizando el text del boton como indice con la ubicacion en los objetos de tipo cochera


            AgregarAlquiler a = new AgregarAlquiler(seleccionado, ListaCocheras.DevolverTodos(), Activo, cochera,ListaAlquileres.MostrarAlquileres(),ListaMovimientos.MostrarMovimientos()); 
            a.ShowDialog(this);
            
          

        }

        
        
        public void AgregarAlquilerInterfaz(Alquiler alquiler) //agrego el alquiler que genere en cargar alquiler a mi lista de alquiler general
        {
            ListaAlquileres.AgregarAlquiler(alquiler); //Actualizo la lista alquiler de principal con la de cargaralquiler
            seleccionado.BackColor = Color.Red;  //cuando agregas alquiler cambia el color
            ListaCocheras.AgregarCochera(alquiler.Cochera); //agrega la cochera,actualizo la lista de cochera principal accediendo a la cochera del alquiler generado
            manager.AgregarAlquilerXML(ListaAlquileres.MostrarAlquileres());
            managerMov.AgregarXMLMovimientos(ListaMovimientos.MostrarMovimientos());


        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {


                foreach (Button boton in groupBoxFotoEstacionamiento.Controls) //sirve para cambiar el color cuando cerramos el programa. Se mantiene el color de ocupado y desocupado
                {
                    if (ListaCocheras.DevolverCochera(boton.Text).Estado)
                    {
                        boton.BackColor = Color.Red;
                    }
                    else
                    {
                        boton.BackColor = Color.LimeGreen;
                    }
                }



                foreach (Alquiler aux in ListaAlquileres.MostrarAlquileres()) //para las alertas
                {
                    if (aux is AlquilerMensual)
                    {
                        AlquilerMensual mensual = (AlquilerMensual)aux;
                        if (DateTime.Now.Year == mensual.Fechavencimiento.Year && DateTime.Now.Month == mensual.Fechavencimiento.Month)
                        {
                            TimeSpan dias = mensual.Fechavencimiento - DateTime.Now; //resta fechas
                            if (dias.TotalDays < 4)
                            {
                                alertas.AgregarAlquiler(aux);

                                btnAlertaVencimiento.Image = Image.FromFile("C:/imagenes/Exclamation2.gif");
                                //btnAlertaVencimiento.Image = Image.FromFile("C:/Users/fraveg/Desktop/CopiasTp5/EstacionamientoTPFinal/imagenes/Exclamation2.gif");
                                btnAlertaVencimiento.ImageAlign = ContentAlignment.MiddleLeft;



                            }
                        }

                    }
                }



            }
            catch
            {
                MessageBox.Show("Error Load Principal");
            }

            }

        

        private void btnCaja_Click(object sender, EventArgs e)
        {
            Caja caja = new Caja(Activo, ListaMovimientos.MostrarMovimientos());
            caja.ShowDialog(this);
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnAlertaVencimiento_Click(object sender, EventArgs e)
        {
            if (alertas.Contar()>0)
            {
                Alertas alerta = new Alertas(alertas.MostrarAlquileres());
                alerta.ShowDialog();
            }else
            {
                MessageBox.Show("No hay alertas!!");
            }
           

        }
        //Interfaz utilizada para borrar de la lista alquiler el alquiler que voy a desocupar
        public void BorrarAlquilerInterfaz(Alquiler alquiler)
        {

            ListaCocheras.EliminarCochera(alquiler.Cochera); //aca elimina la cochera
            ListaAlquileres.EliminarAlquiler(alquiler); //elimina el alquiler
            seleccionado.BackColor = Color.LimeGreen; //cambia de color
            manager.AgregarAlquilerXML(ListaAlquileres.MostrarAlquileres()); //aca lo saca del xml
            alertas.EliminarAlquiler(alquiler);
            if (alertas.Contar()<=0)
            {
                btnAlertaVencimiento.Image = Image.FromFile("C:/imagenes/warning.png");
                //btnAlertaVencimiento.Image = Image.FromFile("C:/Users/fraveg/Desktop/CopiasTp5/EstacionamientoTPFinal/imagenes/warning.png");
            }
        }

        public void AgregarMovimientoInterfaz(Movimiento movimiento)
        {
            ListaMovimientos.AgregarMovimientos(movimiento); //lo agrega en memoria
            managerMov.AgregarXMLMovimientos(ListaMovimientos.MostrarMovimientos());


        }

        private void btnCierres_Click(object sender, EventArgs e)
        {
            HistorialCierres cierres = new HistorialCierres(Activo,ListaMovimientos.MostrarMovimientos(),ListaCierres.ListarCierres());
            cierres.ShowDialog(this);
        }

        public void AgregarCierreInterfaz(Cierre cierre)
        {
            foreach (Movimiento aux in ListaMovimientos.MostrarMovimientos())
            {
                if (aux.Cierre == null)
                {
                    aux.Cierre = cierre;
                    //MessageBox.Show("Entre");
                }
            }
            ListaCierres.AgregarCierre(cierre); //agrego en memoria
            managerCierre.AgregarXMLCierres(ListaCierres.ListarCierres()); //genero xml de cierres 
            managerMov.AgregarXMLMovimientos(ListaMovimientos.MostrarMovimientos());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void RenovarAlquiler(Movimiento movimiento)
        {
           /* bool encontro = false;
           
            AlquilerMensual auxRenovar = (AlquilerMensual)ListaAlquileres.BuscarAlquiler2(movimiento.Alquiler);
    
            ListaAlquileres.EliminarAlquiler(auxRenovar);//borro el objeto de la lista
            ListaAlquileres.AgregarAlquiler(movimiento.Alquiler);//agrego el nuevo objeto alq
            manager.AgregarAlquilerXML(ListaAlquileres.MostrarAlquileres());//genero el xml con la nueva lista
            //if(listamovimiento.cantidadElementos()!=0)
            //{
                foreach (Movimiento move in ListaMovimientos.MostrarMovimientos())//recorro la lista de movimientos (para setear la nueva fecha de vencimiento a movimientos tambien)
                {
                    if ((move.Cierre == null) && (move.Alquiler.Cochera.Ubicacion == movimiento.Alquiler.Cochera.Ubicacion))//si esta cerrado y tiene la misma ubicacion
                    {
                        encontro = true;
                        //Estudiar como me actualiza el importe mensual linea 162
                        move.Alquiler = movimiento.Alquiler;
                        move.Importe = movimiento.Importe;
                        managerMov.AgregarXMLMovimientos(ListaMovimientos.MostrarMovimientos());


                    }
                   
                }
            //} 

            if (encontro == false)//chequear 
            {
                //actualizo la fecha desde por la fecha de vencimiento vieja y hasta por la fecha de vencimiento nueva
                AlquilerMensual aux22 = (AlquilerMensual)movimiento.Alquiler;

                //AlquilerMensual alqmen = new AlquilerMensual(auxRenovar.Titular, aux22.Fechavencimiento, auxRenovar.Fechaencimiento, auxRenovar.Cochera);
                AlquilerMensual alqmen = new AlquilerMensual(auxRenovar.Fecha, auxRenovar.Cochera, auxRenovar.Titular, aux22.Fechavencimiento);
               
                Movimiento move = new Movimiento("AlquilerMensual", alqmen.CalcularImporte(), DateTime.Now, movimiento.EsIngreso, movimiento.Usuario, movimiento.Cierre, alqmen);
                ListaAlquileres.AgregarAlquiler(move.Alquiler); //agrego a la lista en memoria
                ListaMovimientos.AgregarMovimientos(move);//verificar
            }
            managerMov.AgregarXMLMovimientos(ListaMovimientos.MostrarMovimientos());



            */
        }
    }
}
