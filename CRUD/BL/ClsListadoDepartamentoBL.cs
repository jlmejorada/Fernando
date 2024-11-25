using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClsListadoDepartamentoBL
    {
        /// <summary>
        /// Crea una lista de Departamentos y se conecta a la DAL para devolvela llena, aplicando la regla de negocios correspondiente.
        /// 
        /// Pre: nothing
        /// Post: La lista estará llena si hay departamentos en nuestra DAL o vacia si no las hay
        /// </summary>
        /// <returns> List<ClsDepartamento> Lista </returns>
        public static List<ClsDepartamento> ListaDepartamentosBL()
        {
            List<ClsDepartamento> lista = ClsListadoDepartamentoDAL.ListaDepartamentosDAL();
            return lista;
        }
    }
}
