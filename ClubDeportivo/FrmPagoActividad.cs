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
    public partial class FrmPagoActividad : Form
    {
        private frmPrincipal _formularioPrincipal;
        private int idNoSocioSeleccionado = -1;

        public FrmPagoActividad(frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            _formularioPrincipal = formularioPrincipal;
            this.Load += FrmPagoActividad_Load;
            rdbEfectivo.Checked = true; // Valor predeterminado
        }
        private void FrmPagoActividad_Load(object sender, EventArgs e)
        {
            // Aquí podés cargar el ComboBox de actividades por ejemplo
            CargarActividades();
        }


        private void CargarActividades()
        {
            ActividadesGestion actividades = new ActividadesGestion();
            cboActividad.DataSource = actividades.ObtenerActividades();
            cboActividad.DisplayMember = "nombre";
            cboActividad.ValueMember = "idActividad";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                return;
            }

            PagosActividad pagos = new PagosActividad();
            DataRow noSocio = pagos.ObtenerNoSocioPorDni(dni);

            if (noSocio != null)
            {
                idNoSocioSeleccionado = Convert.ToInt32(noSocio["idNoSocio"]);
                lblNombre.Text = noSocio["Apellido"] + ", " + noSocio["Nombre"];
            }
            else
            {
                MessageBox.Show("No se encontró un no socio con ese DNI.");
                idNoSocioSeleccionado = -1;
                lblNombre.Text = "";
            }
        }

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboActividad.SelectedValue != null)
            {
                int idActividad = Convert.ToInt32(cboActividad.SelectedValue);
                ActividadesGestion actividades = new ActividadesGestion();
                double monto = actividades.ObtenerMontoActividad(idActividad);
                txtMonto.Text = monto.ToString("0.00");

                if (monto <= 0)
                {
                    MessageBox.Show("No se encontró un monto válido para esta actividad.");
                }

                txtMonto.Text = monto.ToString("0.00");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (idNoSocioSeleccionado == -1)
            {
                MessageBox.Show("Debe buscar un no socio válido.");
                return;
            }

            if (cboActividad.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una actividad.");
                return;
            }

            int idActividad = Convert.ToInt32(cboActividad.SelectedValue);
            string tipoPago = rdbEfectivo.Checked ? "Efectivo" : "Tarjeta";
            double monto;

            if (!double.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("Monto inválido.");
                return;
            }

            DateTime fechaPago = dtpFecha.Value;

            PagosActividad pagos = new PagosActividad();
            string resultado = pagos.RegistrarPagoActividad(idNoSocioSeleccionado, idActividad, fechaPago, tipoPago, monto);

            if (resultado == "OK")
            {
                MessageBox.Show("Pago registrado correctamente.");
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Error al registrar el pago: " + resultado);
            }
        }

        private void LimpiarFormulario()
        {
            txtDni.Clear();
            lblNombre.Text = "";
            txtMonto.Clear();
            cboActividad.SelectedIndex = 0;
            rdbEfectivo.Checked = true;
            dtpFecha.Value = DateTime.Today;
            idNoSocioSeleccionado = -1;
        }
    }
}
