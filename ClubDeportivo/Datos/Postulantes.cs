using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Postulantes

    {
        public bool ExisteDni(string dni)
        {
            bool existe = false;

            using (MySqlConnection conexion = Conexion.getInstancia().CrearConcexion())
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand("SELECT COUNT(*) FROM persona WHERE dni = @dni", conexion))
                {
                    comando.Parameters.AddWithValue("@dni", dni);
                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                    if (cantidad > 0)
                        existe = true;
                }
            }

            return existe;
        }




        public string RegistrarPersona(Persona persona, bool esSocio)
        {
            string salida = "";
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando;

                if (esSocio && persona is Socio socio)
                {
                    comando = new MySqlCommand("InsertarSocio", sqlCon);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("p_nombre", socio.Nombre);
                    comando.Parameters.AddWithValue("p_apellido", socio.Apellido);
                    comando.Parameters.AddWithValue("p_dni", socio.Dni);
                    comando.Parameters.AddWithValue("p_fechaNacimiento", socio.FechaNacimiento);
                    comando.Parameters.AddWithValue("p_domicilio", socio.Domicilio);
                    comando.Parameters.AddWithValue("p_telefono", socio.Telefono);
                    comando.Parameters.AddWithValue("p_fichaMedica", socio.FichaMedica);
                    comando.Parameters.AddWithValue("p_fechaAlta", socio.FechaAlta);
                    comando.Parameters.AddWithValue("p_carnet", socio.Carnet);
                    comando.Parameters.AddWithValue("p_precioCuota", socio.PrecioCuota);
                }
                else if (!esSocio && persona is NoSocio noSocio)
                {
                    comando = new MySqlCommand("InsertarNoSocio", sqlCon);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("p_nombre", noSocio.Nombre);
                    comando.Parameters.AddWithValue("p_apellido", noSocio.Apellido);
                    comando.Parameters.AddWithValue("p_dni", noSocio.Dni);
                    comando.Parameters.AddWithValue("p_fechaNacimiento", noSocio.FechaNacimiento);
                    comando.Parameters.AddWithValue("p_domicilio", noSocio.Domicilio);
                    comando.Parameters.AddWithValue("p_telefono", noSocio.Telefono);
                    comando.Parameters.AddWithValue("p_fichaMedica", noSocio.FichaMedica);
                    comando.Parameters.AddWithValue("p_fechaActividad", noSocio.FechaActividad);
                    comando.Parameters.AddWithValue("p_habilitado", noSocio.Habilitado);
                    comando.Parameters.AddWithValue("p_idActividad", noSocio.IdActividad);
                }
                else
                {
                    return "Error al identificar tipo de persona.";
                }

                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = "OK";
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return salida;
        }
        public DataTable BuscarSocioPorDni(string dni)
        {
            DataTable tablaResultado = new DataTable();

            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
                {
                    sqlCon.Open();

                    string query = @"SELECT s.idSocio, p.nombre, p.apellido, p.dni 
                             FROM socio s 
                             INNER JOIN persona p ON s.idPersona = p.idPersona 
                             WHERE p.dni = @dni";

                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@dni", dni);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(tablaResultado);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar socio por DNI: " + ex.Message);
            }

            return tablaResultado;
        }

    }
}
