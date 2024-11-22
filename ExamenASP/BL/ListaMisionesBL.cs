using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using DAL;

namespace BL
{
    public class ListaMisionesBL
    {
        /// <summary>
        /// Esta función extrae una lista de misiones de la DAL, 
        /// pudiendo agregarse politicas de empresa
        /// </summary>
        /// <returns>Lista de misiones</returns>
        public static List<ClsMision> extraeMisionesBL()
        {
            List<ClsMision> lista = ListaMisionesDAL.extraeMisionesDAL();
            return lista;
        }
    }
}
