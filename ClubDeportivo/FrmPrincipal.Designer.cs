namespace ClubDeportivo
{
    partial class frmPrincipal
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
            btnInscripcion = new Button();
            btnCobrarActividad = new Button();
            btnGenerarCarnet = new Button();
            btnCobraCuota = new Button();
            btnGestionValores = new Button();
            button5 = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.Menu;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(65, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(413, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema Club Deportivo";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnInscripcion
            // 
            btnInscripcion.BackColor = SystemColors.Info;
            btnInscripcion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInscripcion.Location = new Point(65, 125);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(153, 60);
            btnInscripcion.TabIndex = 1;
            btnInscripcion.Text = "INSCRIBIR";
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // btnCobrarActividad
            // 
            btnCobrarActividad.BackColor = SystemColors.Info;
            btnCobrarActividad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCobrarActividad.Location = new Point(65, 228);
            btnCobrarActividad.Name = "btnCobrarActividad";
            btnCobrarActividad.Size = new Size(153, 60);
            btnCobrarActividad.TabIndex = 2;
            btnCobrarActividad.Text = "COBRAR ACTIVIDAD";
            btnCobrarActividad.UseVisualStyleBackColor = false;
            btnCobrarActividad.Click += btnCobrarActividad_Click;
            // 
            // btnGenerarCarnet
            // 
            btnGenerarCarnet.BackColor = SystemColors.Info;
            btnGenerarCarnet.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarCarnet.Location = new Point(65, 335);
            btnGenerarCarnet.Name = "btnGenerarCarnet";
            btnGenerarCarnet.Size = new Size(153, 60);
            btnGenerarCarnet.TabIndex = 3;
            btnGenerarCarnet.Text = "GENERAR CARNET";
            btnGenerarCarnet.UseVisualStyleBackColor = false;
            // 
            // btnCobraCuota
            // 
            btnCobraCuota.BackColor = SystemColors.Info;
            btnCobraCuota.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCobraCuota.Location = new Point(301, 125);
            btnCobraCuota.Name = "btnCobraCuota";
            btnCobraCuota.Size = new Size(153, 60);
            btnCobraCuota.TabIndex = 4;
            btnCobraCuota.Text = "COBRAR CUOTA";
            btnCobraCuota.UseVisualStyleBackColor = false;
            btnCobraCuota.Click += btnCobraCuota_Click;
            // 
            // btnGestionValores
            // 
            btnGestionValores.BackColor = SystemColors.Info;
            btnGestionValores.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionValores.Location = new Point(301, 228);
            btnGestionValores.Name = "btnGestionValores";
            btnGestionValores.Size = new Size(153, 60);
            btnGestionValores.TabIndex = 5;
            btnGestionValores.Text = "GESTIÓN";
            btnGestionValores.UseVisualStyleBackColor = false;
            btnGestionValores.Click += btnGestionValores_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Info;
            button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(301, 335);
            button5.Name = "button5";
            button5.Size = new Size(153, 60);
            button5.TabIndex = 6;
            button5.Text = "LISTAR VENCIMIENTOS";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.GradientActiveCaption;
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(209, 419);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 39);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 507);
            Controls.Add(btnSalir);
            Controls.Add(button5);
            Controls.Add(btnGestionValores);
            Controls.Add(btnCobraCuota);
            Controls.Add(btnGenerarCarnet);
            Controls.Add(btnCobrarActividad);
            Controls.Add(btnInscripcion);
            Controls.Add(lblTitulo);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO MENÚ PRINCIPAL";
            FormClosing += frmPrincipal_FormClosing;
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Button btnInscripcion;
        private Button btnCobrarActividad;
        private Button btnGenerarCarnet;
        private Button btnCobraCuota;
        private Button btnGestionValores;
        private Button button5;
        private Button btnSalir;
    }
}