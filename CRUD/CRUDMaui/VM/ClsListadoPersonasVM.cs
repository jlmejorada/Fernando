using BL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDMaui.Models;
using System.Collections.ObjectModel;
using CRUDMaui.VM.Utiles;
using CRUDMaui.Views;

namespace CRUDMaui.VM
{
    public class ClsListadoPersonasNombreDepartamentoVM : clsVMBase
    {
        #region ATRIBUTO
        private ObservableCollection<ClsPersonaNombreDepartamento> lista;
        private ClsPersonaNombreDepartamento personaSeleccionada;
        private DelegateCommand btnDetallesCmd;
        private DelegateCommand btnEditarCmd;
        private DelegateCommand btnBorrarCmd;
        private DelegateCommand btnAnadirCmd;
        #endregion

        #region PROPIEDAD
        public ObservableCollection<ClsPersonaNombreDepartamento> Lista { get { return lista; } }
        public ClsPersonaNombreDepartamento PersonaSeleccionada 
        {
            get { return personaSeleccionada; }
            set
            {
                personaSeleccionada = value;
                NotifyPropertyChanged("PersonaSeleccionada");

                btnDetallesCmd.RaiseCanExecuteChanged();
                btnEditarCmd.RaiseCanExecuteChanged();
                btnBorrarCmd.RaiseCanExecuteChanged();
            }
        }
        public DelegateCommand BtnDetallesCmd { get { return btnDetallesCmd; } }
        public DelegateCommand BtnEditarCmd { get { return btnEditarCmd; } }
        public DelegateCommand BtnBorrarCmd { get { return btnBorrarCmd; } }
        public DelegateCommand BtnAnadirCmd { get { return btnAnadirCmd; } }
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

            btnDetallesCmd = new DelegateCommand(btnDetallesCmdExecute, btnCmdCanExecute);
            btnEditarCmd = new DelegateCommand(btnEditaCmdExecute, btnCmdCanExecute);
            btnBorrarCmd = new DelegateCommand(btnBorraCmdExecute, btnCmdCanExecute);
            btnAnadirCmd = new DelegateCommand(btnAnadeCmdExecute);
        }
        #endregion


        #region FUNCIONES
        /// <summary>
        /// Funcion que comprueba si se ha seleccionado a una persona
        /// </summary>
        /// <returns></returns>
        private bool btnCmdCanExecute()
        {
            bool estaSeleccionada = false;
            if (personaSeleccionada != null)
            {
                estaSeleccionada = true;
            }
            return estaSeleccionada;
        }
        private async void btnDetallesCmdExecute()
        {
            ClsPersonaNombreDepartamento persona = personaSeleccionada;
            var queryParams = new Dictionary<string, Object>
            {
                 {"persona",  persona}
            };

            await Shell.Current.GoToAsync("///detallesPersona", queryParams);
        }
        private async void btnEditaCmdExecute()
        {
            ClsPersona persona = new ClsPersona(PersonaSeleccionada);
            var queryParams = new Dictionary<string, Object>
            {
                 {"persona",  persona}
            };

            await Shell.Current.GoToAsync("///editaPersona", queryParams);
        }

        private async void btnAnadeCmdExecute()
        {
            await Shell.Current.GoToAsync("///anadePersona");
        }

        private void btnBorraCmdExecute()
        {
            ClsPersonaNombreDepartamento persona = personaSeleccionada;
            try
            {
                ClsManejadoraPersonaBL.BorraPersonaBL(persona.Id);
                lista.Remove(persona);
                NotifyPropertyChanged("Lista");
            }
            catch 
            { 
               
            }
        }
        #endregion
    }
}
