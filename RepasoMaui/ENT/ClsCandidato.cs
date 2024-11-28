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
        private string apellidos;
        private string direccion;
        private string pais;
        private string telefono;
        private DateTime fechaNacimiento;
        private int precioMedio;
        #endregion

        #region PROPIEDADES
        public int Id {  get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Pais { get { return pais; } set { pais = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
        public int PrecioMedio { get { return precioMedio; } set { precioMedio = value; } }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// COnstructor sin parametros
        /// </summary>
        public ClsCandidato()
        {
        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="direccion"></param>
        /// <param name="pais"></param>
        /// <param name="telefono"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="precioMedio"></param>
        public ClsCandidato(int id, string nombre, string apellidos, string direccion, string pais, string telefono, DateTime fechaNacimiento, int precioMedio)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.pais = pais;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
            this.precioMedio = precioMedio;
        }

        public ClsCandidato(ClsCandidato candidato)
        {
            this.id = candidato.id;
            this.nombre = candidato.nombre;
            this.apellidos = candidato.apellidos;
            this.direccion = candidato.direccion;
            this.pais = candidato.pais;
            this.telefono = candidato.telefono;
            this.fechaNacimiento = candidato.fechaNacimiento;
            this.precioMedio = candidato.precioMedio;
        }

        #endregion
    }
}