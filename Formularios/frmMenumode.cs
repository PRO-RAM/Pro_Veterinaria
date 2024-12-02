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

namespace Pro_Veterinaria.Formularios
{
    public partial class frmMenumode : Form
    {
        public frmMenumode()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hund, int wmsg, int wparam, int lpram);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            subPaciente.Visible = false;
            frmTipo x = new frmTipo();
            x.ShowDialog();
            this.Hide();
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            subPaciente.Visible = false;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            subPaciente.Visible = false;
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            subPaciente.Visible = true;   
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
