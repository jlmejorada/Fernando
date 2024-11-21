using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class ClsListado
    {
        /// <summary>
        /// Crea una lista de Personas y se conecta a la Base de Datos para devolvela llena
        /// </summary>
        /// <returns> List<ClsPersona> Lista </returns>
        public static List<ClsPersona> ListaPersonas()
        {
            SqlConnection miConexion = new SqlConnection();

            List<ClsPersona> listadoPersonas = new List<ClsPersona>();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            ClsPersona Persona;

            miConexion.ConnectionString = ClsConexion.CadenaDeConexion();

            try
            {
                miConexion.Open();

                miComando.CommandText = "SELECT * FROM personas";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        Persona = new ClsPersona();

                        Persona.Id = (int)miLector["ID"];

                        Persona.Nombre = (string)miLector["Nombre"];

                        Persona.Apellidos = (string)miLector["Apellidos"];

                        if (miLector["FechaNacimiento"] != System.DBNull.Value)

                        { Persona.FechaNacimiento = (DateTime)miLector["FechaNacimiento"]; }

                        Persona.Direccion = (string)miLector["Direccion"];

                        Persona.Foto = (string)miLector["Foto"];

                        Persona.Telefono = (string)miLector["Telefono"];

                        Persona.IDDepartamento = (int)miLector["IDDepartamento"];

                        listadoPersonas.Add(Persona);
                    }
                }
                miLector.Close();
            }
            catch (SqlException exSql)
            {

                throw exSql;

            }
            finally 
            {
                miConexion.Close();
            }
            return listadoPersonas;
        }
    }

}
