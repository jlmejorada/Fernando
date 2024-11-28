using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLListaCandidatos
    {
        public static List<ClsCandidato> listaCandidatosFiltrados(int dif)
        {
            List<ClsCandidato> lista = new List<ClsCandidato>();
            switch (dif)
            {
                case 1:case 2:
                    lista = DALLListaCandidatos.sacaCandidatosPorFiltro("USA");
                    break;

                case 3:
                    lista = DALLListaCandidatos.sacaCandidatosPorFiltro("USA", 40);
                    break;

                case 4:
                    lista = DALLListaCandidatos.sacaCandidatosPorFiltro("Italia", 0, 45);
                    break;

                case 5:
                    lista = DALLListaCandidatos.sacaCandidatosPorFiltro("Italia", 45, 55);
                    break;
            }
            return lista;
        }
    }
}
