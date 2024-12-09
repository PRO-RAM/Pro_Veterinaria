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
    public partial class frmProducto : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmProducto()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtTipo.Clear();
            Clases.Herramientas x = new Clases.Herramientas();
            txtId.Text = x.consecutivo("id", "Producto").ToString();
            txtId.Focus();
            txtNombre.Focus();
            txtPrecio.Focus();
            txtStock.Focus();
            txtTipo.Focus();
        }
        void obtener()
        {
            string consulta = $"select * from Producto where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtTipo.Text = reader["tipo"].ToString();
                txtStock.Text = reader["stock"].ToString();
                txtPrecio.Text = reader["Precio"].ToString();
            }
            else
            {
                MessageBox.Show("El ID ingresado no se encontro en los regristros.");
            }
            con.Close();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Producto").ToString();
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

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Herramientas h = new Herramientas();
            Clases.Producto x = new Clases.Producto();
            x.Id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.Tipo = txtTipo.Text;
            x.Stock = int.Parse(txtStock.Text);
            x.Precio = decimal.Parse(txtPrecio.Text);
            if (h.encontrar("Producto", int.Parse(txtId.Text)) == true)
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
            Clases.Producto x = new Clases.Producto();
            x.Id = int.Parse(txtId.Text);
            if (h.encontrar("Producto", int.Parse(txtId.Text)))
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

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
