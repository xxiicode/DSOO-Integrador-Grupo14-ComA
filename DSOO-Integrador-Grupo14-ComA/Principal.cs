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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        // Método para el evento Click del botón Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Aquí defines qué sucede cuando el usuario hace clic en "Logout"
            // Por ejemplo, cerrar el formulario o regresar al Login
            this.Close(); // Esto cierra el formulario actual
        }

        // Método para el evento Click del botón Agregar Cliente
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Aquí defines qué sucede cuando el usuario hace clic en "Agregar Cliente"
            MessageBox.Show("Agregar Cliente clickeado");
        }

        // Método para el evento Click del botón Cobrar Cliente
        private void btnCobrarCliente_Click(object sender, EventArgs e)
        {
            // Aquí defines qué sucede cuando el usuario hace clic en "Cobrar Cliente"
            MessageBox.Show("Cobrar Cliente clickeado");
        }

        // Método para el evento Click del botón Mostrar Clientes que vencen hoy
        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            // Aquí defines qué sucede cuando el usuario hace clic en "Mostrar Clientes que vencen hoy"
            MessageBox.Show("Clientes que vencen hoy clickeado");
        }
    }
}