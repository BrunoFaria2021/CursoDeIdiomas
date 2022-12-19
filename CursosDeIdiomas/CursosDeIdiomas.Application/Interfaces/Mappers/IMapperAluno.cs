using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Domain;

namespace CursosDeIdiomas.Application.Mappers
{
    public interface IMapperAluno
    {
        Aluno MapperDtoToEntity(DtoAluno dtoAluno);
        Aluno MapperDtoAddToEntity(DtoAlunoAdicionar dtoAluno);
        IEnumerable<DtoAluno> MapperListDtoAlunos(IEnumerable<Aluno> alunos);
        DtoAluno MapperEntityToDto(Aluno aluno);
    }
}
