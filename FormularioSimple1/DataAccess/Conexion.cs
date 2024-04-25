﻿

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace FormularioSimple1.DataAccess
{
    internal class Conexion
    {
        public bool IntentoDeConexion(string cadenaDeConexion)
        {
            try { 
            using (var conexion = new MySqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;   
            }
        
        }

        public DataTable ObtenerDatos(string cadenaDeConexion) 
        { 
        DataTable dt = new DataTable();
            try
            {
                using (var conexion = new MySqlConnection (cadenaDeConexion))
                {
                    conexion.Open();
                    string query = "SELECT * FROM CatPersonal";
                    using (var comando = new MySqlCommand(query, conexion))
                    using (var adapter = new MySqlDataAdapter(comando))
                    {
                        adapter.Fill(dt);
                    } 

                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error al obtener la información" + ex.Message);
            }
            return dt;
        }



    }
}
