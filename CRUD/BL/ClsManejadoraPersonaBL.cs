using ENT;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClsManejadoraPersonaBL
    {
        /// <summary>
        /// Busca una persona en la DAL a través de su ID, aplicando la regla de negocios correspondiente.
        /// Pre: El id debería ser mayor que 0
        /// Post: Si encuentra el usuario, lo devuelve, sino, devuelve una persona vacia
        /// </summary>
        /// <param name="id">Identificador de la persona a buscar en la Base de Datos</param>
        /// <returns> ClsPersona Persona</returns>
        public static ClsPersona BuscaPersonaBL(int id)
        {
            return ClsManejadoraPersonaDAL.BuscaPersonaDAL(id);
        }

        /// <summary>
        ///  Elimina una persona en la Base de Datos a través de su ID, aplicando la regla de negocios correspondiente.
        ///  Pre: El id debería ser mayor que 0
        /// </summary>
        /// <param name="id">Identificador de la persona a eliminar en la Base de Datos</param>
        /// <returns>bool seBorra</returns>
        public static bool BorraPersonaBL(int id)
        {
            return ClsManejadoraPersonaDAL.BorraPersonaDAL(id);
        }

        /// <summary>
        /// Añade una persona en nuestra Base de Datos a traves de una persona pasada por parametros,
        /// aplicando la regla de negocios correspondiente.
        /// Pre: Tiene que pasar una persona rellena
        /// </summary>
        /// <param name="persona"> Persona de la clase ClsPersona</param>
        /// <returns>bool seCrea</returns>
        public static bool CreaPersonaBL(ClsPersona persona)
        {
            return ClsManejadoraPersonaDAL.CreaPersonaDAL(persona);
        }

        /// <summary>
        /// Edita una persona de nuestra Base de Datos a traves de una persona pasada por parametros,
        /// , aplicando la regla de negocios correspondiente.
        /// Pre: Pasa una persona con los datos a cambiar
        /// </summary>
        /// <param name="persona"> Persona de la clase ClsPersona</param>
        /// <returns>bool seEdita</returns>
        public static bool EditaPersonaBL(ClsPersona persona)
        {
            return ClsManejadoraPersonaDAL.EditaPersonaDAL(persona);
        }
    }
}
