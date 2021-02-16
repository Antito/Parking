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
    public partial class Form1 : Form
    {

        XMLUsuarios managerusuarios = new XMLUsuarios();
        ColeccionUsuarios users = new ColeccionUsuarios();
        Estacionamiento estacionamiento = new Estacionamiento();
        Usuario user1 = new Usuario("Anto", "1234", DateTime.Now);
        //Usuario user2 = new Usuario("Luquita", "456", DateTime.Now);

        public Form1() 
        {
            InitializeComponent();
            
            
            textBox1.Select();  

        }

        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text =="USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DarkGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
           
            DialogResult dialogResult = MessageBox.Show("¿Desea salir?", "Saliendo del sistema", MessageBoxButtons.YesNo);
           
            if (dialogResult == DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();
            }
           
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i =1; i <= 20; i++) //cargo cocheras
            {
                Cochera cochera = new Cochera(i, "A"+i, false, null);
                estacionamiento.AgregarCochera(cochera); 
            }
           
            users.AgregarUsuario(user1);
            //users.AgregarUsuario(user2);
            try
            {
                
                managerusuarios.GenerarXMLUsuario(users.ListarUsuarios());
            }
            catch
            {
                MessageBox.Show("Error XML Usuarios");
            }
            
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e) //esto se pasa a Key Press para que abra con un Enter
        {
            string uservalidar = txtUsuario.Text;
            string passvalidar = txtPassword.Text;
            bool iniciar = false;

            foreach (Usuario aux in users.ListarUsuarios())
            {
                if (aux.U == uservalidar & aux.Password == passvalidar)
                {
                    iniciar = true;
                }
            }

            if (iniciar == true)
            {
                Principal p = new Principal(user1, estacionamiento.DevolverTodos());
                //this.Close(); cierra un formulario
                this.Hide(); //oculta un formulario 
                p.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e) //cuando hago enter
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string uservalidar = txtUsuario.Text;
                string passvalidar = txtPassword.Text;
                bool iniciar = false;

                foreach (Usuario aux in users.ListarUsuarios())
                {
                    if (aux.U == uservalidar & aux.Password == passvalidar)
                    {
                        iniciar = true;
                    }
                }

                if (iniciar == true)
                {
                    Principal p = new Principal(user1, estacionamiento.DevolverTodos());
                    //this.Close(); cierra un formulario
                    this.Hide(); //oculta un formulario 
                    p.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña recuperar = new RecuperarContraseña();
            recuperar.ShowDialog();
        }
    }
}
