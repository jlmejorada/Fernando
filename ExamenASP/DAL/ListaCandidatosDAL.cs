using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;

namespace DAL
{
    public class ListaCandidatosDAL
    {

        /// <summary>
        /// Si tuvieramos una bdd, esta función extraeria una lista de candidatos de esta
        /// </summary>
        /// <returns>Lista de candidatos</returns>
        public static List<ClsCandidato> extraeCandidatosDAL()
        {
            List<ClsCandidato> candidatos = new List<ClsCandidato>(){
                new ClsCandidato(1, "Vito", "Gordon", "Pizza Street, 123", "USA", "54567686", new DateTime(1961,11,10), 2500),
                new ClsCandidato(2, "Christopher", "Moltisani", "St Monti Av", "USA", "568765466", new DateTime(2000,03,22), 1500),
                new ClsCandidato(3, "Braulia", "Galiani", "Brooklin Av", "USA", "5679321", new DateTime(1998,12,09), 1500),
                new ClsCandidato(4, "Paulie", "Gualtieri", "Soprano Street, 5", "USA", "65783287", new DateTime(1968,07,24), 2000),
                new ClsCandidato(5, "Estás", "Caputo", "Vía Bonna Sera, 14", "Italia", "65656565", new DateTime(1973,06,02), 20000),
                new ClsCandidato(6, "Toco", "L'Acordeone", "Vía Música, 20", "Italia", "65634555", new DateTime(1984,03,12), 14000),
                new ClsCandidato(7, "Luigi", "Peperoni", "Piaza Roma, 3", "Italia", "12356565", new DateTime(1999,04,05), 16000),
                new ClsCandidato(8, "Silvio", "Dante", "Town Street, 56", "USA", "87878787", new DateTime(1966/01/30), 2000),
            };
            return candidatos;
        }
    }
}
