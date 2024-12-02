using ENT;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALManejadoraCandidatos
    {
        /// <summary>
        /// Funcion que saca un Candidato por su id
        /// Pre: que el id esté en nuestra "BDD"
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ClsCandidato</returns>
        public static ClsCandidato buscaCandidatoDAL(int id)
        {
            List<ClsCandidato> lista = DALListadoCandidatos.sacarCandidatosDAL();
            ClsCandidato candidato = (ClsCandidato)lista.Where(can => can.Id == id).FirstOrDefault();
            return candidato;
        }
    }
}
