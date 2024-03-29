﻿using CursosDeIdiomas.Application;
using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Application.Interfaces;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CursosDeIdiomas.Services.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly IApplicationServiceTurma applicationServiceTurma;

        public TurmaController(IApplicationServiceTurma applicationServiceTurma)
        {
            this.applicationServiceTurma = applicationServiceTurma;
        }

       
        [HttpGet]
        public ActionResult<IEnumerable<DtoTurma>> Get()
        {
            return Ok(applicationServiceTurma.GetAll());
        }

        
        [HttpGet("{id}")]
        public ActionResult<DtoTurma> Get(int id)
        {
            return Ok(applicationServiceTurma.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] DtoTurma dtoTurma)
        {
            try
            {
                if (dtoTurma == null)
                    return NotFound();

                applicationServiceTurma.Add(dtoTurma);
                return Ok(" Turma cadastrada com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
        [HttpPut]
        public ActionResult Put([FromBody] DtoTurma dtoTurma)
        {

            try
            {
                if (dtoTurma == null)
                    return NotFound();

                applicationServiceTurma.Update(dtoTurma);
                return Ok("A Turma foi atualizada com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete()]
        [Route("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var dtoTurma = applicationServiceTurma.GetById(id);


                if (dtoTurma == null)
                    return NotFound();

                applicationServiceTurma.Remove(dtoTurma);
                return Ok("Turma Removida com sucesso!");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}