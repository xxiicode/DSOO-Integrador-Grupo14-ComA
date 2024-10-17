namespace DSOO_Integrador_Grupo14_ComA
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnLogout = new Button();
            btnAgregarCliente = new Button();
            btnVerClientes = new Button();
            btnCobrarCliente = new Button();
            btnMostrarClientes = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(200, 31);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(217, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Pantalla Principal";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(200, 400);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 46);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(200, 164);
            btnAgregarCliente.Margin = new Padding(4, 5, 4, 5);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(200, 46);
            btnAgregarCliente.TabIndex = 3;
            btnAgregarCliente.Text = "Registrar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnVerClientes
            // 
            btnVerClientes.Location = new Point(200, 114);
            btnVerClientes.Margin = new Padding(4, 5, 4, 5);
            btnVerClientes.Name = "btnVerClientes";
            btnVerClientes.Size = new Size(200, 46);
            btnVerClientes.TabIndex = 2;
            btnVerClientes.Text = "Ver Clientes";
            btnVerClientes.UseVisualStyleBackColor = true;
            btnVerClientes.Click += btnVerClientes_Click;
            // 
            // btnCobrarCliente
            // 
            btnCobrarCliente.Location = new Point(200, 214);
            btnCobrarCliente.Margin = new Padding(4, 5, 4, 5);
            btnCobrarCliente.Name = "btnCobrarCliente";
            btnCobrarCliente.Size = new Size(200, 46);
            btnCobrarCliente.TabIndex = 4;
            btnCobrarCliente.Text = "Cobrar Cliente";
            btnCobrarCliente.UseVisualStyleBackColor = true;
            btnCobrarCliente.Click += btnCobrarCliente_Click;
            // 
            // btnMostrarClientes
            // 
            btnMostrarClientes.Location = new Point(200, 264);
            btnMostrarClientes.Margin = new Padding(4, 5, 4, 5);
            btnMostrarClientes.Name = "btnMostrarClientes";
            btnMostrarClientes.Size = new Size(200, 46);
            btnMostrarClientes.TabIndex = 5;
            btnMostrarClientes.Text = "Clientes que vencen hoy";
            btnMostrarClientes.UseVisualStyleBackColor = true;
            btnMostrarClientes.Click += btnMostrarClientes_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 492);
            Controls.Add(btnMostrarClientes);
            Controls.Add(btnCobrarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(btnVerClientes);
            Controls.Add(btnLogout);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla Principal";
            Load += Principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Button btnCobrarCliente;
        private System.Windows.Forms.Button btnMostrarClientes;
    }
}