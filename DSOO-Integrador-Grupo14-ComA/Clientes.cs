using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DSOO_Integrador_Grupo14_ComA
{
    public class Clientes
    {
        public bool ExisteDNI(string dni)
        {
            using (MySqlConnection connection = Conexion.GetInstancia().CrearConexion())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM Clientes WHERE DNI = @DNI", connection);
                command.Parameters.AddWithValue("@DNI", dni);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0; // Devuelve verdadero si el DNI existe
            }
        }

        public void RegistrarCliente(string nombre, string apellido, string dni, string direccion, string mail, string telefono, DateTime fechaNacimiento, string tipo)
        {
            using (MySqlConnection connection = Conexion.GetInstancia().CrearConexion())
            {
                connection.Open();
                string query = "INSERT INTO Clientes (Nombre, Apellido, DNI, Direccion, Mail, Telefono, FechaNacimiento, Tipo) VALUES (@Nombre, @Apellido, @DNI, @Direccion, @Mail, @Telefono, @FechaNacimiento, @Tipo)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@Tipo", tipo);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Nuevo método para obtener cliente por DNI
        public Cliente ObtenerClientePorDni(string dni)
        {
            Cliente cliente = null!; // Inicializamos el objeto cliente como nulo

            // Conexión a la base de datos
            using (MySqlConnection connection = Conexion.GetInstancia().CrearConexion())
            {
                connection.Open(); // Abrimos la conexión
                string query = "SELECT Nombre, Apellido, DNI, Tipo FROM Clientes WHERE DNI = @dni"; // Consulta SQL

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@dni", dni); // Usamos un parámetro para evitar inyecciones SQL

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Si se encuentra un registro
                        if (reader.Read())
                        {
                            // Creamos el objeto cliente con los datos obtenidos
                            cliente = new Cliente
                            {
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Dni = reader["DNI"].ToString(),
                                Tipo = reader["Tipo"].ToString()
                            };
                        }
                    }
                }
            }

            return cliente!; // Devolvemos el cliente encontrado o nulo si no se encontró
        }
    }

    // Clase Cliente para almacenar la información del cliente
    public class Cliente
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Dni { get; set; }
        public string? Tipo { get; set; }
    }
}
