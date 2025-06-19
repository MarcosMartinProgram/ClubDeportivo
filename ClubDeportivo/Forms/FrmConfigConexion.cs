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
    public partial class FrmConfigConexion : Form
    {
        public string Servidor => txtServidor.Text.Trim();
        public string BaseDatos => txtBaseDatos.Text.Trim();
        public string Puerto => txtPuerto.Text.Trim();
        public string Usuario => txtUsuario.Text.Trim();
        public string Clave => txtClave.Text;

        public FrmConfigConexion()
        {
            InitializeComponent();
            txtServidor.Text = "";
            txtBaseDatos.Text = "";
            txtPuerto.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Servidor) ||
                string.IsNullOrWhiteSpace(BaseDatos) ||
                string.IsNullOrWhiteSpace(Puerto) ||
                string.IsNullOrWhiteSpace(Usuario))
            {
                MessageBox.Show("Complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkVerClave_CheckedChanged(object sender, EventArgs e)
        {
            
            txtClave.UseSystemPasswordChar = !chkVerClave.Checked;
        }
    }
}
