using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Forms
{
    public partial class FrmListadoVencimientos : Form
    {
        private frmPrincipal _formularioPrincipal;
        public FrmListadoVencimientos(frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            _formularioPrincipal = formularioPrincipal;
        }

        private void FrmListadoVencimientos_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today;
            CargarListado();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void CargarListado()
        {
            DateTime fecha = dtpFecha.Value.Date;
            Pagos pagos = new Pagos();
            DataTable dt = pagos.ObtenerSociosCuotaVenceEn(fecha);
            dgvListado.DataSource = dt;
        }
        private void FrmListadoVencimientos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _formularioPrincipal.Show();
            _formularioPrincipal.Activate();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.Show();
            this.Close();
        }
    }
}
