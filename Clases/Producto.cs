using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Veterinaria.Clases
{
    internal class Producto
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //campos
        public int Id;
        public string Nombre;
        public string Tipo;
        public int Stock;
        public decimal Precio;

        public Producto()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Producto(id,Nombre, tipo, stock,Precio) values ({Id},'{Nombre}','{Tipo}',{Stock},{Precio})";
                con.Open();
                SqlCommand cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "Proceso Exitoso";
            }
            catch
            {
                msj = "!!!Erro en el Guardado!!!";
            }
            return msj;

        }
        public string actualizar()
        {
            string msj = "";
            string consulta = $"update Producto set Nombre = '{Nombre}', tipo = '{Tipo}', stock = {Tipo} , Precio = {Precio} where id = {Id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Cambios Guardados";
            return msj;
        }
        public string eliminar()
        {
            string msj = "";
            string consulta = $"delete from Producto where id = {Id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se Elimino el Registro";
            return msj;
        }
    }
}
