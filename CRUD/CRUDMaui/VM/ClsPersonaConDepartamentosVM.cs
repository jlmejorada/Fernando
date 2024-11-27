﻿using BL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMaui.VM
{
    public class ClsPersonaConDepartamentosVM : ClsPersona
    {
        #region ATRIBUTOS
        private List<ClsDepartamento> departamentos;
        #endregion

        #region PROPIEDADES
        public List<ClsDepartamento> Departamentos
        {
            get
            {
                return departamentos;
            }
        }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor por defectos
        /// </summary>
        public ClsPersonaConDepartamentosVM()
        {
            departamentos = ClsListadoDepartamentoBL.ListaDepartamentosBL();
        }
        /// <summary>
        /// Constructor con parametros 
        /// </summary>
        /// <param name="persona"></param>
        public ClsPersonaConDepartamentosVM(ClsPersona persona)
        {
            Id = persona.Id;
            Nombre = persona.Nombre;
            Apellidos = persona.Apellidos;
            Telefono = persona.Telefono;
            Direccion = persona.Direccion;
            Foto = persona.Foto;
            FechaNacimiento = persona.FechaNacimiento;
            IDDepartamento = persona.IDDepartamento;
            departamentos = ClsListadoDepartamentoBL.ListaDepartamentosBL();
        }
        #endregion
    }
}
