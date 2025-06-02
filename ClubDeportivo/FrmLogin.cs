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

            txtContrase�a.Text = "Contrase�a";
            txtContrase�a.ForeColor = Color.Silver;
            txtContrase�a.UseSystemPasswordChar = false;

            chkVerPassword.Checked = false;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtContrase�a.UseSystemPasswordChar = false;
            txtContrase�a.Text = "Contrase�a";
            txtContrase�a.ForeColor = Color.Silver;
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
        private void txtContrase�a_Enter(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "Contrase�a")
            {
                txtContrase�a.Text = "";
                txtContrase�a.ForeColor = Color.Black;
                if (!chkVerPassword.Checked)
                {
                    txtContrase�a.UseSystemPasswordChar = true;
                }
            }
        }
        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrase�a.Text))
            {
                txtContrase�a.Text = "Contrase�a";
                txtContrase�a.ForeColor = Color.Silver;
                txtContrase�a.UseSystemPasswordChar = false;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtContrase�a.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso Exitoso", "Mesnajes del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal principal = new frmPrincipal();
                this.Hide(); // Oculta el login
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void chkVerPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtContrase�a.Text != "Contrase�a")
            {
                txtContrase�a.UseSystemPasswordChar = !chkVerPassword.Checked;
            }
        }
    }
}
