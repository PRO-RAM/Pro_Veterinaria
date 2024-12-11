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

namespace Pro_Veterinaria.Busquedas
{
    public partial class frmReceta : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmReceta()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void cargaempleados()
        {
            DataTable dt = new DataTable();
            string consulta = ("select id,Nombre + ' ' + A_Paterno +' ' NombreCompleto from Empleado");
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbEmpleados.DisplayMember = "NombreCompleto";
            cbEmpleados.ValueMember = "id";
            cbEmpleados.DataSource = dt;
        }
        void cargarservicio()
        {
            DataTable dt = new DataTable();
            string consulta = ("select * from Servicios ");
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbServicios.DisplayMember = "Nombre";
            cbServicios.ValueMember = "id";
            cbServicios.DataSource = dt;
        }
        void cargarproducto()
        {
            DataTable dt = new DataTable();
            string consulta = ("select id,Nombre me from Producto");
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbProducto.DisplayMember = "me";
            cbProducto.ValueMember = "id";
            cbProducto.DataSource = dt;
        }
        DataTable dt = new DataTable();
        void confdg()
        {
            dt.Columns.Add("id");
            dt.Columns.Add("idReceta");
            dt.Columns.Add("idProducto");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio");
            dgReceta.DataSource = dt;

        }
        void agregar()
        {
            DataRow fila = dt.NewRow();
            fila["id"] = 0;
            fila["idReceta"] = txtId.Text;
            fila["idProducto"] = cbProducto.SelectedValue.ToString();
            fila["Producto"] = cbProducto.Text;
            fila["Cantidad"] = txtCantidad.Text;
            fila["Precio"] = txtPrecio.Text;
            dt.Rows.Add(fila);
            dgReceta.DataSource = dt;

        }
        void cargardg()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("", con);
            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.CommandText = "select r.id,r.idProductos, r.idProductos, p.Nombre,Can_pro,Pre_pro from Rect_det inner join Producto p on r.idProductos = p.id where r.idReceta = idReceta";
            da.SelectCommand.Parameters.Clear();
            da.SelectCommand.Parameters.AddWithValue("@idReceta", txtId.Text);
            da.Fill(dt);
            dgReceta.DataSource = dt;
        }
        decimal obtenerprecio()
        {
            decimal precio = 0;
            string idproducto = cbProducto.SelectedValue.ToString();
            string consulta = $"select Precio from Producto where id = '{idproducto}'";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                precio = (decimal)reader["Precio"];

            }
            con.Close();
            return precio;
        }

        private void frmReceta_Load(object sender, EventArgs e)
        {
            cargaempleados();
            cargarproducto();
            cargarservicio();
            Clases.Herramientas h = new Herramientas();
            txtId.Text = h.consecutivo("id", "Receta").ToString();
            confdg();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
            if (dgReceta.Rows.Count > 0)
            {
                txtTotal.Text = sumatoria().ToString();
            }
        }
        decimal sumatoria()
        {
            decimal sum = 0;
            foreach (DataGridViewRow fila in dgReceta.Rows)
            {
                if (fila.Cells[5].Value != null)
                {
                    sum += decimal.Parse(fila.Cells[5].Value.ToString());
                }
            }
            return sum;
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            txtPrecio.Text = (int.Parse(txtCantidad.Text) * obtenerprecio()).ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Clases.Receta x = new Receta();
            x.Id = int.Parse(txtId.Text);
           x.Dianostico = txtDianostico.Text;
            x.idEmpleado = int.Parse(cbEmpleados.SelectedValue.ToString());
            x.Mascota = txtMascota.Text;
            x.ididServicio = int.Parse(cbServicios.SelectedValue.ToString());
            x.Total = decimal.Parse(txtTotal.Text);
            x.guardar();
            foreach (DataGridViewRow fila in dgReceta.Rows)
            {
                x.idProducto = int.Parse(fila.Cells[2].Value.ToString());
                x.can_pro = int.Parse(fila.Cells[4].Value.ToString());
                x.pre_pro = decimal.Parse(fila.Cells[5].Value.ToString());
                x.guardardetalle();
                MessageBox.Show("Venta Guardada");
            }
        }
    }
}
