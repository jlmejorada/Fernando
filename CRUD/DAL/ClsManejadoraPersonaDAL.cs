using ENT;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClsManejadoraPersonaDAL
    {
        /// <summary>
        /// Busca una persona en la Base de Datos a través de su ID
        /// Pre: El id debería ser mayor que 0
        /// Post: Si encuentra el usuario, lo devuelve, sino, devuelve una persona vacia
        /// </summary>
        /// <param name="id">Identificador de la persona a buscar en la Base de Datos</param>
        /// <returns> ClsPersona Persona</returns>
        public static ClsPersona BuscaPersonaDAL(int id)
        {
            SqlConnection miConexion = new SqlConnection();

            List<ClsPersona> listadoPersonas = new List<ClsPersona>();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            ClsPersona Persona = new ClsPersona();

            miConexion.ConnectionString = ClsConexion.CadenaDeConexion();

            try
            {
                miConexion.Open();

                miComando.Parameters.AddWithValue("@id", id);
                miComando.CommandText = "SELECT * FROM personas WHERE ID = @id";
                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    miLector.Read();

                    //Nombre, Apellidos, Telefono, Direccion, Foto, FechaNacimiento, IDDepartamento
                    Persona = new ClsPersona();

                    Persona.Id = (int)miLector["ID"];

                    Persona.Nombre = (string)miLector["Nombre"];

                    Persona.Apellidos = (string)miLector["Apellidos"];

                    if (miLector["FechaNacimiento"] != System.DBNull.Value)
                    { 
                        Persona.FechaNacimiento = (DateTime)miLector["FechaNacimiento"]; 
                    }

                    Persona.Direccion = (string)miLector["Direccion"];

                    Persona.Foto = (string)miLector["Foto"];

                    Persona.Telefono = (string)miLector["Telefono"];

                    Persona.IDDepartamento = (int)miLector["IDDepartamento"];
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
            return Persona;
        }

        /// <summary>
        ///  Elimina una persona en la Base de Datos a través de su ID
        ///  Pre: El id debería ser mayor que 0
        /// </summary>
        /// <param name="id">Identificador de la persona a eliminar en la Base de Datos</param>
        /// <returns>bool seBorra</returns>
        public static bool BorraPersonaDAL(int id)
        {
            bool seBorra = false;

            //Si queremos poner la opción de borrar más de una persona y queremos ver las filas afectadas
            //int numeroFilasAfectadas = 0;

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            miConexion.ConnectionString = ClsConexion.CadenaDeConexion();

            miComando.Parameters.AddWithValue("@id", id);

            try
            {
                miConexion.Open();

                miComando.CommandText = "DELETE FROM Personas WHERE ID=@id";

                miComando.Connection = miConexion;

                if (miComando.ExecuteNonQuery() > 0)
                {
                    seBorra = true;
                }

                //Si queremos poner la opción de borrar más de una persona y queremos ver las filas afectadas
                //numeroFilasAfectadas = miComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return seBorra;

            //Si queremos poner la opción de borrar más de una persona y queremos ver las filas afectadas
            //return numeroFilasAfectadas;
        }

        /// <summary>
        /// Añade una persona en nuestra Base de Datos a traves de una persona pasada por parametros
        /// Pre: Tiene que pasar una persona rellena
        /// </summary>
        /// <param name="persona"> Persona de la clase ClsPersona</param>
        /// <returns>bool seCrea</returns>
        public static bool CreaPersonaDAL(ClsPersona persona)
        {
            bool seCrea = false;

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            miConexion.ConnectionString = ClsConexion.CadenaDeConexion();

            try
            {
                miConexion.Open();

                miComando.Parameters.AddWithValue("@nombre", persona.Nombre);
                miComando.Parameters.AddWithValue("@apellidos", persona.Apellidos);
                miComando.Parameters.AddWithValue("@tel", persona.Telefono);
                miComando.Parameters.AddWithValue("@dir", persona.Direccion);
                miComando.Parameters.AddWithValue("@foto", persona.Foto);
                miComando.Parameters.AddWithValue("@fecha", persona.FechaNacimiento);
                miComando.Parameters.AddWithValue("@dep", persona.IDDepartamento);
                miComando.CommandText = "INSERT INTO Personas (Nombre, Apellidos, Telefono, Direccion, Foto, FechaNacimiento,IDDepartamento) " +
                    "VALUES (@nombre, @apellidos, @tel, @dir, @foto, @fecha, @dep)";

                miComando.Connection = miConexion;

                if (miComando.ExecuteNonQuery() > 0)
                {
                    seCrea = true;
                }

            }
            catch (SqlException exSql)
            {

                throw exSql;

            }
            finally
            {
                miConexion.Close();
            }
            return seCrea;

        }

        /// <summary>
        /// Edita una persona de nuestra Base de Datos a traves de una persona pasada por parametros
        /// Pre: Pasa una persona con los datos a cambiar
        /// </summary>
        /// <param name="persona"> Persona de la clase ClsPersona</param>
        /// <returns>bool seEdita</returns>
        public static bool EditaPersonaDAL(ClsPersona persona)
        {
            bool seEdita = false;

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            miConexion.ConnectionString = ClsConexion.CadenaDeConexion();

            try
            {
                miConexion.Open();

                miComando.Parameters.AddWithValue("@nombre", persona.Nombre);
                miComando.Parameters.AddWithValue("@apellidos", persona.Apellidos);
                miComando.Parameters.AddWithValue("@tel", persona.Telefono);
                miComando.Parameters.AddWithValue("@dir", persona.Foto);
                miComando.Parameters.AddWithValue("@fecha", persona.FechaNacimiento);
                miComando.Parameters.AddWithValue("@dep", persona.IDDepartamento);
                miComando.CommandText = "UPDATE INTO personas (Nombre, Apellidos, Telefono, Foto, FechaNacimiento,IDDepartamento) " +
                    "VALUES (@nombre, @apellidos, @tel, @dir, @fecha, @dep)";

                miComando.Connection = miConexion;

                if (miComando.ExecuteNonQuery() > 0)
                {
                    seEdita = true;
                }

            }
            catch (SqlException exSql)
            {

                throw exSql;

            }
            finally
            {
                miConexion.Close();
            }
            return seEdita;

        }

    }
}
