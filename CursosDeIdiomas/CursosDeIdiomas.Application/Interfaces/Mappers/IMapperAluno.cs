using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Domain;

namespace CursosDeIdiomas.Application.Interfaces.Mappers
{
    public interface IMapperAluno
    {
        Aluno MapperDtoToEntity(DtoAluno dtoAluno);
        IEnumerable<DtoAluno> MapperListDtoAlunos(IEnumerable<Aluno> alunos);
        DtoAluno MapperEntityToDto(Aluno aluno);
    }
}
