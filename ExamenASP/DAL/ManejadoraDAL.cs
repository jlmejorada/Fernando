using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManejadoraDAL
    {
        /// <summary>
        /// Funcion que compara el id de una mision introducida por parametros para asi
        /// encontrar el objeto dentro de la lista de misiones y devolverlo
        /// Pre: que el numero de ID sea valido
        /// </summary>
        /// <param name="idMision"></param>
        /// <returns>ClsMision mision</returns>
        public static ClsMision seleccionaMisionDAL(int idMision)
        {
            ClsMision mision = new ClsMision();
            List<ClsMision> lista = ListaMisionesDAL.extraeMisionesDAL();
            foreach (ClsMision m in lista)
            {
                if (m.Id == idMision)
                {
                    mision= m;
                }
            }
            return mision;
        }

        /// <summary>
        /// Funcion que compara el id de un candidato introducido por parametros para 
        /// asi encontrar el objeto dentro de la lista de candidatos y devolverlo
        /// Pre: que el numero de ID sea valido
        /// </summary>
        /// <param name="idCandidato"></param>
        /// <returns>ClsCandidato candidato</returns>
        public static ClsCandidato seleccionaCandidatoDAL(int idCandidato)
        {
            ClsCandidato candidato = new ClsCandidato();
            List<ClsCandidato> lista = ListaCandidatosDAL.extraeCandidatosDAL();
            foreach (ClsCandidato m in lista)
            {
                if (m.Id == idCandidato)
                {
                    candidato = m;
                }
            }
            return candidato;
        }
    }
}
