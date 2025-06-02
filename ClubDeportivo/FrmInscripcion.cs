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
    public partial class FrmInscripcion : Form
    {
        private frmPrincipal _formularioPrincipal;
        public FrmInscripcion(frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            _formularioPrincipal = formularioPrincipal;
        }        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.Show();
            this.Close();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
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
                        Carnet = chkCarnetEntregado.Checked
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
                    MessageBox.Show("Se almacenó con éxito.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            _formularioPrincipal.Show();
        }
    }
}
