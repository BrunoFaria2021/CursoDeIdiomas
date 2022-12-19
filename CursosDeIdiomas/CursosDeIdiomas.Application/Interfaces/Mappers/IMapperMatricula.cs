using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Domain.Entities;

namespace CursosDeIdiomas.Application.Interfaces.Mappers
{
    public interface IMapperMatricula
    {
         
        Matricula MapperDtoToEntity(DtoMatricula dtoMatricula);
        IEnumerable<DtoMatricula> MapperListDtoMatriculas(IEnumerable<Matricula> matriculas);
        DtoMatricula MapperEntityToDto(Matricula matricula);
    }
}

