namespace DSOO_Integrador_Grupo14_ComA
{
    partial class BuscarClientePagarForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnBuscar;

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
            lblDNI = new Label();
            txtDNI = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(16, 23);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(38, 20);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(63, 18);
            txtDNI.Margin = new Padding(4, 5, 4, 5);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(265, 27);
            txtDNI.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(63, 77);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 35);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // BuscarClientePagarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 140);
            Controls.Add(btnBuscar);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BuscarClientePagarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Cliente para Pagar";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
