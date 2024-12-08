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
    public partial class frmMascota : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmMascota()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = ("select * from Domicilio");
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbDomicilio.DisplayMember = "Calle";
            cbDomicilio.ValueMember = "id";
            cbDomicilio.DataSource = dt;
        }

        private void frmMascota_Load(object sender, EventArgs e)
        {
            cargarcb();
            Clases.Herramientas h = new Clases.Herramientas();
            txtId.Text = h.consecutivo("id", "Cliente").ToString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtId.Text);
            string cadena = $"select * from Cliente where id = '{id}'";
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
            Clases.Cliente x = new Clases.Cliente();
            x.Id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.Apaterno = txtAPaterno.Text;
            x.Amaterno = txtAMaterno.Text;
            x.idDomicilio = int.Parse(cbDomicilio.SelectedValue.ToString());
            x.Telefono = txtTelefono.Text;
            x.Correo = txtCorreo.Text;
            string fecha = dtpFecha.Value.Year.ToString() + "/" + dtpFecha.Value.Month.ToString() + "/" + dtpFecha.Value.Day.ToString();
            x.Fechare = fecha;
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
            if (h.encontrar("Domicilio", int.Parse(txtId.Text)) == true)
            {
                MessageBox.Show(x.eliminar());
            }
            else
            {
                MessageBox.Show("No se encontor el elmento a eliminar");
            }
            limpiar();
        }
        public void limpiar()
        {
            Clases.Herramientas h = new Clases.Herramientas();
            txtId.Text = h.consecutivo("id", "Empleado").ToString();
            txtNombre.Clear();
            txtAMaterno.Clear();
            txtAPaterno.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();

            txtTelefono.Focus();
            txtNombre.Focus();
            txtAMaterno.Focus();
            txtAPaterno.Focus();
            txtCorreo.Focus();
            txtTelefono.Focus();
        }
        void obtener()
        {
            string consulta = $"select * from Cliente where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtAMaterno.Text = reader["A_Materno"].ToString();
                txtAPaterno.Text = reader["A_Paterno"].ToString();
                dtpFecha.Text = reader["Fecharegistro"].ToString();
                txtTelefono.Text = reader["Telefono"].ToString();
                txtCorreo.Text = reader["Correo"].ToString();
                cbDomicilio.Text = reader["idDomicilio"].ToString();
            }
            else
            {
                MessageBox.Show("El ID ingresado no se encontro.");
            }
            con.Close();
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

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
    
}
