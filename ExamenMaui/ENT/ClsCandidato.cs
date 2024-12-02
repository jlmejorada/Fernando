using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsCandidato
    {
        #region ATRIBUTOS
        private int id;
        private string nombre;
        #endregion

        #region PROPIEDADES
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
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor publico de candidatos
        /// </summary>
        public ClsCandidato()
        {

        }
        /// <summary>
        /// Constructor privado de candidato
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        public ClsCandidato(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        #endregion
    }
}
