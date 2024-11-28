using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALManejadora
    {
        /// <summary>
        /// Funcion que devuelve un candidato buscado por su id
        /// Pre: el id a busca existe en nuestra lista
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ClsCandidato eligeCandidatoDAL(int id)
        {
            List<ClsCandidato> lista = DALLListaCandidatos.sacaCandidatos();
            ClsCandidato candidato = (ClsCandidato)lista.Where(can => can.Id == id).FirstOrDefault();
            return candidato;
        }

        /// <summary>
        /// Funcion que devuelve un mision buscado por su id
        /// Pre: el id a busca existe en nuestra lista
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ClsMision eligeMisionDAL(int id)
        {
            List<ClsMision> lista = DALListaMisiones.sacaMisionesDAL();
            ClsMision mision = (ClsMision)lista.Where(mis => mis.Id == id).FirstOrDefault();
            return mision;
        }
    }
}
