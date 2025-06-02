using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            FrmInscripcion inscripcion = new FrmInscripcion(this);
            inscripcion.Show();
            this.Hide(); // Regresa al formulario principal después de cerrar el de inscripción
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Cierra la aplicación al cerrar el formulario principal
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCobraCuota_Click(object sender, EventArgs e)
        {
            FrmPagos pagos = new FrmPagos(this);
            this.Hide(); // opcional: oculta el principal mientras estás en el secundario
            pagos.Show();
        }

        private void btnCobrarActividad_Click(object sender, EventArgs e)
        {
            FrmPagoActividad pagoActividad = new FrmPagoActividad(this);
            this.Hide(); // opcional: oculta el principal mientras estás en el secundario
            pagoActividad.Show();
        }
    }
}
