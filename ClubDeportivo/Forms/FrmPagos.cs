using ClubDeportivo.Datos;
using ClubDeportivo.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        private bool _mostrarPrincipalAlCerrar = true;

        private bool _mostrarCarnetAlFinalizar = false;

        private string _nombreSocio = "";
        private string _apellidoSocio = "";
        private string _dniSocio = "";

        public FrmPagos(string dni, frmPrincipal formularioPrincipal, bool mostrarCarnetAlFinalizar = false)
        {
            InitializeComponent();
            _dni = dni;
            _formularioPrincipal = formularioPrincipal;
            _mostrarCarnetAlFinalizar = mostrarCarnetAlFinalizar;
            
            this.FormClosing += FrmPagos_FormClosing;
            this.dtpFechaPago.ValueChanged += dtpFechaPago_ValueChanged;
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

            dtpFechaVencimiento.Value = dtpFechaPago.Value.AddDays(30);

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
                    _nombreSocio = dt.Rows[0]["nombre"].ToString();
                    _apellidoSocio = dt.Rows[0]["apellido"].ToString();
                    _dniSocio = dt.Rows[0]["dni"].ToString();
                    txtLeyendaSocio.Text = $"{_nombreSocio} {_apellidoSocio}";
                    txtDniSocio.Text = _dniSocio;

                    double valorCuota = CuotasDAO.ObtenerUltimoMontoCuota();
                    txtImporte.Text = valorCuota.ToString("0.00");

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

                // Preguntar si desea imprimir el ticket
                var result = MessageBox.Show("¿Desea imprimir el ticket de pago?", "Imprimir Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ImprimirTicketPago(_nombreSocio, _apellidoSocio, _dniSocio, monto, tipoPago, cantidadCuotas, fechaPago, fechaVenc);
                }

                if (_mostrarCarnetAlFinalizar)
                {
                    _mostrarPrincipalAlCerrar = false;
                    FrmCarnet carnet = new FrmCarnet(_dni, _formularioPrincipal);
                    carnet.Show();
                    this.Close();
                }
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

            DialogResult result = MessageBox.Show(
                "¿Qué desea hacer?\nSí: Generar PDF\nNo: Imprimir\nCancelar: Salir",
                "Generar PDF o Imprimir",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes) // PDF
            {
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
                        MessageBox.Show("Error al generar PDF:\n" + ex.Message);
                    }
                }
            }
            else if (result == DialogResult.No) // Imprimir
            {
                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.Landscape = false;
                pd.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50); // márgenes de 5cm

                pd.PrintPage += (s, ev) =>
                {
                    try
                    {
                        Font fontHeader = new Font("Arial", 12, FontStyle.Bold);
                        Font fontCell = new Font("Arial", 10);
                        float y = ev.MarginBounds.Top;
                        float x = ev.MarginBounds.Left;

                        // Título centrado
                        string titulo = "Pagos del socio: " + txtLeyendaSocio.Text;
                        SizeF tituloSize = ev.Graphics.MeasureString(titulo, fontHeader);
                        ev.Graphics.DrawString(titulo, fontHeader, Brushes.Black,
                            ev.MarginBounds.Left + (ev.MarginBounds.Width - tituloSize.Width) / 2, y);
                        y += tituloSize.Height + 20;

                        // Cálculo de ancho de columna (autoajuste)
                        int colCount = dgvPagosRealizados.Columns.Count;
                        float[] colWidths = new float[colCount];
                        float totalWidth = ev.MarginBounds.Width;
                        for (int i = 0; i < colCount; i++)
                            colWidths[i] = totalWidth / colCount;

                        // Encabezados
                        for (int i = 0; i < colCount; i++)
                        {
                            ev.Graphics.FillRectangle(Brushes.LightGray, x, y, colWidths[i], 25);
                            ev.Graphics.DrawRectangle(Pens.Black, x, y, colWidths[i], 25);
                            ev.Graphics.DrawString(dgvPagosRealizados.Columns[i].HeaderText, fontHeader, Brushes.Black, x + 2, y + 4);
                            x += colWidths[i];
                        }

                        y += 25;
                        x = ev.MarginBounds.Left;

                        // Filas
                        for (int i = 0; i < dgvPagosRealizados.Rows.Count; i++)
                        {
                            if (y + 25 > ev.MarginBounds.Bottom)
                            {
                                ev.HasMorePages = true;
                                return;
                            }

                            for (int j = 0; j < colCount; j++)
                            {
                                string text = dgvPagosRealizados.Rows[i].Cells[j].Value?.ToString() ?? "";
                                ev.Graphics.DrawRectangle(Pens.Black, x, y, colWidths[j], 25);
                                ev.Graphics.DrawString(text, fontCell, Brushes.Black, x + 2, y + 4);
                                x += colWidths[j];
                            }

                            x = ev.MarginBounds.Left;
                            y += 25;
                        }

                        ev.HasMorePages = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al imprimir:\n" + ex.Message);
                    }
                };

                using (PrintDialog printDialog = new PrintDialog { Document = pd })
                {
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            pd.Print();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudo imprimir:\n" + ex.Message);
                        }
                    }
                }
            }
        }

        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Value = dtpFechaPago.Value.AddDays(30);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _mostrarPrincipalAlCerrar = false;
            _formularioPrincipal.Show();
            this.Close();
        }
        private void FrmPagos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_mostrarPrincipalAlCerrar)
            {
                _formularioPrincipal.Show();
            }
        }

        private void ImprimirTicketPago(string nombre, string apellido, string dni, double monto, string tipoPago, int cantidadCuotas, DateTime fechaPago, DateTime fechaVenc)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                float x = 10, y = 10;
                Font fontTitulo = new Font("Consolas", 12, FontStyle.Bold);
                Font fontDatos = new Font("Consolas", 10);

                ev.Graphics.DrawString("Club Deportivo", fontTitulo, Brushes.Black, x, y);
                y += 30;
                ev.Graphics.DrawString("----- Ticket de Pago -----", fontDatos, Brushes.Black, x, y);
                y += 25;
                ev.Graphics.DrawString($"Nombre: {nombre} {apellido}", fontDatos, Brushes.Black, x, y);
                y += 20;
                ev.Graphics.DrawString($"DNI: {dni}", fontDatos, Brushes.Black, x, y);
                y += 20;
                ev.Graphics.DrawString($"Fecha de Pago: {fechaPago:dd/MM/yyyy}", fontDatos, Brushes.Black, x, y);
                y += 20;
                ev.Graphics.DrawString($"Vencimiento: {fechaVenc:dd/MM/yyyy}", fontDatos, Brushes.Black, x, y);
                y += 20;
                ev.Graphics.DrawString($"Importe: ${monto:0.00}", fontDatos, Brushes.Black, x, y);
                y += 20;
                ev.Graphics.DrawString($"Forma de Pago: {tipoPago}", fontDatos, Brushes.Black, x, y);
                y += 20;
                ev.Graphics.DrawString($"Cuotas: {cantidadCuotas}", fontDatos, Brushes.Black, x, y);
                y += 30;
                ev.Graphics.DrawString("¡Gracias por su pago!", fontDatos, Brushes.Black, x, y);
            };

            using (PrintDialog printDialog = new PrintDialog { Document = pd })
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pd.Print();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo imprimir el ticket:\n" + ex.Message);
                    }
                }
            }
        }
    }
}
