using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLListadoCandidatos
    {
        /// <summary>
        /// Saca una lista de candidatos desde nuestra DAL, aplicqandole unas reglas de negocio
        /// </summary>
        /// <returns></returns>
        public static List<ClsCandidato> sacarCandidatosBL()
        {
            List<ClsCandidato> lista = DALListadoCandidatos.sacarCandidatosDAL();
            return lista;
        }
    }
}
