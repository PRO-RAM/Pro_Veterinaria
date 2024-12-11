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
    public partial class frmServicio : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmServicio()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void frmServicio_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Servicios").ToString();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from Servicios where id = '{id}'";
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
        void obtener()
        {
            string consulta = $"select * from Servicios where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtDescripcion.Text = reader["Descripcion"].ToString();
                txtPrecio.Text = reader["Costo"].ToString();
                
            }
            else
            {
                MessageBox.Show("El ID ingresado no se encontro en los regristros.");
            }
            con.Close();
        }
        void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            Clases.Herramientas x = new Clases.Herramientas();
            txtId.Text = x.consecutivo("id", "Servicios").ToString();
            txtId.Focus();
            txtNombre.Focus();
            txtDescripcion.Focus();
            txtPrecio.Focus();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Herramientas h = new Herramientas();
            Clases.Servicio x = new Clases.Servicio();
            x.id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.Descripcion = txtDescripcion.Text;
            x.Costo = decimal.Parse(txtPrecio.Text);
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
            Clases.Domicilio x = new Clases.Domicilio();
            x.id = int.Parse(txtId.Text);
            if (h.encontrar("Servicios", int.Parse(txtId.Text)))
            {
                MessageBox.Show(x.eliminar());
                MessageBox.Show("Se elimino el registro.");
            }
            else
            {
                MessageBox.Show("No se encontro el elemento a eliminar");
            }
            limpiar();
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
    }
}
