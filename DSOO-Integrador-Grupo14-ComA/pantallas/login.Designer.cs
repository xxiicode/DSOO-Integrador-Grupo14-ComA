using System.Windows.Forms;

namespace DSOO_Integrador_Grupo14_ComA
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblClave = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(50, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(142, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre de Usuario:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(50, 100);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(48, 20);
            lblClave.TabIndex = 2;
            lblClave.Text = "Clave:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(200, 47);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(200, 97);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(200, 27);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(200, 150);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 30);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 250);
            Controls.Add(btnAceptar);
            Controls.Add(txtPass);
            Controls.Add(lblClave);
            Controls.Add(txtUsuario);
            Controls.Add(lblNombre);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnAceptar;
    }
}
