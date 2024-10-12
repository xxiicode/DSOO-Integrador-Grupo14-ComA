using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_Integrador_Grupo14_ComA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // Para recibir los datos desde la base de datos
            Usuarios dato = new Usuarios(); // Instancia de la clase Usuarios

            // Llama al método Log_Usu con los valores de los campos de texto
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                // El usuario existe
                MessageBox.Show("Ingreso exitoso");
                // Aquí puedes continuar con la lógica para abrir el siguiente formulario
            }
            else
            {
                // Usuario o contraseña incorrectos
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Puedes inicializar valores o configurar algo en el evento de carga aquí.
        }
    }
}
