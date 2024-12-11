using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Veterinaria.Clases
{
    internal class Empleados
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        // campos 
        public int Id;
        public string Nombre;
        public string Apaterno;
        public string Amaterno;
        public string Fnacimiento;
        public string Fcontratacion;
        public string Telefono;
        public string Correo;
        public string CURP;
        public string RFC; 
        public string NSS;
        public int idDomicilio;

        public Empleados()
        {
            con.ConnectionString = x.Conexion;
        }
        public string guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"insert into Empleado (id,Nombre,A_Paterno,A_Materno,Fecha_na,Fevha_co,Telefono,Correo,CURP,RFC,NSS,idDomicilio)values ({Id},'{Nombre}','{Apaterno}','{Amaterno}','{Fnacimiento}','{Fcontratacion}','{Telefono}','{Correo}','{CURP}','{RFC}','{NSS}',{idDomicilio})";
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
            string consulta = $"update Empleado set Nombre = '{Nombre}', A_Paterno ='{Apaterno}',A_Materno = '{Amaterno}',Fecha_na = '{Fnacimiento}',Fevha_co ='{Fcontratacion}',Correo = '{Correo}',CURP = '{CURP}',RFC ='{RFC}',NSS ='{NSS}', idDomicilio ={idDomicilio} where id ={Id}";
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
            string consulta = $"delete from Empleado where id = {Id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "Se Elimino el Registro";
            return msj;
        }
    }
}
