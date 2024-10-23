using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DSOO_Integrador_Grupo14_ComA
{
    public partial class VerClientesForm : Form
    {
        public VerClientesForm()
        {
            InitializeComponent();
        }

        private void VerClientesForm_Load(object sender, EventArgs e)
        {
            CargaGrilla();
        }

        public void CargaGrilla()
        {
            MySqlConnection sqlCon = null!;
            try
            {
                string query = "SELECT Nombre, Apellido, DNI, Direccion, Mail, Telefono, FechaNacimiento, Tipo FROM clientes";
                sqlCon = Conexion.GetInstancia().CrearConexion(); // Tu método de conexión.
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dgvClientes.Rows.Add(); // Agrega una fila al DataGridView.
                        dgvClientes.Rows[renglon].Cells[0].Value = reader.GetString(0); // Nombre
                        dgvClientes.Rows[renglon].Cells[1].Value = reader.GetString(1); // Apellido
                        dgvClientes.Rows[renglon].Cells[2].Value = reader.GetString(2); // DNI
                        dgvClientes.Rows[renglon].Cells[3].Value = reader.GetString(3); // Dirección
                        dgvClientes.Rows[renglon].Cells[4].Value = reader.GetString(4); // Mail
                        dgvClientes.Rows[renglon].Cells[5].Value = reader.GetString(5); // Teléfono
                        dgvClientes.Rows[renglon].Cells[6].Value = reader.GetDateTime(6).ToShortDateString(); // Fecha de Nacimiento
                        dgvClientes.Rows[renglon].Cells[7].Value = reader.GetString(7); // Tipo

                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para mostrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
