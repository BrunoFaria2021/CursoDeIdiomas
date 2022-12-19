using CursosDeIdiomas.Domain.Entities;

namespace CursosDeIdiomas.Domain.core.Interfaces.Services
{
    public interface IServiceMatricula : IServiceBase<Matricula>
    {
        List<Matricula> GetTurmaId(int TurmaId);
    }
}
