
namespace CursosDeIdiomas.Domain.core.Interfaces.Repositories
{
    public interface IRepositoryAluno : IRepositoryBase<Aluno>
    {
        Aluno GetAlunoByCPF(Aluno aluno);
    }
}
