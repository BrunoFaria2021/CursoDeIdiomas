using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Domain;

namespace CursosDeIdiomas.Application.Mappers
{
    public interface IMapperTurma
    {
        Turma MapperDtoToEntity(DtoTurma dtoturma);
        IEnumerable<DtoTurma> MapperListDtoTurmas(IEnumerable<Turma> turmas);
        DtoTurma MapperEntityToDto(Turma turma);
    }
}
