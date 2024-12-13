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
    public partial class frmRreceta : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmRreceta()
        {
            con.ConnectionString = x.Conexion;
            InitializeComponent();
        }
        void cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = ("select * from Receta");
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbEstado.DisplayMember = "Mascota";
            cbEstado.ValueMember = "id";
            cbEstado.DataSource = dt;
        }
        void cargarreporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (chTodo.Checked == true)
            {
                consulta = " select * from vReceta";
            }
            else
            {
                consulta = $"select * from vReceta where id = {cbEstado.SelectedValue.ToString()}";
            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            this.rvReceta.LocalReport.DataSources.Clear();
            this.rvReceta.LocalReport.ReportEmbeddedResource = "Pro_Veterinaria.Indormes.Report1.rdlc";
            ReportDataSource r = new ReportDataSource("dsvReseta", dt);
            this.rvReceta.LocalReport.DataSources.Add(r);
            this.rvReceta.RefreshReport();
        }

        private void frmRreceta_Load(object sender, EventArgs e)
        {
            cargarcb();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargarreporte();
        }
    }
}
