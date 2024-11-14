namespace DSOO_Integrador_Grupo14_ComA
{
    partial class ReciboForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxRecibo;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Label lblSubtituloFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnImprimir;

        // Este método inicializa los controles del diseño del formulario.
        private void InitializeComponent()
        {
            groupBoxRecibo = new GroupBox();
            lblTituloPrincipal = new Label();
            lblSubtituloFecha = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblTipoCliente = new Label();
            lblReferencia = new Label();
            lblMonto = new Label();
            btnImprimir = new Button();
            groupBoxRecibo.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRecibo
            // 
            groupBoxRecibo.Controls.Add(lblTituloPrincipal);
            groupBoxRecibo.Controls.Add(lblSubtituloFecha);
            groupBoxRecibo.Controls.Add(lblNombre);
            groupBoxRecibo.Controls.Add(lblApellido);
            groupBoxRecibo.Controls.Add(lblDni);
            groupBoxRecibo.Controls.Add(lblTipoCliente);
            groupBoxRecibo.Controls.Add(lblReferencia);
            groupBoxRecibo.Controls.Add(lblMonto);
            groupBoxRecibo.Location = new Point(20, 20);
            groupBoxRecibo.Name = "groupBoxRecibo";
            groupBoxRecibo.Size = new Size(360, 350);
            groupBoxRecibo.TabIndex = 0;
            groupBoxRecibo.TabStop = false;
            groupBoxRecibo.Text = "Detalles del Recibo";
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloPrincipal.Location = new Point(60, 20);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(240, 30);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "Club Deportivo n14";
            lblTituloPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtituloFecha
            // 
            lblSubtituloFecha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtituloFecha.Location = new Point(60, 60);
            lblSubtituloFecha.Name = "lblSubtituloFecha";
            lblSubtituloFecha.Size = new Size(240, 25);
            lblSubtituloFecha.TabIndex = 1;
            lblSubtituloFecha.Text = "Fecha: (Fecha actual)";
            lblSubtituloFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(20, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(280, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(20, 140);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(280, 25);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(20, 180);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(280, 25);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI:";
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoCliente.Location = new Point(20, 220);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(280, 25);
            lblTipoCliente.TabIndex = 5;
            lblTipoCliente.Text = "Tipo:";
            // 
            // lblReferencia
            // 
            lblReferencia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblReferencia.Location = new Point(20, 260);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(280, 25);
            lblReferencia.TabIndex = 6;
            lblReferencia.Text = "Referencia:";
            // 
            // lblMonto
            // 
            lblMonto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonto.Location = new Point(20, 300);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(280, 25);
            lblMonto.TabIndex = 7;
            lblMonto.Text = "Monto:";
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.Location = new Point(120, 380);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(160, 40);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir Comprobante";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // ReciboForm
            // 
            ClientSize = new Size(400, 450);
            Controls.Add(groupBoxRecibo);
            Controls.Add(btnImprimir);
            Name = "ReciboForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recibo de Pago";
            groupBoxRecibo.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
