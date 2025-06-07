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
    public partial class FrmPagos : Form
    {
        private string _dni;
        private frmPrincipal _formularioPrincipal;
        
        public FrmPagos(string dni, frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            _dni = dni;
            _formularioPrincipal = formularioPrincipal;
            this.FormClosing += FrmPagos_FormClosing;
            txtDniSocio.Text = _dni;
            BuscarSocioPorDni();

        }
        public FrmPagos(frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            _formularioPrincipal = formularioPrincipal;
        }
        private void FrmPagos_Load(object sender, EventArgs e)
        {
            cmbFormaPago.Items.Clear();
            cmbFormaPago.Items.Add("Efectivo");
            cmbFormaPago.Items.Add("Tarjeta");
            cmbFormaPago.SelectedIndex = 0; // Por defecto Efectivo

            cmbCantidadCuotas.Items.Clear();
            cmbCantidadCuotas.Items.Add("1"); // Por defecto
            cmbCantidadCuotas.SelectedIndex = 0;
            cmbCantidadCuotas.Enabled = false; // Solo se habilita si elige tarjeta
        }
        private void txtDniSocio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarSocioPorDni();
                e.Handled = true;
                e.SuppressKeyPress = true; // evita el sonido de "ding"
            }
        }
        private int idSocioSeleccionado = -1;

        private void BuscarSocioPorDni()
        {
            string dni = txtDniSocio.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese un DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Datos.Postulantes datosSocio = new Datos.Postulantes();
                DataTable dt = datosSocio.BuscarSocioPorDni(dni);

                if (dt.Rows.Count > 0)
                {
                    idSocioSeleccionado = Convert.ToInt32(dt.Rows[0]["idSocio"]);
                    string nombre = dt.Rows[0]["nombre"].ToString();
                    string apellido = dt.Rows[0]["apellido"].ToString();
                    txtLeyendaSocio.Text = $"{nombre} {apellido}";
                    txtImporte.Text = dt.Rows[0]["precioCuota"].ToString();

                }
                else
                {
                    MessageBox.Show("No se encontró un socio con ese DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLeyendaSocio.Clear();
                    idSocioSeleccionado = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarPagosDelSocio(idSocioSeleccionado);
        }

        private void MostrarPagosDelSocio(int idSocio)
        {
            try
            {
                Datos.Pagos pagos = new Datos.Pagos();
                DataTable dtPagos = pagos.ObtenerPagosPorSocio(idSocio);
                dgvPagosRealizados.DataSource = dtPagos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPago.SelectedItem.ToString() == "Tarjeta")
            {
                cmbCantidadCuotas.Items.Clear();
                cmbCantidadCuotas.Items.Add("1");
                cmbCantidadCuotas.Items.Add("3");
                cmbCantidadCuotas.Items.Add("6");
                cmbCantidadCuotas.SelectedIndex = 0;
                cmbCantidadCuotas.Enabled = true;
            }
            else
            {
                cmbCantidadCuotas.Items.Clear();
                cmbCantidadCuotas.Items.Add("1");
                cmbCantidadCuotas.SelectedIndex = 0;
                cmbCantidadCuotas.Enabled = false;
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (idSocioSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un socio válido.");
                return;
            }

            // Validar que el importe sea un número válido
            if (!double.TryParse(txtImporte.Text, out double monto))
            {
                MessageBox.Show("El importe ingresado no es válido.");
                return;
            }

            string tipoPago = cmbFormaPago.SelectedItem.ToString();
            int cantidadCuotas = int.Parse(cmbCantidadCuotas.SelectedItem.ToString());
            DateTime fechaPago = dtpFechaPago.Value;
            DateTime fechaVenc = dtpFechaVencimiento.Value;

            Datos.Pagos pagos = new Datos.Pagos();
            string respuesta = pagos.RegistrarPagoSocio(idSocioSeleccionado, fechaPago, fechaVenc, tipoPago, cantidadCuotas, monto);

            if (respuesta == "OK")

            {
                MostrarPagosDelSocio(idSocioSeleccionado);

                MessageBox.Show("Pago registrado correctamente.");
                LimpiarFormulario();
            }

            else
            {
                MessageBox.Show("Error al registrar el pago: " + respuesta);
            }
        }

        private void LimpiarFormulario()
        {
            txtDniSocio.Clear();
            txtLeyendaSocio.Clear();
            cmbFormaPago.SelectedIndex = 0;
            cmbCantidadCuotas.SelectedIndex = 0;
            txtImporte.Clear();
            idSocioSeleccionado = 0;
            dgvPagosRealizados.DataSource = null; // Limpiar el DataGridView
        }

        private void btnImprimirPagos_Click(object sender, EventArgs e)
        {
            if (dgvPagosRealizados.Rows.Count == 0)
            {
                MessageBox.Show("No hay pagos para imprimir.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Archivo PDF|*.pdf",
                FileName = "PagosSocio.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nombreSocio = txtLeyendaSocio.Text;
                    ImpresionPagos.GenerarPDF(dgvPagosRealizados, nombreSocio, sfd.FileName);
                    MessageBox.Show("PDF generado correctamente.");
                    System.Diagnostics.Process.Start("explorer.exe", sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar PDF: " + ex.Message);
                }
            }
        }
        


        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.Show();
            this.Close();
        }
        private void FrmPagos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _formularioPrincipal.Show();
        }
    }
}
