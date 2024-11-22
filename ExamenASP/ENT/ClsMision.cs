﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsMision
    {
        #region ATRIBUTOS
        private int id;
        private string nombre;
        private int dificultad;
        #endregion

        #region PROPIEDADES
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Dificultad { get { return dificultad; } set { dificultad = value; } }
        #endregion

        #region CONSTRUCTORES
        public ClsMision()
        {

        }
        public ClsMision(int id, string nombre, int dificultad)
        {
            this.id = id;
            this.nombre = nombre;
            this.dificultad = dificultad;
        }
        #endregion
    }
}
