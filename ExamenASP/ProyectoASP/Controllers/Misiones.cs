using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ENT;
using BL;
using DAL;
using ProyectoASP.Models.VM;

namespace ProyectoASP.Controllers
{
    public class Misiones : Controller
    {
        // GET: Misiones
        public ActionResult Index()
        {
            List<ClsMision> lista = new List<ClsMision>();
            try
            {
                lista = ListaMisionesBL.extraeMisionesBL();
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return View(lista);
        }

        public ActionResult IndexCa(int dif)
        {
            // Esto ha sido una inventada tambien

            MisionesCandidatosVM viewmodel = new MisionesCandidatosVM(dif);

            return View(viewmodel);
        }

        public ActionResult Candidato(int id)
        {
            //No se si hay forma de que accedas a esto
            ClsCandidato can = new ClsCandidato();
            try
            {
                can = ManejadoraBL.seleccionaCandidatoBL(id);
            }
            catch (Exception ex)
            {
                return View("Error");
            }

            return View(can);
        }
    }
}
