namespace DSOO_Integrador_Grupo14_ComA
{
    partial class DatosBD
    {

        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblValoresPorDefecto;
        private System.Windows.Forms.Button btnGuardar;



        private void InitializeComponent()
        {
            lblPuerto = new Label();
            txtPuerto = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblClave = new Label();
            txtClave = new TextBox();
            lblValoresPorDefecto = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblPuerto
            // 
            lblPuerto.Location = new Point(30, 30);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(100, 20);
            lblPuerto.TabIndex = 0;
            lblPuerto.Text = "Puerto:";
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(150, 30);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(200, 27);
            txtPuerto.TabIndex = 1;
            txtPuerto.Text = "3306";
            // 
            // lblUsuario
            // 
            lblUsuario.Location = new Point(30, 70);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(100, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(150, 70);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "root";
            // 
            // lblClave
            // 
            lblClave.Location = new Point(30, 110);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(100, 20);
            lblClave.TabIndex = 4;
            lblClave.Text = "Clave:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(150, 110);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(200, 27);
            txtClave.TabIndex = 5;
            // 
            // lblValoresPorDefecto
            // 
            lblValoresPorDefecto.AutoSize = true;
            lblValoresPorDefecto.ForeColor = SystemColors.ActiveBorder;
            lblValoresPorDefecto.Location = new Point(24, 148);
            lblValoresPorDefecto.Margin = new Padding(4, 0, 4, 0);
            lblValoresPorDefecto.Name = "lblValoresPorDefecto";
            lblValoresPorDefecto.Size = new Size(341, 20);
            lblValoresPorDefecto.TabIndex = 19;
            lblValoresPorDefecto.Text = "Estas viendo los valores por defecto phpMyAdmin";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(100, 200);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(200, 30);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar y Continuar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // DatosBD
            // 
            ClientSize = new Size(400, 260);
            Controls.Add(lblPuerto);
            Controls.Add(txtPuerto);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblClave);
            Controls.Add(txtClave);
            Controls.Add(lblValoresPorDefecto);
            Controls.Add(btnGuardar);
            Name = "DatosBD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuración de la Base de Datos";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}