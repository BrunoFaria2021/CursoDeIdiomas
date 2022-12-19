
namespace CursosDeIdiomas.Domain.core.Interfaces.Services
{
    public interface IServiceAluno : IServiceBase<Aluno>
    {
        Aluno GetAlunoByCpf(Aluno aluno);
    }
}
