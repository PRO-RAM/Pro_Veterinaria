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
using static System.Net.Mime.MediaTypeNames;

namespace Pro_Veterinaria.Formularios
{
    public partial class frmTipo : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmTipo()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
            this.toolTip1.SetToolTip(this.txtNombre, "Por ejmplo canino o felino");
        }
        void obtener()
        {
            string consulta = $"select * from Tipo where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
            }
            else
            {
                MessageBox.Show("El id ingresado no se encontro");
            }
            con.Close();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from Tipo where id = '{id}'";
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
        void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmTipo_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Clases.Herramientas();
            txtId.Text = h.consecutivo("id", "Tipo").ToString();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Tipo x = new Clases.Tipo();
            x.id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            if (encontro())
            {
                MessageBox.Show(x.actualizar());
            }
            else
            {
                MessageBox.Show(x.guardar());
            }
            limpiar();
        
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "0" || txtId.Text == "")
            {
                MessageBox.Show("ID no Encontrado.");
            }
            else
            {
                obtener();
            }
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            Clases.Tipo x = new Clases.Tipo();
            x.id = int.Parse(txtId.Text);
             if(encontro() == true)
            {
                MessageBox.Show (x.eliminar());

            }
            else
            {
                MessageBox.Show("No se encontro el elemento a Eliminar");
            }
             limpiar();
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmMenu x = new frmMenu();
            x.Show();
            this.Hide();
        }
    }
}
