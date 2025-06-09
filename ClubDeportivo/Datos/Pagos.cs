using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Pagos
    {
        public string RegistrarPagoSocio(int idSocio, DateTime fechaPago, DateTime fechaVencimiento, string tipoPago, int cantidadCuotas, double monto)
        {
            string respuesta = "";
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("RegistrarPagoSocio", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_idSocio", idSocio);
                cmd.Parameters.AddWithValue("p_fechaPago", fechaPago);
                cmd.Parameters.AddWithValue("p_fechaVencimiento", fechaVencimiento);
                cmd.Parameters.AddWithValue("p_tipoPago", tipoPago);
                cmd.Parameters.AddWithValue("p_cantidadCuotas", cantidadCuotas);
                cmd.Parameters.AddWithValue("p_monto", monto);

                cmd.ExecuteNonQuery();
                respuesta = "OK";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return respuesta;
        }
        public DataTable ObtenerPagosPorSocio(int idSocio)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
                {
                    sqlCon.Open();
                    string consulta = "SELECT fechaPago, fechaVencimiento, tipoPago, cantidadCuotas, monto FROM pagosocio WHERE idSocio = @idSocio ORDER BY fechaPago DESC";

                    MySqlCommand cmd = new MySqlCommand(consulta, sqlCon);
                    cmd.Parameters.AddWithValue("@idSocio", idSocio);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener pagos: " + ex.Message);
            }

            return tabla;
        }

        public DataTable ObtenerSociosCuotaVenceEn(DateTime fecha)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
                {
                    sqlCon.Open();
                    string query = @"
                        SELECT s.idSocio, p.nombre, p.apellido, ps.fechaVencimiento
                        FROM socio s
                        INNER JOIN persona p ON s.idPersona = p.idPersona
                        INNER JOIN pagosocio ps ON s.idSocio = ps.idSocio
                        WHERE ps.fechaVencimiento = @fecha";
                    using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener socios con cuota a vencer: " + ex.Message);
            }
            return tabla;
        }
    }
}
