﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Veterinaria.Clases
{
    public class Herramientas
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public Herramientas()
        {
            con.ConnectionString = x.Conexion;
        }
        public int consecutivo(string campo, string tabla)
        {
            int id = 0;
            string consulta = $"select isnull(max({campo})+1,1) as maxid from {tabla}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                id = int.Parse(lector["maxid"].ToString());
            }
            con.Close();
            return id;
        }
        public bool encontrar(string tabla, int id)
        {
            bool a = false;
            string query = $"select * from {tabla} where id = {id}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                a = true;
            }
            con.Close();
            return a;
        }
    }
}
