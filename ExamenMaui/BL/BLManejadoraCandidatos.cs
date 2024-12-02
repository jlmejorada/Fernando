using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLManejadoraCandidatos
    {
        /// <summary>
        /// Saca un candidato desde nuestra DAL, aplicandole unas reglas de negocio
        /// </summary>
        /// <returns></returns>
        public static ClsCandidato buscaCandidatoBL(int id)
        {
            ClsCandidato candidato = DALManejadoraCandidatos.buscaCandidatoDAL(id);
            return candidato;
        }
    }
}
