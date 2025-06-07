namespace ClubDeportivo
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btnIngresar = new Button();
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            pbImagen = new PictureBox();
            chkVerPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(385, 208);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(256, 54);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "USUARIO";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(256, 147);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(84, 15);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(360, 51);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(190, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(360, 139);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(190, 23);
            txtContraseña.TabIndex = 4;
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // pbImagen
            // 
            pbImagen.Image = (Image)resources.GetObject("pbImagen.Image");
            pbImagen.Location = new Point(35, 54);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(177, 150);
            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImagen.TabIndex = 5;
            pbImagen.TabStop = false;
            // 
            // chkVerPassword
            // 
            chkVerPassword.AutoSize = true;
            chkVerPassword.Location = new Point(258, 105);
            chkVerPassword.Name = "chkVerPassword";
            chkVerPassword.Size = new Size(130, 19);
            chkVerPassword.TabIndex = 6;
            chkVerPassword.Text = "Mostrar Contraseña";
            chkVerPassword.UseVisualStyleBackColor = true;
            chkVerPassword.CheckedChanged += chkVerPassword_CheckedChanged;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 290);
            Controls.Add(chkVerPassword);
            Controls.Add(pbImagen);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(btnIngresar);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO INGRESO";
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private PictureBox pbImagen;
        private CheckBox chkVerPassword;
    }
}
