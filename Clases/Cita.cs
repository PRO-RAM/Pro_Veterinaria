using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Veterinaria.Clases
{
    internal class Cita
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        // campos 
        public int Id;
        public string Esatado;
        public string Motivo;
        public string Fcita;
        public int idMascota;
        public int idEmpleado;
        public Cita()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Cita(id,Estado,MOtivo,Fecha_cita,idMascota,idEmpleado) values ({Id},'{Esatado}','{Motivo}','{Fcita}',{idMascota},{idEmpleado})";
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
            string consulta = $"update Cita set Estado = '{Esatado}', MOtivo ='{Motivo}',Fecha_cita = '{Fcita}', idMascota = {idMascota}, idEmpleado ={idEmpleado} where id ={Id}";
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
            string consulta = $"delete from Cita where id = {Id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se Elimino el Registro";
            return msj;
        }
    }
}
