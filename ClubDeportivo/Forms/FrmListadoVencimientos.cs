using ClubDeportivo.Datos;
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
            if (dgvListado.Columns.Contains("idSocio"))
                dgvListado.Columns["idSocio"].HeaderText = "Socio N° ";
            if (dgvListado.Columns.Contains("nombre"))
                dgvListado.Columns["nombre"].HeaderText = "Nombre ";
            if (dgvListado.Columns.Contains("apellido"))
                dgvListado.Columns["apellido"].HeaderText = "Apellido ";
            if (dgvListado.Columns.Contains("fechaVencimiento"))
                dgvListado.Columns["fechaVencimiento"].HeaderText = "Fecha Vencimiento";
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir.");
                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = false; // Vertical

            pd.PrintPage += (s, ev) =>
            {
                float x = ev.MarginBounds.Left;
                float y = ev.MarginBounds.Top;
                Font fontHeader = new Font("Arial", 11, FontStyle.Bold);
                Font fontCell = new Font("Arial", 10);
                float rowHeight = 28;
                int colCount = dgvListado.Columns.Count;

                // Calcular ancho de columna proporcional
                float totalWidth = ev.MarginBounds.Width;
                float[] colWidths = new float[colCount];
                for (int i = 0; i < colCount; i++)
                    colWidths[i] = totalWidth / colCount;

                // Título centrado
                string titulo = "Listado de Vencimientos";
                SizeF tituloSize = ev.Graphics.MeasureString(titulo, fontHeader);
                ev.Graphics.DrawString(titulo, fontHeader, Brushes.Black,
                    ev.MarginBounds.Left + (ev.MarginBounds.Width - tituloSize.Width) / 2, y);
                y += tituloSize.Height + 15;

                // Encabezados de columna con fondo gris y borde
                float colX = x;
                for (int i = 0; i < colCount; i++)
                {
                    ev.Graphics.FillRectangle(Brushes.LightGray, colX, y, colWidths[i], rowHeight);
                    ev.Graphics.DrawRectangle(Pens.Black, colX, y, colWidths[i], rowHeight);
                    ev.Graphics.DrawString(dgvListado.Columns[i].HeaderText, fontHeader, Brushes.Black, colX + 4, y + 5);
                    colX += colWidths[i];
                }
                y += rowHeight;

                // Filas de datos
                for (int i = 0; i < dgvListado.Rows.Count; i++)
                {
                    if (dgvListado.Rows[i].IsNewRow) continue;
                    colX = x;
                    for (int j = 0; j < colCount; j++)
                    {
                        ev.Graphics.DrawRectangle(Pens.Black, colX, y, colWidths[j], rowHeight);
                        string text = dgvListado.Rows[i].Cells[j].Value?.ToString() ?? "";
                        ev.Graphics.DrawString(text, fontCell, Brushes.Black, colX + 4, y + 5);
                        colX += colWidths[j];
                    }
                    y += rowHeight;

                    // Salto de página si se excede el margen inferior
                    if (y + rowHeight > ev.MarginBounds.Bottom)
                    {
                        ev.HasMorePages = true;
                        return;
                    }
                }

                ev.HasMorePages = false;
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
}
