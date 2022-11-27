using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Domain.core.Interfaces.Repositories;
using CursosDeIdiomas.Domain.core.Interfaces.Services;

namespace CursosDeIdiomas.Domin.Services
{
    public class ServiceTurma : ServiceBase<Turma>, IServiceTurma
    {
        private readonly IRepositoryTurma repository;
        public ServiceTurma(IRepositoryTurma repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
