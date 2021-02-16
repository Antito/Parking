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
    public partial class Alertas : Form
    {
        Alquileres ListaAlquileres = new Alquileres();
        public Alertas(List<Alquiler> alerta)
        {
            InitializeComponent();
            ListaAlquileres.AgregarAlquileresenLote(alerta);

        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            bindingSourceAlertas.DataSource = ListaAlquileres.MostrarAlquileres(); 
            listBoxAlertas.DataSource = bindingSourceAlertas;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
