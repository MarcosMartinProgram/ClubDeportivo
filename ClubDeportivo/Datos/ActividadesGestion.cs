using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    public class ActividadesGestion
    {
        // Obtener todas las actividades (para el ComboBox)
        public DataTable ObtenerActividades()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                sqlCon.Open();
                string query = "SELECT idActividad, nombre, dias, horarios FROM actividades ORDER BY nombre";

                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

        // Obtener el monto asociado a una actividad desde actividad_valor
        public double ObtenerMontoActividad(int idActividad)
        {
            double monto = 0;

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                sqlCon.Open();
                string query = "SELECT monto FROM valor_actividad WHERE idActividad = @idActividad ORDER BY fechaDesde DESC LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@idActividad", idActividad);

                object result = cmd.ExecuteScalar();
                if (result != null && double.TryParse(result.ToString(), out double valor))
                {
                    monto = valor;
                }
            }

            return monto;
        }
        public string InsertarActividad(string nombre, string dias, string horarios, int cupo)
        {
            string respuesta = "";

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    sqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand("InsertarActividad", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_nombre", nombre);
                    cmd.Parameters.AddWithValue("p_dias", dias);
                    cmd.Parameters.AddWithValue("p_horarios", horarios);
                    cmd.Parameters.AddWithValue("p_cupo", cupo);

                    cmd.ExecuteNonQuery();
                    respuesta = "OK";
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }

            return respuesta;
        }
    }
}
