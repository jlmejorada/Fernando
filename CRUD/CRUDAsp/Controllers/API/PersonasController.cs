using BL;
using DAL;
using ENT;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUDAsp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        // GET: api/<PersonasController>
        [HttpGet]
        public IActionResult Get()
        {
            IActionResult salida;
            List<ClsPersona> listadoCompleto = new List<ClsPersona>();
            try
            {
                listadoCompleto = ClsListadoPersonaBL.ListaPersonasBL();
                if (listadoCompleto.Count() == 0)
                {
                    salida = NoContent();
                }
                else
                {
                    salida = Ok(listadoCompleto);
                }
            }
            catch
            {
                salida = BadRequest();
            }
            return salida;
        }

        // GET api/<PersonasController>/5
        [HttpGet("{id}")]
        public ClsPersona Get(int id)
        {
            IActionResult salida;
            ClsPersona persona = new ClsPersona();
            try
            {
                persona = ClsManejadoraPersonaBL.BuscaPersonaBL(id);
                if (persona != null)
                {
                    salida = NoContent();
                }
                else
                {
                    salida = Ok(persona);
                }
            }
            catch
            {
                salida = BadRequest();
            }
            return persona;
        }

        // POST api/<PersonasController>
        [HttpPost]
        public IActionResult Post([FromBody] ClsPersona persona)
        {
            bool guardadoCorrectamente;
            IActionResult salida;
            if (persona != null)
            {
                try
                {
                    guardadoCorrectamente = ClsManejadoraPersonaBL.CreaPersonaBL(persona);
                    salida = Ok(guardadoCorrectamente);
                }
                catch
                {
                    salida = BadRequest();
                }
            }
            else
            {
                salida = NoContent();
            }
            
            return salida;
        }

        // PUT api/<PersonasController>/
        [HttpPut]
        public IActionResult Put(ClsPersona persona)
        {
            bool guardadoCorrectamente;
            IActionResult salida;
            if (persona != null)
            {
                try
                {
                    guardadoCorrectamente = ClsManejadoraPersonaBL.EditaPersonaBL(persona);
                    salida = Ok(guardadoCorrectamente);
                }
                catch
                {
                    salida = BadRequest();
                }
            }
            else
            {
                salida = NoContent();
            }

            return salida;
        }

        // DELETE api/<PersonasController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            IActionResult salida;
            bool seBorra;
            try
            {
                seBorra = ClsManejadoraPersonaBL.BorraPersonaBL(id);
                if (seBorra == false)
                {
                    salida = NotFound();
                }
                else
                {
                    salida = Ok();
                }
            }
            catch (Exception e)
            {
                salida = BadRequest();
            }

            return salida;

        }
    }
}
