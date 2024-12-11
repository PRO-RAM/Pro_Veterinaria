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
    public partial class frmEmpleado : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmEmpleado()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
            cargarcb();
        }
        void obtener()
        {
            string consulta = $"select * from Empleado where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtApaterno.Text = reader["A_Paterno"].ToString();
                txtAmaterno.Text = reader["A_Materno"].ToString();
                dtFNacimiento.Text = reader["Fecha_na"].ToString();
                txtTelefono.Text = reader["Telefono"].ToString();
                txtCorreo.Text = reader["Correo"].ToString();
                txtCURP.Text = reader["CURP"].ToString();
                txtRFC.Text = reader["RFC"].ToString();
                txtNSS.Text = reader["NSS"].ToString();
                cbDomicilio.Text = reader["idDomicilio"].ToString();

            }
            else
            {
                MessageBox.Show("El ID ingresado no se encontro en los regristros.");
            }
            con.Close();
        }
        void cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = ("select * from Domicilio");
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbDomicilio.DisplayMember = "Colonia";
            cbDomicilio.ValueMember = "id";
            cbDomicilio.DataSource = dt;
        }
        void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApaterno.Clear();
            txtAmaterno.Clear();
            txtCorreo.Clear();
            txtNSS.Clear();
            txtRFC.Clear();
            txtCURP.Clear();
            txtTelefono.Clear();
            Clases.Herramientas x = new Clases.Herramientas();
            txtId.Text = x.consecutivo("id", "Empleado").ToString();
            txtId.Focus();
            txtNombre.Focus();
            txtApaterno.Focus();
            txtAmaterno.Focus();
            txtCorreo.Focus();
            txtNSS.Focus();
            txtRFC.Focus();
            txtCURP.Focus();
            txtTelefono.Focus();

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Empleado").ToString();
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
            Clases.Empleados x = new Clases.Empleados();
            x.Id = int.Parse(txtId.Text);
            x.Nombre = txtNombre.Text;
            x.Apaterno = txtApaterno.Text;
            x.Amaterno = txtAmaterno.Text;
            string fecha = dtFNacimiento.Value.Year.ToString() + "/" + dtFNacimiento.Value.Month.ToString() + "/" + dtFNacimiento.Value.Day.ToString();
            x.Fnacimiento = fecha;
            string fecha1 = dtFContratacion.Value.Year.ToString() + "/" + dtFContratacion.Value.Month.ToString() + "/" + dtFContratacion.Value.Day.ToString();
            x.Fcontratacion = fecha1;
            x.Telefono = txtTelefono.Text;
            x.Correo = txtCorreo.Text;
            x.CURP = txtCURP.Text;
            x.RFC = txtRFC.Text;
            x.NSS = txtNSS.Text;
            x.idDomicilio = int.Parse(cbDomicilio.SelectedValue.ToString());

            if (h.encontrar("Empleado", int.Parse(txtId.Text)) == true)
            {
                MessageBox.Show(x.actualizar());
            }
            else
            {
                MessageBox.Show(x.guardar());
            }
            limpiar();
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            Herramientas h = new Herramientas();
            Clases.Empleados x = new Clases.Empleados();
            x.Id = int.Parse(txtId.Text);
            if (h.encontrar("Empleado", int.Parse(txtId.Text)))
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
    }
}
