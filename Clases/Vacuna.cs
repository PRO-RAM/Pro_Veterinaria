using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Veterinaria.Clases
{
    internal class Vacuna
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        //campos 
        public int Id;
        public string Nombre;
        public string Tipo;
        public string Caduca;
        public int Stock;


        public Vacuna()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into vacuna (id,Nombre,Tipo,caducidad,stock) values ({Id},'{Nombre}','{Tipo}','{Caduca}',{Stock})";
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
            string consulta = $"update vacuna set Nombre = '{Nombre}', Tipo = '{Tipo}', caducidad = '{Caduca}', stock = {Stock} where id = {Id} ";
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
            string consulta = $"delete from vacuna where id = {Id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se Elimino el Registro";
            return msj;
        }
    }
}
