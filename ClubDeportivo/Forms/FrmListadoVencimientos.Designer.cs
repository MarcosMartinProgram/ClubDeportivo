namespace ClubDeportivo.Forms
{
    partial class FrmListadoVencimientos
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
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            btnBuscar = new Button();
            dgvListado = new DataGridView();
            lblTitulo = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(201, 70);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(58, 76);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(118, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Seleccione una fecha";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(249, 114);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 39);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvListado
            // 
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(22, 178);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(492, 150);
            dgvListado.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(149, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(288, 25);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "LISTAR VENCIMIENTOS CUOTAS";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(383, 114);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(105, 39);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmListadoVencimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 358);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Controls.Add(dgvListado);
            Controls.Add(btnBuscar);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Name = "FrmListadoVencimientos";
            Text = "FrmListadoVencimientos";
            FormClosing += FrmListadoVencimientos_FormClosing;
            Load += FrmListadoVencimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Button btnBuscar;
        private DataGridView dgvListado;
        private Label lblTitulo;
        private Button btnVolver;
    }
}