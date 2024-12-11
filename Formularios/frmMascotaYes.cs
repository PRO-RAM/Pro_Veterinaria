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
    public partial class frmMascotaYes : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmMascotaYes()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
            cargarcb();
            cargarcb1();
        }
        void cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = ("select * from Tipo");
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbTipo.DisplayMember = "Nombre";
            cbTipo.ValueMember = "id";
            cbTipo.DataSource = dt;
        }
        void cargarcb1()
        {
            DataTable dt = new DataTable();
            string consulta = ("select * from Cliente");
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "id";
            cbCliente.DataSource = dt;
        }

        private void frmMascotaYes_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Clases.Herramientas();
            txtId.Text = h.consecutivo("id", "Cliente").ToString();
        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from Mascota where id = '{id}'";
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
            Clases.Mascota x = new Clases.Mascota();
            x.Id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.idTipo = int.Parse(cbTipo.SelectedValue.ToString());
            x.Raza = txtRaza.Text; 
            x.Genero = txtGenero.Text;
            x.Peso = decimal.Parse(txtPeso.Text);
            x.Edad = txtEdad.Text;
            x.idCliente = int.Parse(cbCliente.SelectedValue.ToString());
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
            Clases.Cliente x = new Clases.Cliente();
            x.Id = int.Parse(txtId.Text);
            if (encontro() == true)
            {
                MessageBox.Show(x.eliminar());
            }
            else
            {
                MessageBox.Show("No se encontor el elmento a eliminar");
            }
            limpiar();
        }
        void limpiar()
        {
            Clases.Herramientas h = new Clases.Herramientas();
            txtId.Text = h.consecutivo("id", "Mascota").ToString();
            txtNombre.Clear();
            txtRaza.Clear();
            txtPeso.Clear();
            txtEdad.Clear();
            txtGenero.Clear();
            txtNombre.Focus();
            txtRaza.Focus();
            txtPeso.Focus();
            txtEdad.Focus();
            txtGenero.Focus();
        }
        void obtener()
        {
            string consulta = $"select * from Mascota where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                cbTipo.Text = reader["Tipo"].ToString();
                cbCliente.Text = reader["idCliente"].ToString();
                txtRaza.Text = reader["Raza"].ToString();
                txtGenero.Text = reader["Genero"].ToString();
                txtPeso.Text = reader["Peso"].ToString();
                txtEdad.Text = reader["Edad"].ToString();
            }
            else
            {
                MessageBox.Show("El ID ingresado no se encontro.");
            }
            con.Close();
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {

            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
