using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Veterinaria.Clases
{
    internal class Mascota
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //campos
        public int Id;
        public string Nombre;
        public int idTipo;
        public string Raza;
        public string Genero;
        public decimal Peso;
        public string Edad;
        public int idCliente;

        public Mascota()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Mascota (id,Nombre,Tipo,Raza,Genero,Peso,Edad,idCliente) values ({Id},'{Nombre}',{idTipo},'{Raza}','{Genero}',{Peso},'{Edad}',{idCliente})";
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
            string consulta = $"update Mascota set Nombre = '{Nombre}', Tipo = {idTipo}, Raza = '{Raza}', Genero = '{Genero}', Peso = {Peso} , Edad = '{Edad}', idCliente = {idCliente} where id = {Id} ";
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
            string consulta = $"delete from Mascota where id = {Id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se Elimino el Registro";
            return msj;
        }
    }
}
