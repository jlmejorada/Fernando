using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;

namespace DAL
{
    public class DALLListaCandidatos
    {
        #region FUNCIONES
        /// <summary>
        /// Función que saca una lista de candidatos de una supuesta BDD
        /// </summary>
        /// <returns></returns>
        public static List<ClsCandidato> sacaCandidatos()
        {
            List<ClsCandidato> lista = new List<ClsCandidato>()
            {
                new ClsCandidato(1, "Vito", "Gordon", "Pizza nose", "USA", "5464565", new DateTime(1961, 11, 10), 2500),
                new ClsCandidato(2, "Christopher", "Moltisanti", "St Monti Av", "USA", "4445532", new DateTime(2000, 03, 22), 1500),
                new ClsCandidato(3, "Braulia", "Galliani", "Brooklin", "USA", "5553421", new DateTime(1998, 12, 09), 1500),
                new ClsCandidato(4, "Paulie", "Gualtieri", "Soprano St", "USA", "65745532", new DateTime(1968, 07, 24), 2000),
                new ClsCandidato(5, "Estas", "Caputo", "Via Bonna Av", "Italia", "4445532", new DateTime(1973, 03, 22), 20000),
                new ClsCandidato(6, "Toco", "L'Acordeone", "Via Musica Av", "Italia", "4445532", new DateTime(1984, 03, 22), 14000),
                new ClsCandidato(7, "Luigi", "Peperoni", "Piaza Roma Av", "Italia", "4445532", new DateTime(1999, 03, 22), 16000),
                new ClsCandidato(8, "Silvio", "Dante", "Town Street Av", "USA", "4445532", new DateTime(1966, 03, 22), 2000)
            };
            return lista;
        }

        /// <summary>
        /// Saca una lista de candidatos segun su pais y si su edad se incluyen en los rangos
        /// </summary>
        /// <param name="pais"></param>
        /// <param name="minEdad"></param>
        /// <param name="maxEdad"></param>
        /// <returns></returns>
        public static List<ClsCandidato> sacaCandidatosPorFiltro(string pais, int minEdad = 0, int maxEdad = 0)
        {
            List<ClsCandidato> lista;
            if (minEdad==0 && maxEdad == 0)
            {
                lista = sacaCandidatos().Where(can=>can.Pais.Equals(pais)).ToList();
            }
            else
            {
                lista = sacaCandidatos().Where(can => can.Pais.Equals(pais) && (DateTime.Now.Year - can.FechaNacimiento.Year)>minEdad && (DateTime.Now.Year - can.FechaNacimiento.Year) < maxEdad).ToList();
            }
            return lista;
        }

        #endregion
    }
}
