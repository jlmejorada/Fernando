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
    [QueryProperty(nameof(ClsPersonaNombreDepartamento), "persona")]
    public class ClsListadoPersonasNombreDepartamentoVM : clsVMBase
    {
        #region ATRIBUTO
        private ObservableCollection<ClsPersonaNombreDepartamento> lista;
        private ClsPersonaNombreDepartamento personaSeleccionada;
        private DelegateCommand btnDetallesCmd;
        private DelegateCommand btnEditarCmd;
        private DelegateCommand btnBorrarCmd;
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
                BtnBorrarCmd.RaiseCanExecuteChanged();
            }
        }
        public DelegateCommand BtnDetallesCmd { get { return btnDetallesCmd; } }
        public DelegateCommand BtnEditarCmd { get { return btnEditarCmd; } }
        public DelegateCommand BtnBorrarCmd { get { return btnBorrarCmd; } }
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
            var queryParams = new Dictionary<string, Object>
            {
                 {"persona", personaSeleccionada }
            };

            await Shell.Current.GoToAsync("///detallesPersona", queryParams);
        }
        private void btnEditaCmdExecute()
        {

        }
        private void btnBorraCmdExecute()
        {

        }
        #endregion
    }
}
