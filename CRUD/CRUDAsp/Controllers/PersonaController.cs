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
            List<ClsPersonaNombreDepartamento> lista;
            ClsListadoPersonasNombreDepartamentoVM vm = new ClsListadoPersonasNombreDepartamentoVM();
            try
            {
                lista = vm.Lista;
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
            return View(vm);
        }
        // POST: PersonaControler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClsPersona persona)
        {
            try
            {
                ClsManejadoraPersonaBL.CreaPersonaBL(persona);
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
            ClsPersona persona;
            ClsPersonaConDepartamentosVM vm;
            try
            {
                persona = ClsManejadoraPersonaBL.BuscaPersonaBL(id);
                vm = new ClsPersonaConDepartamentosVM(persona);
            }
            catch (Exception e)
            {
                return View("Error");
            }
            return View("Edit", vm);
        }

        // POST: PersonaControler/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClsPersona persona)
        {
            bool seCreo = false;
            try
            {
                ClsManejadoraPersonaBL.EditaPersonaBL(persona);
                ViewBag.Mensaje = "Persona guardada correctamente";

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Mensaje = "No se ha podido guardar la persona";
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: PersonaControler/Delete/5
        public ActionResult Delete(int id)
        {
            ClsPersona persona;
            ClsPersonaNombreDepartamento personaConDep;
            List<ClsDepartamento> lista;
            try
            {
                lista = ClsListadoDepartamentoBL.ListaDepartamentosBL();
                persona = ClsManejadoraPersonaBL.BuscaPersonaBL(id);
                personaConDep = new ClsPersonaNombreDepartamento(persona, lista);
            }
            catch
            {
                return View("Error");
            }
            return View("Delete", personaConDep);
        }

        // POST: PersonaControler/Delete/5
        [ActionName("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            bool seBorra = false;
            try
            {
                seBorra = ClsManejadoraPersonaBL.BorraPersonaBL(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
