using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class ClsListadoDepartamentoDAL
    {/// <summary>
     /// Se conecta a la Base de Datos para devolver una lista de departamentos completa
     /// Pre: nothing
     /// Post: La lista estará llena si hay departamentos en nuestra BDD o vacia si no las hay
     /// </summary>
     /// <returns> List<ClsDepartamento> Lista </returns>
        public static List<ClsDepartamento> ListaDepartamentosDAL()
        {
            SqlConnection miConexion = new SqlConnection();

            List<ClsDepartamento> listadoDepartamentos = new List<ClsDepartamento>();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            ClsDepartamento Departamento;

            miConexion.ConnectionString = ClsConexion.CadenaDeConexion();

            try
            {
                miConexion.Open();

                miComando.CommandText = "SELECT * FROM departamentos";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        Departamento = new ClsDepartamento();

                        Departamento.Id = (int)miLector["ID"];

                        Departamento.Nombre = (string)miLector["Nombre"];

                        listadoDepartamentos.Add(Departamento);
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
            return listadoDepartamentos;
        }


    }
}
