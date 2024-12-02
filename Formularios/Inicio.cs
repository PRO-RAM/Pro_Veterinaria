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
                frmMenu x = new frmMenu();
                x.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("La contraseña o el correo estan MAL");
            }
        }
    }
}
