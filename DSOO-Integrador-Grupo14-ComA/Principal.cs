using MySql.Data.MySqlClient;
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
                IngresarDniForm formDni = new IngresarDniForm();
                formDni.Owner = this;
                formDni.ShowDialog();
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            VerClientesForm verClientesForm = new VerClientesForm();
            verClientesForm.ShowDialog();
        }

        private void btnCobrarCliente_Click(object sender, EventArgs e)
        {
            BuscarClientePagarForm formBuscarCliente = new BuscarClientePagarForm();
            formBuscarCliente.Owner = this;
            formBuscarCliente.ShowDialog();
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clientes que vencen hoy clickeado");
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}