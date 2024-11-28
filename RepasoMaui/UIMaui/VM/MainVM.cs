using BL;
using ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIMaui.Model;
using UIMaui.VM.Util;

namespace UIMaui.VM
{
    public class MainVM : clsVMBase
    {
        #region ATRIBUTOS
        private List<ClsMision> listaMisiones;
        private ClsMision misionSelec;
        private ClsCandidatoEdadModel canSelec;
        private ObservableCollection<ClsCandidatoEdadModel> listaCandidatos = new ObservableCollection<ClsCandidatoEdadModel>();
        private DelegateCommand btnVerCanCmd;
        private DelegateCommand btnDetallesCmd;
        #endregion
        #region PROPIEDADES
        public List<ClsMision> ListaMisiones
        {
            get { return listaMisiones; } set { listaMisiones = value; }
        }
        public ClsMision MisionSelec 
        { 
            get 
            { 
                return misionSelec; 
            } 
            set 
            { 
                misionSelec = value;

                btnVerCanCmd.RaiseCanExecuteChanged();
            } 
        }
        public ClsCandidatoEdadModel CanSelec
        {
            get
            {
                return canSelec;
            }
            set
            {
                canSelec = value;
                NotifyPropertyChanged(nameof(CanSelec));

                btnDetallesCmd.RaiseCanExecuteChanged();
            }
        }
        public ObservableCollection<ClsCandidatoEdadModel> ListaCandidatos 
        { 
            get 
            { 
                return listaCandidatos; 
            } 
            set 
            { 
                listaCandidatos = value;

                NotifyPropertyChanged(nameof(ListaCandidatos));
            } 
        }
        public DelegateCommand BtnVerCanCmd { get { return btnVerCanCmd; } }
        public DelegateCommand BtnDetallesCmd { get { return btnDetallesCmd; } }
        #endregion
        #region CONSTRUCTORES
        public MainVM()
        {
            this.listaMisiones = BL.BLListaMisiones.sacaMisionesBL();
            btnVerCanCmd = new DelegateCommand(btnVerCanCmdExecute, btnVerCanCmdCanExecute);
            btnDetallesCmd = new DelegateCommand(btnDetallesCmdExecute, btnDetallesCmdCanExecute);
        }

        #endregion

        #region FUNCIONES
        private bool btnVerCanCmdCanExecute()
        {
            bool estaSeleccionada = false;
            if (misionSelec != null)
            {
                estaSeleccionada = true;
            }
            return estaSeleccionada;
        }
        
        private bool btnDetallesCmdCanExecute()
        {
            bool estaSeleccionada = false;
            if (canSelec != null)
            {
                estaSeleccionada = true;
            }
            return estaSeleccionada;
        }
        private void btnVerCanCmdExecute()
        {
            ClsMision mision = misionSelec;
            List<ClsCandidato> candidatos = BLListaCandidatos.listaCandidatosFiltrados(mision.Dificultad);
            this.listaCandidatos.Clear();
            foreach (ClsCandidato can in candidatos){
                this.listaCandidatos.Add(new ClsCandidatoEdadModel(can));
            }
        }
        private async void btnDetallesCmdExecute()
        {
            ClsCandidatoEdadModel candidato = canSelec;
            var queryParams = new Dictionary<string, Object>
            {
                 {"candidato",  candidato}
            };

            await Shell.Current.GoToAsync("///detallesCandidatos", queryParams);
        }
        #endregion

    }
}
