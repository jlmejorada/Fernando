using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using Buscaminas.Models;
using ENT;

namespace Buscaminas.VM
{
    public class VMJuego
    {
        #region ATRIBUTOS
        private int aciertos;

        private ModelPartida partidaActual;
        #endregion

        #region PROPIEDADES
        public int Aciertos { get { return aciertos; } set { aciertos = value; } }
        public ModelPartida PartidaActual { get { return partidaActual; } set { partidaActual = value; } }

        #endregion

        public VMJuego()
        {
            if (partidaActual == null)
            {
                partidaActual = new ModelPartida(1);
            }
            else if (aciertos == partidaActual.Descubiertas)
            {
                partidaActual = new ModelPartida(partidaActual.Dificultad+1);
            }
        }
    }
}
