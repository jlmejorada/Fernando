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
    public class ClsPersonaConDepartamentosVM : clsVMBase
    {
        #region ATRIBUTOS
        private List<ClsDepartamento> departamentos;
        private ClsPersonaNombreDepartamento persona;
        private DelegateCommand btnVolverCmd;
        private DelegateCommand btnGuardarCmd;
        private ClsDepartamento dep;
        #endregion

        #region PROPIEDADES
        public List<ClsDepartamento> Departamentos
        {
            get
            {
                return departamentos;
            }
        }
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
            this.persona.Id = persona.Id;
            this.persona.Nombre = persona.Nombre;
            this.persona.Apellidos = persona.Apellidos;
            this.persona.Telefono = persona.Telefono;
            this.persona.Direccion = persona.Direccion;
            this.persona.Foto = persona.Foto;
            this.persona.FechaNacimiento = persona.FechaNacimiento;
            this.persona.IDDepartamento = persona.IDDepartamento;
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
            //NOSE COMO CAMBIA LA OBSERVABLE COLLECTION
            await Shell.Current.GoToAsync("///listaPersona");
        }
        #endregion
    }
}
