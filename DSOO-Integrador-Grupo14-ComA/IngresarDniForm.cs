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
    public partial class IngresarDniForm : Form
    {
        public string DniIngresado { get; set; } = string.Empty;

        public string Dni
        {
            get { return txtDNI.Text; }
        }

        public IngresarDniForm()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            Clientes clientes = new Clientes();

            if (clientes.ExisteDNI(dni))
            {
                MessageBox.Show("El DNI ya está registrado en la base de datos.");
            }
            else
            {
                IngresarClienteForm ingresarClienteForm = new IngresarClienteForm(dni);
                ingresarClienteForm.Owner = this.Owner;
                ingresarClienteForm.ShowDialog();
                this.Close();
            }
        }
    }
}