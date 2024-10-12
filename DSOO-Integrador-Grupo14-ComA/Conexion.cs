﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DSOO_Integrador_Grupo14_ComA
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {
            this.baseDatos = "proyecto";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "";

        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString =   "datasource=" + this.servidor +
                                            ";port=" + this.puerto +
                                            ";username=" + this.usuario +
                                            ";password=" + this.clave +
                                            ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la conexión: " + ex.Message);
                cadena = null;
                throw;
            }
            return cadena;
        }
        public static Conexion GetInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
