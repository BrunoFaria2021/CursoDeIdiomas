using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Application.Interfaces.Mappers;
using CursosDeIdiomas.Domain.Entities;

namespace CursosDeIdiomas.Application.Mappers
{
    public class MapperMatricula : IMapperMatricula
    {
        //IEnumerable<DtoMatricula> dtoMatriculas = new List<DtoMatricula>();

        public Matricula MapperDtoToEntity(DtoMatricula dtoMatricula)
        {
            Matricula matricula = new Matricula()
            {
                Id = dtoMatricula.Id,
                AlunoId = dtoMatricula.AlunoId,
                TurmaId= dtoMatricula.TurmaId,
            };

            return matricula;

        }
                  
        public DtoMatricula MapperEntityToDto(Matricula matricula)
        {
            DtoMatricula dtoMatricula = new DtoMatricula()
            {
                Id = matricula.Id,
                AlunoId = matricula.AlunoId,
                TurmaId = matricula.TurmaId,

            };
            return dtoMatricula;
        }

        public IEnumerable<DtoMatricula> MapperListDtoMatriculas(IEnumerable<Matricula> matriculas)
        {
            IEnumerable<DtoMatricula> dtoMatriculas = matriculas.Select(matricula => new DtoMatricula
            {
                Id = matricula.Id,
                AlunoId = matricula.AlunoId,
                TurmaId = matricula.TurmaId,

            });
            return dtoMatriculas;
        }
    }
}

