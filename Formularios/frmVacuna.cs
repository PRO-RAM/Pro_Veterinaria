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
    public partial class dtpCaducidad : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public dtpCaducidad()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void obtener()
        {
            string consulta = $"select * from vacuna where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtTipo.Text = reader["Tipo"].ToString();
                dateTimePicker1.Text = reader["caducidad"].ToString();
                txtStock.Text = reader["stock"].ToString();
            }
            else
            {
                MessageBox.Show("El ID ingresado no se encontro en los regristros.");
            }
            con.Close();
        }
        public void limpiar()
        {
            txtNombre.Clear();
            txtTipo.Clear();
            txtStock.Clear();
            Clases.Herramientas h = new Clases.Herramientas();
            txtId.Text = h.consecutivo("id", "vacuna").ToString();
            txtNombre.Focus();
            txtTipo.Focus();
            txtStock.Focus();
        }

        private void dtpCaducidad_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Clases.Herramientas();
            txtId.Text = h.consecutivo("id", "vacuna").ToString();
        }
    

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtId.Text == "0" || txtId.Text == "")
            {
                MessageBox.Show("ID no valido.");
            }
            else
            {
                obtener();
            }
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from vacuna where id = '{id}'";
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

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Herramientas h = new Herramientas();
            Clases.Vacuna x = new Clases.Vacuna();
            x.Id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.Tipo = txtTipo.Text;
            x.Stock = int.Parse(txtStock.Text);
            string caduca = dateTimePicker1.Value.Year.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString();
            x.Caduca = caduca;
            if (encontro() == true)
            {
                MessageBox.Show(x.actualizar());
            }
            else
            {
                MessageBox.Show(x.guardar());
            }
            limpiar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            Herramientas h = new Herramientas();
            Clases.Vacuna x = new Clases.Vacuna();
            x.Id = int.Parse(txtId.Text);
            if (h.encontrar("vacuna", int.Parse(txtId.Text)) == true)
            {
                MessageBox.Show(x.eliminar());
            }
            else
            {
                MessageBox.Show("No se encontor el elmento a eliminar");
            }
            limpiar();
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
