using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FrmInscripcion : Form
    {
        private frmPrincipal _formularioPrincipal;
        private bool _mostrarPrincipalAlCerrar = true;

        public FrmInscripcion(frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            _formularioPrincipal = formularioPrincipal;
        }        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.Show();
            _mostrarPrincipalAlCerrar = false;
            this.Close();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string dni = txtDocumento.Text.Trim();
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
                txtDocumento.Text == "" || txtDomicilio.Text == "" ||
                txtTelefono.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                Datos.Postulantes postulantes = new Datos.Postulantes();

                //  Verificar si ya existe una persona con ese DNI
                if (postulantes.ExisteDni(txtDocumento.Text))
                {
                    MessageBox.Show("Ya existe una persona inscripta con ese DNI.",
                        "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string respuesta;

                if (chkSocio.Checked)
                {
                    double montoCuota = Datos.CuotasDAO.ObtenerUltimoMontoCuota();
                    // Crear Socio
                    Entidades.Socio socio = new Entidades.Socio
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Dni = txtDocumento.Text,
                        FechaNacimiento = dtpNacimiento.Value,
                        Domicilio = txtDomicilio.Text,
                        Telefono = txtTelefono.Text,
                        FichaMedica = chkFichaMedica.Checked,
                        FechaAlta = DateTime.Now,
                        Carnet = chkCarnetEntregado.Checked,
                        PrecioCuota = montoCuota
                    };

                    respuesta = postulantes.RegistrarPersona(socio, true);
                }
                else
                {
                    // Crear NoSocio
                    Entidades.NoSocio noSocio = new Entidades.NoSocio
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Dni = txtDocumento.Text,
                        FechaNacimiento = dtpNacimiento.Value,
                        Domicilio = txtDomicilio.Text,
                        Telefono = txtTelefono.Text,
                        FichaMedica = chkFichaMedica.Checked,
                        FechaActividad = DateTime.Now,
                        Habilitado = true
                        //IdActividad = Convert.ToInt32(cboActividad.SelectedValue)
                    };

                    respuesta = postulantes.RegistrarPersona(noSocio, false);
                }

                if (respuesta == "OK")
                {
                    if (chkSocio.Checked)
                    {
                        MessageBox.Show("Socio inscripto con éxito.", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmPagos pagos = new FrmPagos(dni, _formularioPrincipal, true);
                        _formularioPrincipal.Hide();
                        _mostrarPrincipalAlCerrar = false;
                        pagos.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No socio inscripto con éxito.", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _formularioPrincipal.Show();
                        _mostrarPrincipalAlCerrar = false;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error: " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        // Limpiamos los objetos para un nuevo ingreso
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";
            chkSocio.Checked = false;
            chkFichaMedica.Checked = false;
            chkCarnetEntregado.Checked = false;
            dtpNacimiento.Value = DateTime.Now;
            
            txtNombre.Focus();
        }
        private void FrmInscipcion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_mostrarPrincipalAlCerrar)
                _formularioPrincipal.Show();
        }
    }
}
