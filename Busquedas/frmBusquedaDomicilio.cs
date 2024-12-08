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

namespace Pro_Veterinaria.Busquedas
{
    public partial class frmBusquedaDomicilio : Form
    {
        Clases.ConexionSQL x = new Clases.ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaDomicilio()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        private void frmBusquedaDomicilio_Load(object sender, EventArgs e)
        {
            try
            {
                dgDomicilio.Rows[0].Selected = true;
            }
            catch { }
        }
        void cargardg()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from Domicilio where id Like'%{txtFiltrar.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgDomicilio.DataSource = dt;
            con.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargardg();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dgDomicilio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgDomicilio.CurrentRow.Index;
            dgDomicilio.Rows[i].Selected = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            cargardg();

        }
    }
}
