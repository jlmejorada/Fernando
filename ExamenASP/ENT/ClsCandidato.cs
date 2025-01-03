﻿using System;
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
        private DateTime fechaNac;
        private int precioMedio;
        #endregion

        #region PROPIEDADES
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Pais { get { return pais; } set { pais = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public DateTime FechaNac { get { return fechaNac; } set { fechaNac = value; } }
        public int PrecioMedio { get { return precioMedio; } set { precioMedio = value; } }
        #endregion

        #region CONSTRUCTORES
        public ClsCandidato()
        {

        }
        public ClsCandidato(int id, string nombre, string apellidos, string direccion, string pais, string telefono, DateTime fechaNac, int precioMedio)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.pais = pais;
            this.telefono = telefono;
            this.fechaNac = fechaNac;
            this.precioMedio = precioMedio;
        }
        #endregion
    }
}
