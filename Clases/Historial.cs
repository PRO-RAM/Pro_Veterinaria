using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Veterinaria.Clases
{
    internal class Historial
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        //campos 
        public int Id;
        public string Fconsulta;
        public string Dianostico;
        public string Tratamiento;
        public string Nota;
        public int idMascota;
        public int idEmpleado;

        public Historial()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Historial_medico (id,Fecha_cons,Dianostico,Tratamineto,Nota,idMascota,idEmpleado)values({Id},'{Fconsulta}','{Dianostico}','{Tratamiento}','{Nota}',{idMascota},{idEmpleado})";
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
            string consulta = $"update Historial_medico set Fecha_cons ='{Fconsulta}', Dianostico ='{Dianostico}', Tratamineto ='{Tratamiento}', Nota ='{Nota}', idMascota ={idMascota}, idEmpleado= {idEmpleado} where id = {Id}";
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
            string consulta = $"delete from Historial_medico where id = {Id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se Elimino el Registro";
            return msj;
        }
    }
}
