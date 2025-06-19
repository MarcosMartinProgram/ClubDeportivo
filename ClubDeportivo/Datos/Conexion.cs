using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// --------------------
// Referencia a MySQL (se agrega como libreria)
using MySql.Data.MySqlClient;
using ClubDeportivo.Forms;

namespace ClubDeportivo.Datos
{
    public class Conexion 
    {
        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion() // asignamos valores a las variables de la conexion
        {
            bool conectado = false;
            while (!conectado)
            {
                using (var frm = new FrmConfigConexion())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        this.servidor = frm.Servidor;
                        this.baseDatos = frm.BaseDatos;
                        this.puerto = frm.Puerto;
                        this.usuario = frm.Usuario;
                        this.clave = frm.Clave;

                        try
                        {
                            using (var testCon = CrearConcexion())
                            {
                                testCon.Open();
                                testCon.Close();
                            }
                            conectado = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        Application.Exit();
                        return;
                    }
                }
            }
        }

        // proceso de interacción
        public MySqlConnection CrearConcexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                    ";port=" + this.puerto +
                    ";username=" + this.usuario +
                    ";password=" + this.clave +
                    ";Database=" + this.baseDatos;
            }
            catch (Exception)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }
    }
}