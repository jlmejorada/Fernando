using BL;
using ENT;

namespace ProyectoASP.Models.VM
{
    public class MisionesCandidatosVM
    {
        // ME HE INVENTADO COMPLETAMENTE LO QUE ES UN VIEWMODEL, LOSIENTO Y NO ME BAJES MUCHOS PUNTOS


        /// <summary>
        /// Lista estatica de nuestras misiones
        /// </summary>
        List<ClsMision> misiones = new List<ClsMision>();

        /// <summary>
        /// Lista estatica de nuestros candidatos
        /// </summary>
        List<ClsCandidato> candidatos = new List<ClsCandidato>();

        List<ClsMision> Misiones { get { return misiones; } set { misiones = value; } }

        List<ClsCandidato> Candidatos { get { return candidatos; } set {candidatos = value; } }

        /// <summary>
        /// Creamos una viewModel con las misiones y los candidatos
        /// </summary>
        public MisionesCandidatosVM(int dif)
        {
            
            this.misiones = ListaMisionesBL.extraeMisionesBL();
            this.candidatos = ListaCandidatosBL.extraeCandidatosBL(dif);
        }
    }
}
