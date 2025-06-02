using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class PagosActividad
    {
        public string RegistrarPagoActividad(int idNoSocio, int idActividad, DateTime fechaPago, string tipoPago, double monto)
        {
            string respuesta = "";
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("RegistrarPagoActividad", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_idNoSocio", idNoSocio);
                cmd.Parameters.AddWithValue("p_idActividad", idActividad);
                cmd.Parameters.AddWithValue("p_fechaPago", fechaPago);
                cmd.Parameters.AddWithValue("p_tipoPago", tipoPago);
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

        public DataRow ObtenerNoSocioPorDni(string dni)
        {
            DataTable tabla = new DataTable();
            DataRow fila = null;

            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
                {
                    sqlCon.Open();
                    string consulta = @"SELECT ns.idNoSocio, p.Nombre, p.Apellido 
                                        FROM nosocio ns 
                                        INNER JOIN persona p ON ns.idPersona = p.idPersona 
                                        WHERE p.Dni = @dni";

                    MySqlCommand cmd = new MySqlCommand(consulta, sqlCon);
                    cmd.Parameters.AddWithValue("@dni", dni);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(tabla);

                    if (tabla.Rows.Count > 0)
                        fila = tabla.Rows[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar no socio: " + ex.Message);
            }

            return fila;
        }

        public DataTable ObtenerPagosPorNoSocio(int idNoSocio)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
                {
                    sqlCon.Open();
                    string consulta = @"SELECT a.nombre AS Actividad, pa.fechaPago, pa.tipoPago, pa.monto
                                        FROM pagoactividad pa
                                        INNER JOIN actividades a ON pa.idActividad = a.idActividad
                                        WHERE pa.idNoSocio = @idNoSocio
                                        ORDER BY pa.fechaPago DESC";

                    MySqlCommand cmd = new MySqlCommand(consulta, sqlCon);
                    cmd.Parameters.AddWithValue("@idNoSocio", idNoSocio);

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
    }
}
