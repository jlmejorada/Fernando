using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENT;


namespace BL
{
    public class ClsListadoBL
    {
        /// <summary>
        /// Crea una lista de Personas y se conecta a la DAL para devolvela llena, aplicando la regla de negocios correspondiente.
        /// 
        /// Pre: nothing
        /// Post: La lista estará llena si hay personas en nuestra DAL o vacia si no las hay
        /// </summary>
        /// <returns> List<ClsPersona> Lista </returns>
        public static List<ClsPersona> ListaPersonasBL()
        {
            List<ClsPersona> lista = ClsListadoDAL.ListaPersonasDAL();
            return lista;
        }
    }
}
