using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    public class CuotasDAO
    {
        public static double ObtenerUltimoMontoCuota()
        {
            double monto = 0;

            using (MySqlConnection con = Conexion.getInstancia().CrearConcexion())
            {
                con.Open();

                string query = @"SELECT monto 
                             FROM valor_cuota 
                             ORDER BY idValorCuota DESC 
                             LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                        monto = Convert.ToDouble(resultado);
                }
            }

            return monto;
        }

       
    }
}
