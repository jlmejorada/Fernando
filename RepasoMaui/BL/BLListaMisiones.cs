using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENT;

namespace BL
{
    public class BLListaMisiones
    {
        #region FUNCIONES
        /// <summary>
        /// Función que saca una lista de misiones de una DAL
        /// </summary>
        /// <returns></returns>
        public static List<ClsMision> sacaMisionesBL()
        {
            List<ClsMision> lista = DALListaMisiones.sacaMisionesDAL();
            return lista;
        }
        #endregion
    }
}
