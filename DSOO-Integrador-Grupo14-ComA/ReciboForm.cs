using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DSOO_Integrador_Grupo14_ComA
{
    public partial class ReciboForm : Form
    {
        // Declara el PrintDocument
        private PrintDocument pd = new PrintDocument();

        public ReciboForm(string nombre, string apellido, string dni, string tipo, string referencia, decimal monto)
        {
            InitializeComponent();

            lblTituloPrincipal.Text = "Club Deportivo n14";
            lblSubtituloFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            lblNombre.Text = "Nombre: " + nombre;
            lblApellido.Text = "Apellido: " + apellido;
            lblDni.Text = "DNI: " + dni;
            lblTipoCliente.Text = "Tipo: " + tipo;
            lblReferencia.Text = "Referencia: " + referencia;
            lblMonto.Text = "Pago: $" + monto.ToString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            // Asocia el evento PrintPage al método ImprimirRecibo
            pd.PrintPage += new PrintPageEventHandler(ImprimirRecibo);
            // Inicia el proceso de impresión
            pd.Print();
            MessageBox.Show("Operación exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cierra el formulario después de imprimir
        }

        private void ImprimirRecibo(object sender, PrintPageEventArgs e)
        {
            // Define las coordenadas y el tamaño del área de impresión
            int x = 100;
            int y = 100;
            int ancho = this.Width;
            int alto = this.Height;

            // Crea un bitmap para dibujar el formulario
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, new Rectangle(0, 0, ancho, alto));

            // Dibuja la imagen del formulario en el área de impresión
            e.Graphics!.DrawImage(img, new Point(x, y));
        }
    }
}
