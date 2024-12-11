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
    public partial class frmHistorial : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmHistorial()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            cargarcb();
            cargarcb1();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Historial_medico").ToString();
        }
        void obtener()
        {
            string consulta = $"select * from Historial_medico where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtpFconsulta.Text = reader["Fecha_cons"].ToString();
                txtDianostico.Text = reader["Dianostico"].ToString();
                txtTratamiento.Text = reader["Tratamineto"].ToString();
                txtNota.Text = reader["Nota"].ToString();
                cbMascota.Text = reader["idMascota"].ToString();
                cbEmpleado.Text = reader["idEmpleado"].ToString();

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
            string consulta = ("select * from Mascota");
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbMascota.DisplayMember = "Nombre";
            cbMascota.ValueMember = "id";
            cbMascota.DataSource = dt;
        }
        void cargarcb1()
        {
            DataTable dt = new DataTable();
            string consulta = ("select * from Empleado");
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbEmpleado.DisplayMember = "Nombre";
            cbEmpleado.ValueMember = "id";
            cbEmpleado.DataSource = dt;
        }
        void limpiar()
        {
            txtId.Clear();
            txtDianostico.Clear();
            txtTratamiento.Clear();
            txtNota.Clear();
            Clases.Herramientas x = new Clases.Herramientas();
            txtId.Text = x.consecutivo("id", "Historial_medico").ToString();
            txtId.Focus();
            txtDianostico.Focus();
            txtTratamiento.Focus();
            txtNota.Focus();
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
            Clases.Historial x = new Clases.Historial();
            x.Id = int.Parse(txtId.Text);
            string fecha = dtpFconsulta.Value.Year.ToString() + "/" + dtpFconsulta.Value.Month.ToString() + "/" + dtpFconsulta.Value.Day.ToString();
            x.Fconsulta = fecha;
            x.Dianostico =txtDianostico.Text;
            x.Tratamiento = txtTratamiento.Text;
            x.Nota = txtNota.Text;
            x.idMascota = int.Parse(cbMascota.SelectedValue.ToString());
            x.idEmpleado = int.Parse(cbEmpleado.SelectedValue.ToString());

            if (h.encontrar("Historial_medico", int.Parse(txtId.Text)) == true)
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
            Clases.Historial x = new Clases.Historial();
            x.Id = int.Parse(txtId.Text);
            if (h.encontrar("Historial_medico", int.Parse(txtId.Text)))
            {
                MessageBox.Show(x.eliminar());
            }
            else
            {
                MessageBox.Show("No se encontro el elemento a eliminar");
            }
            limpiar();
        }
    }
}
