using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;

namespace UIMaui.Model
{
    public class ClsCandidatoEdadModel: ClsCandidato
    {
        #region ATRIBUTO
        private int edad;
        #endregion

        #region PROPIEDADES
        public int Edad
        {
            get { return edad; } set { edad = value; }
        }
        #endregion

        #region CONSTRUCTORES
        public ClsCandidatoEdadModel()
        {

        }

        public ClsCandidatoEdadModel(int id, string nombre, string apellidos, string direccion, string pais, string telefono, DateTime fechaNacimiento, int precioMedio) : base (id, nombre, apellidos, direccion, pais, telefono, fechaNacimiento, precioMedio)
        {
            this.Edad = (DateTime.Now.Year - fechaNacimiento.Year);
        }

        public ClsCandidatoEdadModel(ClsCandidato candidato) : base(candidato)
        {
            this.Edad = (DateTime.Now.Year - candidato.FechaNacimiento.Year);
        }

        #endregion
    }
}
