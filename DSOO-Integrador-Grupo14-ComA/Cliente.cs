using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Integrador_Grupo14_ComA
{
    public class Cliente
    {
        // atributos de la clase Cliente
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Dni { get; set; }
        public string? Tipo { get; set; }
        public string? Direccion { get; set; }
        public string? Mail { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

        // constructor de la clase Cliente
        public Cliente(string nombre, string apellido, string dni, string direccion, string mail, string telefono, DateTime fechaNacimiento, string tipo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Mail = mail;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            Tipo = tipo;
        }

        // metodo para verificar si un cliente existe en la base de datos
        public static bool ExisteDNI(string dni)
        {
            using (MySqlConnection connection = Conexion.GetInstancia().CrearConexion())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM Clientes WHERE DNI = @DNI", connection);
                command.Parameters.AddWithValue("@DNI", dni);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        // metodo para obtener un cliente por DNI
        public static Cliente? ObtenerClientePorDni(string dni)
        {
            Cliente? cliente = null;

            using (MySqlConnection connection = Conexion.GetInstancia().CrearConexion())
            {
                connection.Open();
                string query = "SELECT Nombre, Apellido, DNI, Direccion, Mail, Telefono, FechaNacimiento, Tipo FROM Clientes WHERE DNI = @dni";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new Cliente(
                                reader["Nombre"].ToString()!,
                                reader["Apellido"].ToString()!,
                                reader["DNI"].ToString()!,
                                reader["Direccion"].ToString()!,
                                reader["Mail"].ToString()!,
                                reader["Telefono"].ToString()!,
                                Convert.ToDateTime(reader["FechaNacimiento"]),
                                reader["Tipo"].ToString()!
                                );
                        }
                    }
                }
            }
            return cliente;
        }

        // metodo para agregar un cliente a la base de datos
        public void AgregarCliente()
    {
        using (MySqlConnection connection = Conexion.GetInstancia().CrearConexion())
        {
            connection.Open();
            string query = "INSERT INTO Clientes (Nombre, Apellido, DNI, Direccion, Mail, Telefono, FechaNacimiento, Tipo) VALUES (@Nombre, @Apellido, @DNI, @Direccion, @Mail, @Telefono, @FechaNacimiento, @Tipo)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Apellido", Apellido);
                command.Parameters.AddWithValue("@DNI", Dni);
                command.Parameters.AddWithValue("@Direccion", Direccion);
                command.Parameters.AddWithValue("@Mail", Mail);
                command.Parameters.AddWithValue("@Telefono", Telefono);
                command.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                command.Parameters.AddWithValue("@Tipo", Tipo);
                command.ExecuteNonQuery();
            }
        }
    }
    }
}
