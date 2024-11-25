using ENT;
using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL;

namespace CRUDAsp.Controllers
{
    public class PersonaController : Controller
    {
        // GET: PersonaControler
        public ActionResult Index()
        {
            List<ClsPersona> lista = new List<ClsPersona>();
            try
            {
                lista = ClsListadoBL.ListaPersonasBL();
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return View(lista);
        }

        // GET: PersonaControler/Details/5
        public ActionResult Details(int id)
        {
            ClsPersona persona = new ClsPersona();
            try
            {
                persona = ClsManejadoraBL.BuscaPersonaBL(id);
            }
            catch (Exception e)
            {
                return View("Error");
            }
            
            return View("Details", persona);
        }

        // GET: PersonaControler/Create
        public ActionResult Create()
        {
            return View("Create");
        }
        // POST: PersonaControler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClsPersona persona)
        {
            bool seCreo = false;
            try
            {
                seCreo=ClsManejadoraBL.CreaPersonaBL(persona);
                if (seCreo) { ViewBag.Mensaje = "Persona guardada correctamente"; } 
                else { ViewBag.Mensaje = "No se ha podido guardar la persona"; }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaControler/Edit/5
        public ActionResult Edit(int id)
        {
            ClsPersona persona = new ClsPersona();
            //TODO TRYCATCH
            //persona = ClsManejadoraBL.EditaPersonaBL
            return View("Edit", persona);
        }

        // POST: PersonaControler/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClsPersona persona)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaControler/Delete/5
        public ActionResult Delete(int id)
        {
            ClsPersona persona = new ClsPersona();
            //TODO TRYCATCH
            //persona = listadoPersonas.BuscaPersona(id);
            return View("Delete", persona);
        }

        // POST: PersonaControler/Delete/5
        [ActionName("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
