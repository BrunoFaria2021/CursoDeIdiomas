using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Domain;

namespace CursosDeIdiomas.Infra.CrossCutting.Interfaces
{
    public interface IMapperAluno
    {
        Aluno MapperDtoToEntity(DtoAluno dtoAluno);
        IEnumerable<DtoAluno> MapperListDtoAlunos(IEnumerable<Aluno> alunos);
        DtoAluno MapperEntityToDto(Aluno aluno);
    }
}