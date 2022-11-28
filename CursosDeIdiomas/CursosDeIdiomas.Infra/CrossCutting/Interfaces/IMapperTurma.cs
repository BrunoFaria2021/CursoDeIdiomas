using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosDeIdiomas.Infra.CrossCutting.Interfaces
{
    public interface IMapperTurma
    {
        Turma MapperDtoToEntity(DtoTurma dtoturma);
        IEnumerable<DtoTurma> MapperListDtoTurmas(IEnumerable<Turma> turmas);
        DtoTurma MapperEntityToDto(Turma turma);
    }
}
