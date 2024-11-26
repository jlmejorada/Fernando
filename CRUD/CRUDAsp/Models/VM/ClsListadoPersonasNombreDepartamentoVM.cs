using BL;
using ENT;
using System.Collections.Generic;

namespace CRUDAsp.Models.VM
{
    public class ClsListadoPersonasNombreDepartamentoVM
    {
        #region ATRIBUTO
        private List<ClsPersonaNombreDepartamento> lista;
        #endregion

        #region PROPIEDAD
        public List<ClsPersonaNombreDepartamento> Lista { get { return lista; } }
        #endregion

        #region CONSTRUCTOR
        public ClsListadoPersonasNombreDepartamentoVM()
        {
            List<ClsPersona> personas;
            List<ClsDepartamento> departamentos;
            this.lista = new List<ClsPersonaNombreDepartamento>();
            
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
