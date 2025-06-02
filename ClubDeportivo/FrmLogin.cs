using System.Data;

namespace ClubDeportivo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtUsuario.Text = "Usuario";
            txtUsuario.ForeColor = Color.Silver;

            txtContraseña.Text = "Contraseña";
            txtContraseña.ForeColor = Color.Silver;
            txtContraseña.UseSystemPasswordChar = false;

            chkVerPassword.Checked = false;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            txtContraseña.Text = "Contraseña";
            txtContraseña.ForeColor = Color.Silver;
            chkVerPassword.Checked = false;
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                if (!chkVerPassword.Checked)
                {
                    txtContraseña.UseSystemPasswordChar = true;
                }
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtContraseña.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso Exitoso", "Mesnajes del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal principal = new frmPrincipal();
                this.Hide(); // Oculta el login
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void chkVerPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "Contraseña")
            {
                txtContraseña.UseSystemPasswordChar = !chkVerPassword.Checked;
            }
        }
    }
}
