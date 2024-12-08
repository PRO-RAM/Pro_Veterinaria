using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Veterinaria.Clases
{

    internal class Cliente
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //campos 
        public int Id;
        public string Nombre;
        public string Apaterno;
        public string Amaterno;
        public string Correo;
        public string Telefono;
        public int idDomicilio;
        public string Fechare;


        public Cliente()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Cliente (id,Nombre,A_Paterno,A_Materno,Correo,Telefono,idDomicilio,Fecharegistro)values({Id},'{Nombre}','{Apaterno}','{Amaterno}','{Correo}','{Telefono}',{idDomicilio},'{Fechare}')";
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
            string consulta = $"update Cliente set Nombre = '{Nombre}', A_Paterno = '{Apaterno}', A_Materno = '{Amaterno}', Correo = '{Correo}', Telefono = '{Telefono}', idDomicilio = {idDomicilio}, Fecharegistro = '{Fechare}' where id = {Id} ";
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
            string consulta = $"delete from Cliente where id = {Id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se Elimino el Registro";
            return msj;
        }
    }
}
