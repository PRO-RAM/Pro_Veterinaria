using Pro_Veterinaria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pro_Veterinaria.Formularios
{
    public partial class Inicio : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public Inicio()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hund, int wmsg,
        int wparam, int lpram);
        bool encontro()
        {
            bool a = false;
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            string cadena = $"select * from inicio where Usuario = '{Usuario}'  and Contraseña = '{Contraseña}'";
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                a = true;
            }
            else
            {
                a = false;
            }
            con.Close();
            return a;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if(encontro() == true)
            {
                MessageBox.Show("Bienvenido");
                frmMenumode x = new frmMenumode();
                x.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("La contraseña o el correo son incorectas");
            }
        }

        private void txtUsuario_MouseEnter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_MouseLeave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor= Color.DimGray;
            }
        }

        private void txtContraseña_MouseEnter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_MouseLeave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
