using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALListaMisiones
    {
        #region FUNCIONES
        /// <summary>
        /// Función que saca una lista de misiones de una supuesta BDD
        /// </summary>
        /// <returns></returns>
        public static List<ClsMision> sacaMisionesDAL()
        {
            List<ClsMision> lista = new List<ClsMision>()
            {
                new ClsMision(1, "Recoger impuestos en el restaurante", 1),
                new ClsMision(2, "Hacer una oferta que no puedan rechazar al sindicato de basura", 2),
                new ClsMision(3, "Supervisar obras en New Jersey", 3),
                new ClsMision(4, "Convencer a Concejal de urbanismo para conseguir favores",4),
                new ClsMision(5, "Encargarse del consejal de urbanismo que no se dejó convencer", 5),
                new ClsMision(6, "Llevar la contabilidad del Bada Bing", 1)
            };
            return lista;
        }

        #endregion
    }
}
