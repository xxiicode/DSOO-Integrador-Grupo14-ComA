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
        private System.Windows.Forms.Button btnGuardar;

        private void InitializeComponent()
        {
            this.lblPuerto = new Label();
            this.txtPuerto = new TextBox();
            this.lblUsuario = new Label();
            this.txtUsuario = new TextBox();
            this.lblClave = new Label();
            this.txtClave = new TextBox();
            this.btnGuardar = new Button();

            // lblPuerto
            this.lblPuerto.Text = "Puerto:";
            this.lblPuerto.Location = new Point(30, 30);
            this.lblPuerto.Size = new Size(100, 20);

            // txtPuerto
            this.txtPuerto.Location = new Point(150, 30);
            this.txtPuerto.Size = new Size(200, 25);

            // lblUsuario
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Location = new Point(30, 70);
            this.lblUsuario.Size = new Size(100, 20);

            // txtUsuario
            this.txtUsuario.Location = new Point(150, 70);
            this.txtUsuario.Size = new Size(200, 25);

            // lblClave
            this.lblClave.Text = "Clave:";
            this.lblClave.Location = new Point(30, 110);
            this.lblClave.Size = new Size(100, 20);

            // txtClave
            this.txtClave.Location = new Point(150, 110);
            this.txtClave.Size = new Size(200, 25);
            this.txtClave.PasswordChar = '*';

            // btnGuardar
            this.btnGuardar.Text = "Guardar y Continuar";
            this.btnGuardar.Location = new Point(100, 160);
            this.btnGuardar.Size = new Size(200, 30);
            this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);

            // Formulario DatosBD
            this.ClientSize = new Size(400, 220);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnGuardar);
            this.Text = "Configuración de la Base de Datos";
            this.StartPosition = FormStartPosition.CenterScreen;
        }


    }
}