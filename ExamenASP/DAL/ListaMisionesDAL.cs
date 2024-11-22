using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListaMisionesDAL
    {
        /// <summary>
        /// Lista estatica de nuestras misiones
        /// </summary>
        static List<ClsMision> misiones = new List<ClsMision>();

        /// <summary>
        /// Si tuvieramos una bdd, esta función extraeria una lista de misiones de esta
        /// </summary>
        /// <returns>Lista de misiones</returns>
        public static List<ClsMision> extraeMisionesDAL()
        {
            return misiones = new List<ClsMision>
            {
                new ClsMision(1, "Recoger impuestos en el restaurante", 1),
                new ClsMision(2, "Hacer una oferta que no puedan rechazar al sindicato de basura", 2),
                new ClsMision(3, "Supervisar obras en New Jersey", 3),
                new ClsMision(4, "Convencer al concejal de urbanismo para conseguir favores", 4),
                new ClsMision(5, "Encargarse del concejal de urbanismo que no se dejó convencer", 5),
                new ClsMision(6, "Llevar la contabilidad del Bada Bing", 1),
            };
        }
    }
}
