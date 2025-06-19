namespace ClubDeportivo.Forms
{
    partial class FrmCarnet
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
            lblNumeroSocio = new Label();
            lblNombreYApellido = new Label();
            lblDni = new Label();
            picLogo = new PictureBox();
            txtNumeroSocio = new TextBox();
            txtDni = new TextBox();
            txtNombreApellido = new TextBox();
            txtBuscarDni = new TextBox();
            lblBuscarDni = new Label();
            btnBuscar = new Button();
            btnImprimir = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblNumeroSocio
            // 
            lblNumeroSocio.AutoSize = true;
            lblNumeroSocio.Location = new Point(37, 121);
            lblNumeroSocio.Name = "lblNumeroSocio";
            lblNumeroSocio.Size = new Size(99, 15);
            lblNumeroSocio.TabIndex = 0;
            lblNumeroSocio.Text = "Número de Socio";
            // 
            // lblNombreYApellido
            // 
            lblNombreYApellido.AutoSize = true;
            lblNombreYApellido.Location = new Point(37, 153);
            lblNombreYApellido.Name = "lblNombreYApellido";
            lblNombreYApellido.Size = new Size(107, 15);
            lblNombreYApellido.TabIndex = 1;
            lblNombreYApellido.Text = "Nombre y Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(37, 186);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(36, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "D.N.I.";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.Clubes;
            picLogo.Location = new Point(183, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(152, 65);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.Location = new Point(161, 118);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.ReadOnly = true;
            txtNumeroSocio.Size = new Size(100, 23);
            txtNumeroSocio.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(161, 183);
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 5;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(161, 150);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.ReadOnly = true;
            txtNombreApellido.Size = new Size(100, 23);
            txtNombreApellido.TabIndex = 6;
            // 
            // txtBuscarDni
            // 
            txtBuscarDni.Location = new Point(161, 89);
            txtBuscarDni.Name = "txtBuscarDni";
            txtBuscarDni.Size = new Size(100, 23);
            txtBuscarDni.TabIndex = 7;
            // 
            // lblBuscarDni
            // 
            lblBuscarDni.AutoSize = true;
            lblBuscarDni.Location = new Point(37, 92);
            lblBuscarDni.Name = "lblBuscarDni";
            lblBuscarDni.Size = new Size(84, 15);
            lblBuscarDni.TabIndex = 8;
            lblBuscarDni.Text = "Buscar por Dni";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(317, 83);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 37);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.Location = new Point(314, 132);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(111, 35);
            btnImprimir.TabIndex = 10;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(317, 186);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(96, 32);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 239);
            Controls.Add(btnVolver);
            Controls.Add(btnImprimir);
            Controls.Add(btnBuscar);
            Controls.Add(lblBuscarDni);
            Controls.Add(txtBuscarDni);
            Controls.Add(txtNombreApellido);
            Controls.Add(txtDni);
            Controls.Add(txtNumeroSocio);
            Controls.Add(picLogo);
            Controls.Add(lblDni);
            Controls.Add(lblNombreYApellido);
            Controls.Add(lblNumeroSocio);
            Name = "FrmCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vista del Carnet";
            FormClosing += FrmCarnet_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeroSocio;
        private Label lblNombreYApellido;
        private Label lblDni;
        private PictureBox picLogo;
        private TextBox txtNumeroSocio;
        private TextBox txtDni;
        private TextBox txtNombreApellido;
        private TextBox txtBuscarDni;
        private Label lblBuscarDni;
        private Button btnBuscar;
        private Button btnImprimir;
        private Button btnVolver;
    }
}