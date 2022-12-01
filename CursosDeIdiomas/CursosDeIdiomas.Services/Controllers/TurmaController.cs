using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Application.Interfaces;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;

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

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceTurma.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceTurma.GetById(id));
        }

        // POST api/values
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

                throw ex;
            }
        }

        // PUT api/values/5
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

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] DtoTurma dtoTurma)
        {
            try
            {
                if (dtoTurma == null)
                    return NotFound();

                applicationServiceTurma.Remove(dtoTurma);
                return Ok(" Turma Removida  com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
