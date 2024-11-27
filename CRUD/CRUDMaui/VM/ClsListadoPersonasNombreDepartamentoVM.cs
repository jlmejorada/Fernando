using BL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDMaui.Models;
using System.Collections.ObjectModel;

namespace CRUDMaui.VM
{
    public class ClsListadoPersonasNombreDepartamentoVM
    {
        #region ATRIBUTO
        private ObservableCollection<ClsPersonaNombreDepartamento> lista;
        #endregion

        #region PROPIEDAD
        public ObservableCollection<ClsPersonaNombreDepartamento> Lista { get { return lista; } }
        public ClsPersonaNombreDepartamento personaSeleccionada { get; set; }
        #endregion

        #region CONSTRUCTOR
        public ClsListadoPersonasNombreDepartamentoVM()
        {
            List<ClsPersona> personas;
            List<ClsDepartamento> departamentos;

            this.lista = new ObservableCollection<ClsPersonaNombreDepartamento>();

            personas = ClsListadoPersonaBL.ListaPersonasBL();

            departamentos = ClsListadoDepartamentoBL.ListaDepartamentosBL();

            foreach (ClsPersona persona in personas)
            {
                this.lista.Add(new ClsPersonaNombreDepartamento(persona, departamentos));
            }
        }
        #endregion
    }
}
