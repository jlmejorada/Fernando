using BL;
using ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiMaui.VM.Utils;

namespace UiMaui.VM
{
    [QueryProperty(nameof(Aciertos), "aciertos")]
    [QueryProperty(nameof(Errores), "errores")]
    [QueryProperty(nameof(Intentos), "intentos")]
    public  class JuegoVM
    {

        // Por un fallo en la listview no termina de ejecutar toda la aplicacion, tiene las funciones
        
        #region ATRIBUTOS
        private int respuestaCorr;
        private ObservableCollection<ClsCandidato> respuestasPos;
        private ClsCandidato respuestaSelec;
        private int intentos=0;
        private int aciertos=0;
        private int errores=0;
        private DelegateCommand btnEnviarCmd;
        private DelegateCommand btnReiniciarCmd;
        private string foto = "";
        #endregion

        #region PROPIEDADES
        public int RespuestaCorr
        {
            get
            {
                return respuestaCorr;
            }
            set
            {
                respuestaCorr = value;
            }
        }
        public ObservableCollection<ClsCandidato> RespuestasPos
        {
            get
            {
                return respuestasPos;
            }
            set
            {
                respuestasPos = value;
            }
        }
        public ClsCandidato RespuestaSelec
        {
            get
            {
                return respuestaSelec;
            }
            set
            {
                respuestaSelec = value;
            }
        }
        public int Intentos
        {
            get
            {
                return intentos;
            }
            set
            {
                intentos = value;
            }
        }
        public int Aciertos
        {
            get
            {
                return aciertos;
            }
            set
            {
                aciertos = value;
            }
        }
        public int Errores
        {
            get
            {
                return errores;
            }
            set
            {
                errores = value;
            }
        }
        public string Foto
        {
            get
            {
                return foto;
            }
            set
            {
                foto = value;
            }
        }
        public DelegateCommand BtnEnviarCmd { get { return btnEnviarCmd; } }
        public DelegateCommand BtnReiniciarCmd { get { return btnReiniciarCmd; } }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor del VM
        /// </summary>
        public JuegoVM()
        {
            int num = sacaRandom(0, 3);
            respuestasPos = respuestas();
            respuestaCorr = respuestasPos[num].Id;
            foto = "f" + respuestaCorr + "f.jfif";
            btnReiniciarCmd = new DelegateCommand(btnReiniarCmdExecute, btnReiniciarCmdCanExecute);
            btnEnviarCmd = new DelegateCommand(btnCompruebaRespuestaCmdExecute, btnEnviarCmdCanExecute);
        }
        #endregion

        #region FUNCIONES
        /// <summary>
        /// Funcion que saca un numero aleatorio entre numIn y numFi
        /// </summary>
        /// <returns>int</returns>
        public int sacaRandom(int numIn, int numFi)
        {
            int num = 0;
            Random rand = new Random();
            num = rand.Next(numIn, numFi);
            return num;
            
        }
        /// <summary>
        /// Saca 4 candidatos aleatorios
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<ClsCandidato> respuestas()
        {
            int aleatorio = 0;
            int cont = 0;
            List<int> num = new List<int>();
            ObservableCollection<ClsCandidato> lista = new ObservableCollection<ClsCandidato>();
            while (cont < 4) {
                aleatorio=sacaRandom(1,15);
                if (!num.Contains(aleatorio))
                {
                    num.Add(aleatorio);
                    lista.Add(BLManejadoraCandidatos.buscaCandidatoBL(aleatorio));
                    cont++;
                }
            }
            return lista;

        }
        private bool btnReiniciarCmdCanExecute()
        {
            bool estaSeleccionada = false;
            if (intentos == 5)
            {
                estaSeleccionada = true;
            }
            return estaSeleccionada;
        }
        private bool btnEnviarCmdCanExecute()
        {
            bool estaSeleccionada = false;
            if (intentos != 5)
            {
                estaSeleccionada = true;
            }
            return estaSeleccionada;
        }
        private async void btnReiniarCmdExecute()
        {
            var queryParams = new Dictionary<string, Object>
            {
                 {"fallos",  0},
                 {"aciertos", 0 },
                 {"intentos", 0 }
            };

            await Shell.Current.GoToAsync("///Juego", queryParams);
        }
        private async void btnCompruebaRespuestaCmdExecute()
        {
            ClsCandidato candidato = respuestaSelec;
            intentos++;
            if (candidato.Id==respuestaCorr)
            {
                aciertos++;
            }
            else
            {
                aciertos--;
            }
            var queryParams = new Dictionary<string, Object>
            {
                 {"fallos",  errores},
                 {"aciertos", aciertos },
                 {"intentos", intentos }
            };

            await Shell.Current.GoToAsync("///Juego", queryParams);
        }
        
        #endregion
    }
}
