using Microsoft.Reporting.WinForms;
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

namespace Pro_Veterinaria.Indormes
{
    public partial class frmRCita : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmRCita()
        {
            con.ConnectionString = x.Conexion;
            InitializeComponent();
        }
        void cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = ("select * from Cita");
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbEstado.DisplayMember = "Estado";
            cbEstado.ValueMember = "id";
            cbEstado.DataSource = dt;
        }

        private void frmRCita_Load(object sender, EventArgs e)
        {
            cargarcb();
        }
        void cargarreporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (chTodo.Checked == true)
            {
                consulta = " select * from vCita";
            }
            else
            {
                consulta = $"select * from vCita where id = {cbEstado.SelectedValue.ToString()}";
            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            this.rvCita.LocalReport.DataSources.Clear();
            this.rvCita.LocalReport.ReportEmbeddedResource = "Pro_Veterinaria.Indormes.rCita.rdlc";
            ReportDataSource r = new ReportDataSource("dsvCita", dt);
            this.rvCita.LocalReport.DataSources.Add(r);
            this.rvCita.RefreshReport();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargarreporte();
        }
    }
}
