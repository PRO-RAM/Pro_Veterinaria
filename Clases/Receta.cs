using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Veterinaria.Clases
{
    internal class Receta
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //campos 
        public int Id;
        public string Dianostico;
        public int idEmpleado;
        public string Mascota;
        public int idServicio;
        public decimal Total;
        //detalle
        public int idReceta;
        public int ididServicio;
        public int idProducto;
        public int idVacuna;
        public int can_pro;
        public int can_va;
        public decimal pre_pro;
        public decimal pre_va;


        public Receta()
        {
            con.ConnectionString = x.Conexion;
        }
        public void guardar()
        {
            string consulta = $"insert into Receta (id,Dianostico,idEmpleado,Mascota,idServicio,Total)values ({Id},'{Dianostico}',{idEmpleado},'{Mascota}',{ididServicio},{Total})";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void guardardetalle()
        {
            string consulta = $" insert into Rect_det(id,idReceta,idProductos,Can_pro,Pre_pro)values((select isnull(max(id)+1,1) from Rect_det),{Id},{idProducto},{can_pro},{pre_pro})";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
