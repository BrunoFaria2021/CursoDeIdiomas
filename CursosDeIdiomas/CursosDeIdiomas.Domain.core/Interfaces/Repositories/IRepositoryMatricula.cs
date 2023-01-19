using CursosDeIdiomas.Domain.Entities;

namespace CursosDeIdiomas.Domain.core.Interfaces.Repositories
{
    public interface IRepositoryMatricula : IRepositoryBase<Matricula>
    {
        List<Matricula> GetTurmaId(int TurmaId);
        Matricula GetByAlunoIdAndTurmaId(int alunoId, int turmaId);

    }

}
