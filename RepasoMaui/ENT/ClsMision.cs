using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsMision
    {
        #region ATRIBUTOS;
        private int id;
        private string nombre;
        private int dificultad;
        #endregion

        #region PROPIEDADES;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Dificultad
        {
            get
            {
                return dificultad;
            }
            set
            {
                dificultad = value;
            }
        }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public ClsMision()
        {

        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="dificultad"></param>
       
        public ClsMision(int id, string nombre, int dificultad)
        {
            Id = id;
            Nombre = nombre;
            Dificultad = dificultad;
        }

        #endregion
    }
}
