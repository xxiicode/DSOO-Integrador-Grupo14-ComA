using System;
using System.Windows.Forms;

namespace DSOO_Integrador_Grupo14_ComA
{
    public partial class DatosBD : Form
    {
        public DatosBD()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtPuerto.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, complete los campos Puerto y Usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar los valores en la clase Conexion
            Conexion.GetInstancia().SetConexionDatos(txtPuerto.Text, txtUsuario.Text, txtClave.Text);

            // Abrir el formulario Login
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void DatosBD_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
