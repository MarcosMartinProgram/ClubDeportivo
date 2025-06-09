using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    public class Valores
    {
        public string InsertarValorActividad(int idActividad, double monto, DateTime fechaDesde)
        {
            string respuesta = "";

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    sqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand("InsertarValorActividad", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_idActividad", idActividad);
                    cmd.Parameters.AddWithValue("p_monto", monto);
                    cmd.Parameters.AddWithValue("p_fechaDesde", fechaDesde);

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

        public string InsertarValorCuota(double monto, DateTime fechaDesde)
        {
            string respuesta = "";

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    sqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand("InsertarValorCuota", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_monto", monto);
                    cmd.Parameters.AddWithValue("p_fechaDesde", fechaDesde);

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
