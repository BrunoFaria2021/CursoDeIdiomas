using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Domain.core.Interfaces.Repositories;
using CursosDeIdiomas.Domain.core.Interfaces.Services;

namespace CursosDeIdiomas.Domin.Services
{
    public class ServiceAluno : ServiceBase<Aluno>, IServiceAluno
    {
        private readonly IRepositoryAluno repository;
        public ServiceAluno(IRepositoryAluno repository) : base(repository)
        {
            this.repository = repository;
        }

        public Aluno GetAlunoByCpf(Aluno Aluno)
        {
           return this.repository.GetAlunoByCPF(Aluno);
        }
    }
}
