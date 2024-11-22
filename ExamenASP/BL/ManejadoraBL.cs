using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ManejadoraBL
    {
        /// <summary>
        /// Recoge de seleccionaMision BL la mision`que preguntamos por paramentros
        /// Pre: que el numero de ID sea valido
        /// </summary>
        /// <param name="idMision"></param>
        /// <returns>ClsMision mision</returns>
        public static ClsMision seleccionaMisionBL(int idMision)
        {
            ClsMision mision = ManejadoraDAL.seleccionaMisionDAL(idMision);
            return mision;
        }

        /// <summary>
        /// Recoge de seleccionaCandidato BL la mision`que preguntamos por paramentros
        /// Pre: que el numero de ID sea valido
        /// </summary>
        /// <param name="idCandidato"></param>
        /// <returns>ClsCandidato candidato</returns>
        public static ClsCandidato seleccionaCandidatoBL(int idCandidato)
        {
            ClsCandidato candidato = ManejadoraDAL.seleccionaCandidatoDAL(idCandidato);
            return candidato;
        }
    }
}
