using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Domain;

namespace CursosDeIdiomas.Application.Mappers
{
    public class MapperTurma : IMapperTurma
    {
        IEnumerable<DtoTurma> dtoTurmas = new List<DtoTurma>();
        public Turma MapperDtoToEntity(DtoTurma dtoturma)
        {
            Turma turma = new Turma()
            {
                AnoLetivo = dtoturma.AnoLetivo,
                Id = dtoturma.Id,
                Numero = dtoturma.Numero,
            };
            return turma;
        }

        public DtoTurma MapperEntityToDto(Turma turma)
        {
            DtoTurma dtoTurma = new DtoTurma()
            {
                AnoLetivo = turma.AnoLetivo,
                Id = turma.Id,
                Numero = turma.Numero,
            };
            return dtoTurma;

        }

        public IEnumerable<DtoTurma> MapperListDtoTurmas(IEnumerable<Turma> turmas)
        {
            IEnumerable<DtoTurma> dtoTurmas = turmas.Select(turma => new DtoTurma
            {
                AnoLetivo = turma.AnoLetivo,
                Id = turma.Id,
                Numero = turma.Numero,
            });
            return dtoTurmas;
        }
    }
}
