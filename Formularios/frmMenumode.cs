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
            this.toolTip1.SetToolTip(this.pictureBox5, "Inicio");
            this.toolTip1.SetToolTip(this.pictureBox7, "Cerar Cecion");
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hund, int wmsg, int wparam, int lpram);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void abrirformulario(object formopen)
        {
            if(this.panel12.Controls.Count > 0)
                this.panel12.Controls.RemoveAt(0);
            Form fh = formopen as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel12.Controls.Add(fh);
            this.panel12.Tag = fh;
            fh.Show();
            
        }

            private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            subPaciente.Visible = false;
            abrirformulario(new frmTipo());

        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            subPaciente.Visible = false;
            abrirformulario(new frmMascotaYes());
            
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            subPaciente.Visible = false;
            abrirformulario(new frmHistorial());
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

        private void btnCita_Click(object sender, EventArgs e)
        {
            abrirformulario(new frmCita());
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            abrirformulario(new frmPagInicio());    

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            subCliente.Visible = true;
        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            subCliente.Visible = false;
            abrirformulario(new frmDomicilio());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            subCliente.Visible = false;
            abrirformulario(new frmMascota());
        }

        private void subPaciente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            abrirformulario(new frmServicio());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirformulario(new frmProducto());
        }

        private void btnVacuna_Click(object sender, EventArgs e)
        {
            abrirformulario(new dtpCaducidad());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            abrirformulario(new frmEmpleado());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmMenumode g = new frmMenumode();
            this.Hide();

           Inicio h = new Inicio();
            h.ShowDialog();
        }

        private void btnReceta_Click(object sender, EventArgs e)
        {
            Busquedas.frmReceta x = new Busquedas.frmReceta();
            x.ShowDialog();
        }
    }
}
