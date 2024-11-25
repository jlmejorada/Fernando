using BL;
using DAL;
using ENT;

namespace CRUDAsp.Models.VM
{
    public class ClsPersonaConDepartamentosVM : ClsPersona
    {

        public ClsPersona persona = new ClsPersona();
        public List<ClsDepartamento> departamentos = ClsListadoDepartamentoBL.ListaDepartamentosBL();
    }
}
