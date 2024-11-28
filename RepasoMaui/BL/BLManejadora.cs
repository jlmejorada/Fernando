using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLManejadora
    {
        /// <summary>
        /// Funcion que devuelve un candidato buscado por su id
        /// Pre: el id a busca existe en nuestra lista
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ClsCandidato eligeCandidatoBL(int id)
        {
            ClsCandidato candidato = DALManejadora.eligeCandidatoDAL(id);
            return candidato;
        }

        /// <summary>
        /// Funcion que devuelve un mision buscado por su id
        /// Pre: el id a busca existe en nuestra lista
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ClsMision eligeMisionBL(int id)
        {
            ClsMision mision = DALManejadora.eligeMisionDAL(id);
            return mision;
        }
    }
}
