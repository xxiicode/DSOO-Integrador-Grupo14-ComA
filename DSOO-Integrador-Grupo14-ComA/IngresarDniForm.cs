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
        // variable para saber que vista mostrar
        private string _tipoVista;
        public string DniIngresado { get; set; } = string.Empty;

        public string Dni
        {
            get { return txtDNI.Text; }
        }

        public IngresarDniForm(string tipoVista)
        {
            _tipoVista = tipoVista; // Asigna el tipo de vista recibido
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();

            if (_tipoVista == "agregar") 
            { 
                if (Cliente.ExisteDNI(dni)) // si verdadero, el DNI ya existe
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
            if (_tipoVista == "cobrar")
            {
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
}