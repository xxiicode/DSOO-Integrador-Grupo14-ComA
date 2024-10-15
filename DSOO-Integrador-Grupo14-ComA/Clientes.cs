using MySql.Data.MySqlClient;
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
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM Clientes WHERE DNI = @DNI", connection); //esto se iria si se usa el procedimiento
                //Para llamar al procedimiento de la BBDD
                //MySqlCommand command = new MySqlCommand("ExisteDNI", connection);
                //command.CommandType = CommandType.StoredProcedure;
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
                string query = "INSERT INTO Clientes (Nombre, Apellido, DNI, Direccion, Mail, Telefono, FechaNacimiento, Tipo) VALUES (@Nombre, @Apellido, @DNI, @Direccion, @Mail, @Telefono, @FechaNacimiento, @Tipo)"; //esto se iria si se usa el procedimiento
                //Para llamar al procedimiento de la BBDD
                //MySqlCommand command = new MySqlCommand("RegistrarCliente", connection);
                //command.CommandType = CommandType.StoredProcedure;
                using (MySqlCommand command = new MySqlCommand(query, connection)) //esto se iria si se usa el procedimiento
                { //esto se iria si se usa el procedimiento
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@Tipo", tipo);
                    command.ExecuteNonQuery();
                } //esto se iria si se usa el procedimiento
            }
        }
    }
}
