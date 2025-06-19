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
    public partial class FrmCarnet : Form
    {
        private string _dni;
        private frmPrincipal _formularioPrincipal;
        private int _idSocio = -1;
        private bool _modoBusqueda = false;

        public FrmCarnet(string dni, frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            _dni = dni;
            _formularioPrincipal = formularioPrincipal;
            _modoBusqueda = false;
            this.Load += FrmCarnet_Load;
        }

        // Constructor para modo búsqueda desde principal
        public FrmCarnet(frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            _formularioPrincipal = formularioPrincipal;
            _modoBusqueda = true;
            this.Load += FrmCarnet_Load;
        }

        private void FrmCarnet_Load(object sender, EventArgs e)
        {
            if (_modoBusqueda)
            {
                txtBuscarDni.Visible = true;
                btnBuscar.Visible = true;
            }
            else
            {
                txtBuscarDni.Visible = false;
                btnBuscar.Visible = false;
                CargarDatosPorDni(_dni);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtBuscarDni.Text.Trim();
            if (!string.IsNullOrEmpty(dni))
            {
                CargarDatosPorDni(dni);
            }
        }

        private void CargarDatosPorDni(string dni)
        {
            // Busca el socio por DNI y carga los datos en los controles
            Postulantes datosSocio = new Postulantes();
            DataTable dt = datosSocio.BuscarSocioPorDni(dni);
            if (dt.Rows.Count > 0)
            {
                _idSocio = Convert.ToInt32(dt.Rows[0]["idSocio"]);
                txtNumeroSocio.Text = dt.Rows[0]["idSocio"].ToString();
                txtNombreApellido.Text = dt.Rows[0]["nombre"] + " " + dt.Rows[0]["apellido"];
                txtDni.Text = dt.Rows[0]["dni"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró un socio con ese DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumeroSocio.Clear();
                txtNombreApellido.Clear();
                txtDni.Clear();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                // Dibuja el carnet
                float x = 50, y = 50;
                Font fontTitulo = new Font("Arial", 14, FontStyle.Bold);
                Font fontDatos = new Font("Arial", 12);

                // Logo
                if (picLogo.Image != null)
                {
                    ev.Graphics.DrawImage(picLogo.Image, x, y, 80, 80);
                }

                // Datos
                float datosX = x + 100;
                ev.Graphics.DrawString("Carnet de Socio", fontTitulo, Brushes.Black, datosX, y);
                y += 40;
                ev.Graphics.DrawString("N° Socio: " + txtNumeroSocio.Text, fontDatos, Brushes.Black, datosX, y);
                y += 25;
                ev.Graphics.DrawString("Nombre: " + txtNombreApellido.Text, fontDatos, Brushes.Black, datosX, y);
                y += 25;
                ev.Graphics.DrawString("DNI: " + txtDni.Text, fontDatos, Brushes.Black, datosX, y);
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
        private void FrmCarnet_FormClosing(object sender, FormClosingEventArgs e)
        {
            _formularioPrincipal.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.Show();
            this.Close();
        }
    }
}
