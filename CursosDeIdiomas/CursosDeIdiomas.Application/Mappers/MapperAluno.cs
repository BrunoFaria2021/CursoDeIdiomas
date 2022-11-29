using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Application.Interfaces.Mappers;
using CursosDeIdiomas.Domain;

namespace CursosDeIdiomas.Application.Mappers
{
    public class MapperAluno : IMapperAluno
    {
        IEnumerable<DtoAluno> dtoAlunos = new List<DtoAluno>();
        public Aluno MapperDtoToEntity(DtoAluno dtoAluno)
        {
            Aluno aluno = new Aluno()
            {
                Id = dtoAluno.Id,
                Cpf = dtoAluno.Cpf,
                Email = dtoAluno.Email,
                Nome = dtoAluno.Nome
            };
            return aluno;
        }

        public DtoAluno MapperEntityToDto(Aluno aluno)
        {
            DtoAluno dtoAluno = new DtoAluno()
            {
                Id = aluno.Id,
                Cpf = aluno.Cpf,
                Email = aluno.Email,
                Nome = aluno.Nome
            };
            return dtoAluno;
        }

        IEnumerable<DtoAluno> IMapperAluno.MapperListDtoAlunos(IEnumerable<Aluno> alunos)
        {
            IEnumerable<DtoAluno> dtoAlunos = alunos.Select(aluno => new DtoAluno
            {
                Id = aluno.Id,
                Cpf = aluno.Cpf,
                Email = aluno.Email,
                Nome = aluno.Nome

            });
            return dtoAlunos;
        }

    }
}
