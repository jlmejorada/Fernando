﻿using BL;
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
        public List<ClsPersona> Get()
        {
            return ClsListadoPersonaBL.ListaPersonasBL();
        }

        // GET api/<PersonasController>/5
        [HttpGet("{id}")]
        public ClsPersona Get(int id)
        {
            return ClsManejadoraPersonaBL.BuscaPersonaBL(id);
        }

        // POST api/<PersonasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<PersonasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ClsManejadoraPersonaBL.BorraPersonaBL(id);
        }
    }
}
