using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Veterinaria.Clases
{
    internal class Domicilio
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        //balores
        public int id;
        public string Calle;
        public string Colonia;
        public string Ninterior;
        public string Nexterior;
        public string Referencias;

        public Domicilio()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Domicilio (id,Calle,Referencias,N_int,N_ext,Colonia) values ({id},'{Calle}','{Referencias}','{Ninterior}','{Nexterior}','{Colonia}')";
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
            string consulta = $"update Domicilio set Calle = '{Calle}', Referencias = '{Referencias}', N_int = '{Ninterior}', N_ext = '{Nexterior}', Colonia = '{Colonia}' where id = '{id}'";
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
            string consulta = $"delete from Domicilio where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se Elimino el Registro";
            return msj;
        }
    }
}
