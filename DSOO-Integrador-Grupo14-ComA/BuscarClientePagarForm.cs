﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DSOO_Integrador_Grupo14_ComA
{
    public partial class BuscarClientePagarForm : Form
    {
        public string DniIngresado { get; set; } = string.Empty;

        public string Dni
        {
            get { return txtDNI.Text; }
        }

        public BuscarClientePagarForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();

            if (!Cliente.ExisteDNI(dni)) // si falso, el DNI no existe
            {
                MessageBox.Show("El DNI no está registrado en la base de datos.");
            }
            else
            {
                CobrarClienteForm cobrarClienteForm = new CobrarClienteForm(dni);
                cobrarClienteForm.Owner = this.Owner;
                cobrarClienteForm.ShowDialog();
                this.Close();
            }
        }
    }
}
