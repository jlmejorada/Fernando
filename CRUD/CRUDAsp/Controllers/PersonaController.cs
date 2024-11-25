using ENT;
using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL;
using CRUDAsp.Models.VM;
using CRUDAsp.Models;

namespace CRUDAsp.Controllers
{
    public class PersonaController : Controller
    {
        // GET: PersonaControler
        public ActionResult Index()
        {
            List<ClsPersonaNombreDepartamento> listaPersonaDept = new List<ClsPersonaNombreDepartamento>();
            try
            {
                List<ClsPersona> personas = ClsListadoPersonaBL.ListaPersonasBL();

                List<ClsDepartamento> departamentos = ClsListadoDepartamentoBL.ListaDepartamentosBL();

                foreach (ClsPersona persona in personas)
                {
                    listaPersonaDept.Add(new ClsPersonaNombreDepartamento(persona, departamentos));
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return View(listaPersonaDept);
        }

        // GET: PersonaControler/Details/5
        public ActionResult Details(int id)
        {
            ClsPersona persona = new ClsPersona();
            List<ClsDepartamento> departamentos = new List<ClsDepartamento>();
            ClsPersonaNombreDepartamento personaDept = new ClsPersonaNombreDepartamento();
            try
            {
                persona = ClsManejadoraPersonaBL.BuscaPersonaBL(id);
                departamentos = ClsListadoDepartamentoBL.ListaDepartamentosBL();
                personaDept = new ClsPersonaNombreDepartamento(persona, departamentos);
            }
            catch (Exception e)
            {
                return View("Error");
            }
            
            return View("Details", personaDept);
        }

        // GET: PersonaControler/Create
        public ActionResult Create()
        {
            ClsPersonaConDepartamentosVM vm;
            try
            {
                vm = new ClsPersonaConDepartamentosVM();
            }
            catch (Exception e)
            {
                return View("Error");
            }
            return View("Create", vm);
        }
        // POST: PersonaControler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClsPersona persona)
        {
            bool seCreo = false;
            try
            {
                seCreo = ClsManejadoraPersonaBL.CreaPersonaBL(persona);
                if (seCreo) { ViewBag.Mensaje = "Persona guardada correctamente"; }
                else { ViewBag.Mensaje = "No se ha podido guardar la persona"; }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Index");
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
