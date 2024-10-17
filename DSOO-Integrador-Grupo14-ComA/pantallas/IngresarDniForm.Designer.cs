namespace DSOO_Integrador_Grupo14_ComA
{
    partial class IngresarDniForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnAceptar;

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
            btnAceptar = new Button();
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
            // btnAceptar
            // 
            btnAceptar.Location = new Point(63, 77);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 35);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // IngresarDniForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 140);
            Controls.Add(btnAceptar);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Margin = new Padding(4, 5, 4, 5);
            Name = "IngresarDniForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar DNI";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}