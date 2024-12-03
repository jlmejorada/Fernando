using BL;
using CRUDMaui.Models;
using CRUDMaui.VM.Utiles;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMaui.VM
{
    [QueryProperty(nameof(Persona), "persona")]
    public class ClsPersonaEditaVM : clsVMBase
    {
        #region ATRIBUTOS
        private List<ClsDepartamento> departamentos;
        private ClsPersona persona;
        private DelegateCommand btnVolverCmd;
        private DelegateCommand btnGuardarCmd;
        private ClsDepartamento dep;
        #endregion

        #region PROPIEDADES
        public List<ClsDepartamento> Departamentos { get {return departamentos; } }
        public ClsPersona Persona
        {
            get { return persona; }
            set
            {
                persona = value;
                NotifyPropertyChanged("Persona");
            }
        }
        public DelegateCommand BtnVolverCmd { get { return btnVolverCmd; } }

        public DelegateCommand BtnGuardarCmd { get { return btnGuardarCmd; } }
        public ClsDepartamento Dep
        {
            get => dep;
            set
            {
                if (dep != value)
                {
                    dep = value;
                    NotifyPropertyChanged("Dep");
                }
            }
        }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor por defectos
        /// </summary>
        public ClsPersonaEditaVM()
        {
            departamentos = ClsListadoDepartamentoBL.ListaDepartamentosBL();
            departamentos = ClsListadoDepartamentoBL.ListaDepartamentosBL();
            btnVolverCmd = new DelegateCommand(btnVolverCmdExecute);
            btnGuardarCmd = new DelegateCommand(btnGuardarCmdExecute);
        }
        #endregion

        #region FUNCIONES
        private async void btnVolverCmdExecute()
        {
            await Shell.Current.GoToAsync("///listaPersona");
        }
        private async void btnGuardarCmdExecute()
        {
            ClsManejadoraPersonaBL.EditaPersonaBL(persona);
            await Shell.Current.GoToAsync("///listaPersona");
        }
        #endregion
    }
}
