namespace DSOO_Integrador_Grupo14_ComA
{
    partial class CobrarClienteForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            lblReferencia = new Label();
            lblMonto = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtReferencia = new TextBox();
            txtMonto = new TextBox();
            btnCobrar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 23);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(16, 69);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(16, 115);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(38, 20);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI:";
            // 
            // lblReferencia
            // 
            lblReferencia.AutoSize = true;
            lblReferencia.Location = new Point(16, 162);
            lblReferencia.Margin = new Padding(4, 0, 4, 0);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(82, 20);
            lblReferencia.TabIndex = 3;
            lblReferencia.Text = "Referencia:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(16, 208);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(56, 20);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "Monto:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 18);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(132, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(107, 65);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(132, 27);
            txtApellido.TabIndex = 6;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(107, 111);
            txtDNI.Margin = new Padding(4, 5, 4, 5);
            txtDNI.Name = "txtDNI";
            txtDNI.ReadOnly = true;
            txtDNI.Size = new Size(132, 27);
            txtDNI.TabIndex = 7;
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(107, 157);
            txtReferencia.Margin = new Padding(4, 5, 4, 5);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(132, 27);
            txtReferencia.TabIndex = 8;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(107, 203);
            txtMonto.Margin = new Padding(4, 5, 4, 5);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(132, 27);
            txtMonto.TabIndex = 9;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(107, 249);
            btnCobrar.Margin = new Padding(4, 5, 4, 5);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(100, 35);
            btnCobrar.TabIndex = 10;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // CobrarClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 325);
            Controls.Add(btnCobrar);
            Controls.Add(txtMonto);
            Controls.Add(txtReferencia);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblMonto);
            Controls.Add(lblReferencia);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CobrarClienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cobrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnCobrar;
    }
}
