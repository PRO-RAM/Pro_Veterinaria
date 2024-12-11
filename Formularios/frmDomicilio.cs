using Pro_Veterinaria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Veterinaria.Formularios
{
    public partial class frmDomicilio : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmDomicilio()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void obtener()
        {
            string consulta = $"select * from Domicilio where id = {txtId.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtCalle.Text = reader["Calle"].ToString();
                txtReferencias.Text = reader["Referencias"].ToString();
                txtN_interior.Text = reader["N_int"].ToString();
                txtN_exterior.Text = reader["N_ext"].ToString();
                txtColonia.Text = reader["Colonia"].ToString();
            }
            else
            {
                MessageBox.Show("El ID ingresado no se encontro en los regristros.");
            }
            con.Close();
        }
        void limpiar()
        {
            txtColonia.Clear();
            txtReferencias.Clear();
            txtN_interior.Clear();
            txtN_exterior.Clear();
            txtCalle.Clear();
            Clases.Herramientas x = new Clases.Herramientas();
            txtId.Text = x.consecutivo("id", "Domicilio").ToString();
        }

        //bool encontro()
        //{
        //    bool a = false;
        //    int id = int.Parse(txtId.Text);
        //    string cadena = $"select * from Domicilio where id = '{id}'";
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(cadena, con);
        //    SqlDataReader lector = cmd.ExecuteReader();
        //    if (lector.Read())
        //    {
        //        a = true;
        //    }
        //    else
        //    {
        //        a = false;
        //    }
        //    con.Close();
        //    return a;
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDomicilio_Load(object sender, EventArgs e)
        {
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Domicilio").ToString();
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
            Clases.Domicilio x = new Clases.Domicilio();
            x.id = int.Parse(txtId.Text);
            x.Calle = txtCalle.Text;
            x.Referencias = txtReferencias.Text;
            x.Ninterior = txtN_interior.Text;
            x.Nexterior = txtN_exterior.Text;
            x.Colonia = txtColonia.Text;
            if (h.encontrar("Domicilio", int.Parse(txtId.Text))== true)
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
            Clases.Domicilio x = new Clases.Domicilio();
            x.id = int.Parse(txtId.Text);
            if (h.encontrar("Domicilio", int.Parse(txtId.Text)))
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.frmBusquedaDomicilio x = new
                Busquedas.frmBusquedaDomicilio();
            x.ShowDialog();
            if (x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                txtId.Text = x.dgDomicilio.SelectedRows[0].Cells["id"].Value.ToString();
                txtCalle.Text = x.dgDomicilio.SelectedRows[0].Cells["Calle"].Value.ToString();
                txtN_interior.Text = x.dgDomicilio.SelectedRows[0].Cells["N_int"].Value.ToString();
                txtN_exterior.Text = x.dgDomicilio.SelectedRows[0].Cells["N_ext"].Value.ToString();
                txtReferencias.Text = x.dgDomicilio.SelectedRows[0].Cells["Referencias"].Value.ToString();
               txtColonia.Text = x.dgDomicilio.SelectedRows[0].Cells["Colonia"].Value.ToString();
                
            }
        }
    }
}
