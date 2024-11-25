using ENT;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClsManejadoraDepartamentoDAL
    {
        /// <summary>
        /// Busca un departamento en la Base de Datos a través de su ID
        /// Pre: El id debería ser mayor que 0
        /// Post: Si encuentra el departamento, lo devuelve, sino, devuelve un departamento vacia
        /// </summary>
        /// <param name="id">Identificador del departamento a buscar en la Base de Datos</param>
        /// <returns> ClsPersona Persona</returns>
        public static ClsDepartamento BuscaDepartamentoDAL(int id)
        {
            SqlConnection miConexion = new SqlConnection();

            List<ClsDepartamento> listadoDepartamento = new List<ClsDepartamento>();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            ClsDepartamento departamento = new ClsDepartamento();

            miConexion.ConnectionString = ClsConexion.CadenaDeConexion();

            try
            {
                miConexion.Open();

                miComando.Parameters.AddWithValue("@id", id);
                miComando.CommandText = "SELECT * FROM departamentos WHERE ID = @id";
                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    miLector.Read();

                    //Nombre, Apellidos, Telefono, Direccion, Foto, FechaNacimiento, IDDepartamento
                    departamento = new ClsDepartamento();

                    departamento.Id = (int)miLector["ID"];

                    departamento.Nombre = (string)miLector["Nombre"];
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
            return departamento;
        }

        /// <summary>
        ///  Elimina un departamento en la Base de Datos a través de su ID
        ///  Pre: El id debería ser mayor que 0
        /// </summary>
        /// <param name="id">Identificador del departaamento a eliminar en la Base de Datos</param>
        /// <returns>bool seBorra</returns>
        public static bool BorraDepartamentoDAL(int id)
        {
            bool seBorra = false;

            //Si queremos poner la opción de borrar más de un departamento y queremos ver las filas afectadas
            //int numeroFilasAfectadas = 0;

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            miConexion.ConnectionString = ClsConexion.CadenaDeConexion();

            miComando.Parameters.AddWithValue("@id", id);

            try
            {
                miConexion.Open();

                miComando.CommandText = "DELETE FROM departamentos WHERE ID=@id";

                miComando.Connection = miConexion;

                if (miComando.ExecuteNonQuery() > 0)
                {
                    seBorra = true;
                }

                //Si queremos poner la opción de borrar más de un departamento y queremos ver las filas afectadas
                //numeroFilasAfectadas = miComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return seBorra;

            //Si queremos poner la opción de borrar más de un departamento y queremos ver las filas afectadas
            //return numeroFilasAfectadas;
        }

        /// <summary>
        /// Añade un departamento en nuestra Base de Datos a traves de una departamento pasada por parametros
        /// Pre: Tiene que pasar una departamento rellena
        /// </summary>
        /// <param name="departamento"> Departamento de la clase ClsDepartamento</param>
        /// <returns>bool seCrea</returns>
        public static bool CreaDepartamentoDAL(ClsDepartamento departamento)
        {
            bool seCrea = false;

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            miConexion.ConnectionString = ClsConexion.CadenaDeConexion();

            try
            {
                miConexion.Open();

                miComando.Parameters.AddWithValue("@nombre", departamento.Nombre);
                miComando.CommandText = "INSERT INTO departamentos (Nombre) " +
                    "VALUES (@nombre)";

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
        /// Edita una departamento de nuestra Base de Datos a traves de una departamento pasada por parametros
        /// Pre: Pasa una departamento con los datos a cambiar
        /// </summary>
        /// <param name="departamento">Departamento de la clase ClsDepartamento</param>
        /// <returns>bool seEdita</returns>
        public static bool EditaDepartamentoDAL(ClsDepartamento departamento)
        {
            bool seEdita = false;

            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            miConexion.ConnectionString = ClsConexion.CadenaDeConexion();

            try
            {
                miConexion.Open();

                miComando.Parameters.AddWithValue("@nombre", departamento.Nombre);
                miComando.CommandText = "UPDATE INTO departamentos (Nombre) " +
                    "VALUES (@nombre)";

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
