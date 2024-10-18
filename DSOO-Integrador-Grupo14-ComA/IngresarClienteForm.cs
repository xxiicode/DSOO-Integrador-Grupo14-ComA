﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class IngresarClienteForm : Form
    {
        public string DniIngresado { get; set; }

        // Constructor que acepta el DNI como argumento
        public IngresarClienteForm(string dni)
        {
            DniIngresado = dni ?? throw new ArgumentNullException(nameof(dni)); //agregado para no dar un advertencia
            InitializeComponent();
            txtDNI.Text = dni; // DNI ingresado desde el formulario anterior
        }

    private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string dni = txtDNI.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string mail = txtMail.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string? tipo = cmbTipo.SelectedItem?.ToString();

            if (tipo == null)
            {
                MessageBox.Show("Por favor, selecciona un tipo de Cliente.");
                return;
            }

            Clientes clientes = new Clientes();
            try
            {
                clientes.RegistrarCliente(nombre, apellido, dni, direccion, mail, telefono, fechaNacimiento, tipo);
                MessageBox.Show("Cliente registrado exitosamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtMail.Clear();
            cmbTipo.SelectedIndex = -1;
            txtNombre.Focus();
        }
    }
}