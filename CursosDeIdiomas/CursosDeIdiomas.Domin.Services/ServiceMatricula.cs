using CursosDeIdiomas.Domain.core.Interfaces.Repositories;
using CursosDeIdiomas.Domain.core.Interfaces.Services;
using CursosDeIdiomas.Domain.Entities;

namespace CursosDeIdiomas.Domin.Services
{
    public class ServiceMatricula : ServiceBase<Matricula>, IServiceMatricula
    {
        private readonly IRepositoryMatricula repository;
        public ServiceMatricula(IRepositoryMatricula repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
