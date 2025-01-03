using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ENTCasilla
    {
        #region ATRIBUTOS
        private bool esBomba;

        private bool estaRevelada;

        private string foto;
        #endregion

        #region PROPIEDADES
        public bool EsBomba
        {
            get { return esBomba; }
            set { esBomba = value; }
        }

        public bool EstaRevelada
        {
            get { return estaRevelada; }
            set { estaRevelada = value;
                if (esBomba)
                {
                    foto = "bomba.png";
                }
                else
                {
                    foto = "tabien.png";
                }
            }
        }

        public string Foto
        {
            get { return foto; }
        }
        #endregion

        #region CONSTRUCTOR
        public ENTCasilla(bool esBomba)
        {
            this.esBomba = esBomba;
            this.estaRevelada = false;
        }
        #endregion
    }
}
