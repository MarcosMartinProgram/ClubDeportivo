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

namespace ClubDeportivo
{
    public partial class FrmGestionValores : Form
    {
        private frmPrincipal _formularioPrincipal;

        public FrmGestionValores(frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            _formularioPrincipal = formularioPrincipal;
            CargarActividades();

            txtMontoActividad.Enter += txtMontoActividad_Enter;
            txtMontoActividad.Leave += txtMontoActividad_Leave;
            txtMontoCuota.Enter += txtMontoCuota_Enter;
            txtMontoCuota.Leave += txtMontoCuota_Leave;
        }

        private void FrmGestionValores_Load(object sender, EventArgs e)
        {
            txtMontoActividad.Text = "Ingrese el Valor";
            txtMontoActividad.ForeColor = Color.Black;
            txtMontoCuota.Text = "Ingrese el Valor";
            txtMontoCuota.ForeColor = Color.Black;
        }

        private void CargarActividades()
        {
            ActividadesGestion actividades = new ActividadesGestion();
            cboActividad.DataSource = actividades.ObtenerActividades();
            cboActividad.DisplayMember = "nombre";
            cboActividad.ValueMember = "idActividad";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreActividad.Text.Trim();
            string dias = string.Join(", ", clbDias.CheckedItems.Cast<string>());
            string horarios = txtHorarios.Text.Trim();
            int cupo = (int)nudCupo.Value;

            ActividadesGestion actividades = new ActividadesGestion();
            string resultado = actividades.InsertarActividad(nombre, dias, horarios, cupo);

            if (resultado == "OK")
            {
                MessageBox.Show("Actividad registrada correctamente.");
                CargarActividades();
                LimpiarCamposActividad();
            }
            else
            {
                MessageBox.Show("Error: " + resultado);
            }
        }

        private void LimpiarCamposActividad()
        {
            txtNombreActividad.Clear();
            clbDias.ClearSelected();
            txtHorarios.Clear();
            nudCupo.Value = 0;
        }

        private void btnGuardarValorActividad_Click(object sender, EventArgs e)
        {
            int idActividad = Convert.ToInt32(cboActividad.SelectedValue);
            double monto = double.Parse(txtMontoActividad.Text);
            DateTime fechaDesde = dtpValorActividad.Value.AddDays(1);

            Valores valores = new Valores();
            string resultado = valores.InsertarValorActividad(idActividad, monto, fechaDesde);

            if (resultado == "OK")
            {
                MessageBox.Show("Valor de actividad registrado.");
                LimpiarCamposValorActividad();
            }
            else
            {
                MessageBox.Show("Error: " + resultado);
            }
        }

        private void LimpiarCamposValorActividad()
        {
            cboActividad.SelectedIndex = -1;
            txtMontoActividad.Clear();
            dtpValorActividad.Value = DateTime.Now;
        }

        private void btnGuardarValorCuota_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMontoCuota.Text);
            DateTime fechaDesde = dtpValorCuota.Value.AddDays(1);

            Valores valores = new Valores();
            string resultado = valores.InsertarValorCuota(monto, fechaDesde);

            if (resultado == "OK")
            {
                MessageBox.Show("Valor de cuota registrado.");
                LimpiarCamposValorCuota();
            }
            else
            {
                MessageBox.Show("Error: " + resultado);
            }
        }

        private void LimpiarCamposValorCuota()
        {
            txtMontoCuota.Clear();
            dtpValorCuota.Value = DateTime.Now;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.Show();
            this.Close();
        }

        private void FrmGestionValores_FormClosing(object sender, FormClosingEventArgs e)
        {
            _formularioPrincipal.Show();
        }

        private void txtMontoActividad_Enter(object sender, EventArgs e)
        {
            if (txtMontoActividad.Text == "Ingrese el Valor")
            {
                txtMontoActividad.Text = "";
                txtMontoActividad.ForeColor = Color.Black;
            }
        }

        private void txtMontoActividad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMontoActividad.Text))
            {
                txtMontoActividad.Text = "Ingrese el Valor";
                txtMontoActividad.ForeColor = Color.Silver;
            }
        }

        private void txtMontoCuota_Enter(object sender, EventArgs e)
        {
            if (txtMontoCuota.Text == "Ingrese el Valor")
            {
                txtMontoCuota.Text = "";
                txtMontoCuota.ForeColor = Color.Black;
            }
        }

        private void txtMontoCuota_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMontoCuota.Text))
            {
                txtMontoCuota.Text = "Ingrese el valor";
                txtMontoCuota.ForeColor = Color.Silver;
            }
        }
    }
} 
