using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDMaui.Models;
using CRUDMaui.VM.Utiles;


namespace CRUDMaui.VM
{
    [QueryProperty(nameof(Persona), "persona")]
    public class ClsDetallesPersonaVM : clsVMBase
    {
        #region ATRIBUTOS
        private ClsPersonaNombreDepartamento persona;
        private DelegateCommand btnVolverCmd;
        #endregion

        #region PROPIEDADES
        public ClsPersonaNombreDepartamento Persona
        {
            get
            {
                return persona;
            }
            set
            {
                persona = value;
                NotifyPropertyChanged("Persona");
            }
        }
        public DelegateCommand BtnVolverCmd { get { return btnVolverCmd; } }

        #endregion

        #region Constructor
        public ClsDetallesPersonaVM()
        {
            btnVolverCmd = new DelegateCommand(btnVolverCmdExecute);
        }
        #endregion

        #region FUNCIONES
        private async void btnVolverCmdExecute()
        {
            await Shell.Current.GoToAsync("///listaPersona");
        }
        #endregion
    }
}
