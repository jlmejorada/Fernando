using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIMaui.Model;
using UIMaui.VM.Util;

namespace UIMaui.VM
{
    [QueryProperty(nameof(Candidato), "candidato")]
    public class DetallesCandidatosVM : clsVMBase
    {
        //var toast = Toast.Make("Persona editada correctamente", ToastDuration.Short, 14);
        //await toast.Show(token.Token);
        //await Shell.Current.GoToAsync("///listadoPersonas");

        #region ATRIBUTOS
        private ClsCandidatoEdadModel candidato;

        private DelegateCommand btnVolverCmd;
        #endregion

        #region PROPIEDADES
        public ClsCandidatoEdadModel Candidato 
        { 
            get 
            { 
                return candidato; 
            } 
            set 
            { 
                candidato = value;
                NotifyPropertyChanged(nameof(Candidato));
            } 
        }
        public DelegateCommand BtnVolverCmd { get { return btnVolverCmd; } }
        #endregion
        #region CONSTRUCTORES
        public DetallesCandidatosVM()
        {
            btnVolverCmd = new DelegateCommand(btnVolverCmdExecute);
        }
        #endregion

        #region FUNCIONES
        private async void btnVolverCmdExecute()
        {
            await Shell.Current.GoToAsync("///MainPage");
        }
        #endregion
    }
}
