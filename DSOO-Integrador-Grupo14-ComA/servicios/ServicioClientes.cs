using DSOO_Integrador_Grupo14_ComA.entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace DSOO_Integrador_Grupo14_ComA.servicios
{
    public class ServicioClientes
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

        public void RegistrarCliente(Cliente cliente)
        {
            using (MySqlConnection connection = Conexion.GetInstancia().CrearConexion())
            {
                connection.Open();
                string query = "INSERT INTO Clientes (Nombre, Apellido, DNI, Direccion, Mail, Telefono, FechaNacimiento, Tipo) VALUES (@Nombre, @Apellido, @DNI, @Direccion, @Mail, @Telefono, @FechaNacimiento, @Tipo)"; //esto se iria si se usa el procedimiento

                using (MySqlCommand command = new MySqlCommand(query, connection)) 
                { 
                    command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("@DNI", cliente.Dni);
                    command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    command.Parameters.AddWithValue("@Mail", cliente.Mail);
                    command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    command.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                    command.Parameters.AddWithValue("@Tipo", cliente.Tipo);
                    command.ExecuteNonQuery();
                } 
            }
        }
    }
}
