using CursosDeIdiomas.Application;
using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Application.Interfaces;
using CursosDeIdiomas.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CursosDeIdiomas.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {

        private readonly IApplicationServiceAluno ApplicationServiceAluno;


        public AlunoController(IApplicationServiceAluno applicationServiceAluno)
        {
            this.ApplicationServiceAluno = applicationServiceAluno;
        }
        
        [HttpGet]
        [Route("BuscarAlunos")]
        public ActionResult<IEnumerable<Aluno>> GetAll()
        {
            return Ok(ApplicationServiceAluno.GetAll());
        }

        
        [HttpGet("{id}")]
        public ActionResult<Aluno> Get(int id)
        {
            return Ok(ApplicationServiceAluno.GetById(id));
        }

        
        [HttpPost]
        public ActionResult Post([FromBody] DtoAluno dtoAluno)
        {
            try
            {
                if (dtoAluno == null)
                    return NotFound();

                ApplicationServiceAluno.Add(dtoAluno);
                return Ok("Aluno Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        [HttpPut]
        public ActionResult Put([FromBody] DtoAluno dtoAluno)
        {
            try
            {
                if (dtoAluno == null)
                    return NotFound();

                ApplicationServiceAluno.Update(dtoAluno);
                return Ok("Aluno Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        [HttpDelete()]
        public ActionResult Delete([FromBody] DtoAluno dtoAluno)
        {
            try
            {
                if (dtoAluno == null)
                    return NotFound();

                ApplicationServiceAluno.Remove(dtoAluno);
                return Ok("Aluno Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}