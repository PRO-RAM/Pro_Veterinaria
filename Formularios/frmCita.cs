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
    public partial class frmCita : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmCita()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
            cargarcbEmpleados();
            cargarcbscota();
        }
        void obtener()
        {
            string consulta = $"select * from Cita where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtEstado.Text = reader["Estado"].ToString();
                txtMotivo.Text = reader["MOtivo"].ToString();
                dtpFcita.Text = reader["Fecha_cita"].ToString();
                cbMascota.Text = reader["idMascota"].ToString();
                cbEmpleado.Text = reader["idEmpleado"].ToString();
                

            }
            else
            {
                MessageBox.Show("El ID ingresado no se encontro en los regristros.");
            }
            con.Close();
        }
        void cargarcbEmpleados()
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
        void cargarcbscota()
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
        void limpiar()
        {
            txtId.Clear();
            txtEstado.Clear();
            txtMotivo.Clear();
            Clases.Herramientas x = new Clases.Herramientas();
            txtId.Text = x.consecutivo("id", "Cita").ToString();
            txtId.Focus();
            txtEstado.Focus();
            txtMotivo.Focus();
        }
       
        private void frmCita_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Cita").ToString();
        }

        private void button1_Click(object sender, EventArgs e)
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
            Clases.Cita x = new Clases.Cita();
            x.Id = int.Parse(txtId.Text);
            x.Esatado = txtEstado.Text;
            x.Motivo = txtMotivo.Text;
            x.idMascota = int.Parse(cbMascota.SelectedValue.ToString());
            x.idEmpleado = int.Parse(cbEmpleado.SelectedValue.ToString());
            string fecha = dtpFcita.Value.Year.ToString() + "/" + dtpFcita.Value.Month.ToString() + "/" + dtpFcita.Value.Day.ToString();
            x.Fcita = fecha;
            if (h.encontrar("Cita", int.Parse(txtId.Text)) == true)
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
            Clases.Cita x = new Clases.Cita();
            x.Id = int.Parse(txtId.Text);
            if (h.encontrar("Cita", int.Parse(txtId.Text)))
            {
                MessageBox.Show(x.eliminar());
            }
            else
            {
                MessageBox.Show("No se encontro el elemento a eliminar");
            }
            limpiar();
        }

        private void cbMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbMascota = Border3DSide  
        }
    }
}
