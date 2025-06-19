namespace ClubDeportivo.Forms
{
    partial class FrmConfigConexion
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
            lblTitulo = new Label();
            lblServidor = new Label();
            lblBaseDeDatos = new Label();
            lblPuerto = new Label();
            lblUsuario = new Label();
            lblClave = new Label();
            txtServidor = new TextBox();
            txtBaseDatos = new TextBox();
            txtPuerto = new TextBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            chkVerClave = new CheckBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(114, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(358, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Centro de Carga Variables Base de Datos";
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Location = new Point(92, 104);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(50, 15);
            lblServidor.TabIndex = 1;
            lblServidor.Text = "Servidor";
            // 
            // lblBaseDeDatos
            // 
            lblBaseDeDatos.AutoSize = true;
            lblBaseDeDatos.Location = new Point(92, 137);
            lblBaseDeDatos.Name = "lblBaseDeDatos";
            lblBaseDeDatos.Size = new Size(80, 15);
            lblBaseDeDatos.TabIndex = 2;
            lblBaseDeDatos.Text = "Base de Datos";
            // 
            // lblPuerto
            // 
            lblPuerto.AutoSize = true;
            lblPuerto.Location = new Point(92, 171);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(42, 15);
            lblPuerto.TabIndex = 3;
            lblPuerto.Text = "Puerto";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(92, 207);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(92, 237);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 5;
            lblClave.Text = "Clave";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(207, 101);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(154, 23);
            txtServidor.TabIndex = 6;
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Location = new Point(207, 134);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(154, 23);
            txtBaseDatos.TabIndex = 7;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(207, 168);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(154, 23);
            txtPuerto.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(207, 204);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(154, 23);
            txtUsuario.TabIndex = 9;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(207, 234);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(154, 23);
            txtClave.TabIndex = 10;
            txtClave.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(423, 111);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(105, 41);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(417, 190);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 37);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // chkVerClave
            // 
            chkVerClave.AutoSize = true;
            chkVerClave.Location = new Point(387, 237);
            chkVerClave.Name = "chkVerClave";
            chkVerClave.Size = new Size(74, 19);
            chkVerClave.TabIndex = 13;
            chkVerClave.Text = "Ver Clave";
            chkVerClave.UseVisualStyleBackColor = true;
            chkVerClave.CheckedChanged += chkVerClave_CheckedChanged;
            // 
            // FrmConfigConexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 303);
            Controls.Add(chkVerClave);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(txtPuerto);
            Controls.Add(txtBaseDatos);
            Controls.Add(txtServidor);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Controls.Add(lblPuerto);
            Controls.Add(lblBaseDeDatos);
            Controls.Add(lblServidor);
            Controls.Add(lblTitulo);
            Name = "FrmConfigConexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConfigConexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblServidor;
        private Label lblBaseDeDatos;
        private Label lblPuerto;
        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtServidor;
        private TextBox txtBaseDatos;
        private TextBox txtPuerto;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnAceptar;
        private Button btnCancelar;
        private CheckBox chkVerClave;
    }
}