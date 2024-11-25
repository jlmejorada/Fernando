using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClsManejadoraDepartamentoBL
    {
        /// <summary>
        /// Busca un departamento en la DAL a través de su ID, aplicando la regla de negocios correspondiente.
        /// Pre: El id debería ser mayor que 0
        /// Post: Si encuentra el departamento, lo devuelve, sino, devuelve un departamento vacia
        /// </summary>
        /// <param name="id">Identificador del departamento a buscar en la Base de Datos</param>
        /// <returns> ClsDepartamento Departamento</returns>
        public static ClsDepartamento BuscaDepartamentoBL(int id)
        {
            return ClsManejadoraDepartamentoDAL.BuscaDepartamentoDAL(id);
        }

        /// <summary>
        ///  Elimina un departamento en la Base de Datos a través de su ID, aplicando la regla de negocios correspondiente.
        ///  Pre: El id debería ser mayor que 0
        /// </summary>
        /// <param name="id">Identificador del departamento a eliminar en la Base de Datos</param>
        /// <returns>bool seBorra</returns>
        public static bool BorraDepartamentoBL(int id)
        {
            return ClsManejadoraDepartamentoDAL.BorraDepartamentoDAL(id);
        }

        /// <summary>
        /// Añade un departamento en nuestra Base de Datos a traves de un departamento pasada por parametros,
        /// aplicando la regla de negocios correspondiente.
        /// Pre: Tiene que pasar un departamento relleno
        /// </summary>
        /// <param name="departamento"> Departamento de la clase ClsDepartamento</param>
        /// <returns>bool seCrea</returns>
        public static bool CreaDepartamentoBL(ClsDepartamento departamento)
        {
            return ClsManejadoraDepartamentoDAL.CreaDepartamentoDAL(departamento);
        }

        /// <summary>
        /// Edita una departamento de nuestra Base de Datos a traves de una departamento pasada por parametros,
        /// , aplicando la regla de negocios correspondiente.
        /// Pre: Pasa una departamento con los datos a cambiar
        /// </summary>
        /// <param name="departamento"> Departamento de la clase ClsDepartamento</param>
        /// <returns>bool seEdita</returns>
        public static bool EditaDepartamentoBL(ClsDepartamento departamento)
        {
            return ClsManejadoraDepartamentoDAL.EditaDepartamentoDAL(departamento);
        }
    }
}
