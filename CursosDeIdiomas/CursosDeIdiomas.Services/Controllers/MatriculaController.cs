using CursosDeIdiomas.Application;
using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Application.Interfaces;
using CursosDeIdiomas.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CursosDeIdiomas.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatriculaController : ControllerBase
    {

        private readonly IApplicationServiceMatricula ApplicationServiceMatricula;


        public MatriculaController(IApplicationServiceMatricula applicationServiceMatricula)
        {
            this.ApplicationServiceMatricula = applicationServiceMatricula;
        }

        [HttpGet]
        [Route("BuscarMatricula")]
        public ActionResult<IEnumerable<Matricula>> GetAll()
        {
            return Ok(ApplicationServiceMatricula.GetAll());
        }


        [HttpGet("{id}")]
        public ActionResult<Matricula> Get(int id)
        {
            return Ok(ApplicationServiceMatricula.GetById(id));
        }


        [HttpPost]
        public ActionResult Post([FromBody] DtoMatricula dtoMatricula)
        {
            try
            {
                if (dtoMatricula == null)
                    return NotFound();

                ApplicationServiceMatricula.Add(dtoMatricula);
                return Ok("Matricula Adcionada com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        [HttpPut]
        public ActionResult Put([FromBody] DtoMatricula dtoMatricula)
        {
            try
            {
                if (dtoMatricula == null)
                    return NotFound();

                ApplicationServiceMatricula.Update(dtoMatricula);
                return Ok("Matricula Atualizada com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpDelete()]
        [Route("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var dtoMatricula = ApplicationServiceMatricula.GetById(id);

                if (dtoMatricula == null)
                    return NotFound();

                ApplicationServiceMatricula.Remove(dtoMatricula);
                return Ok("Matricula Removida com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}