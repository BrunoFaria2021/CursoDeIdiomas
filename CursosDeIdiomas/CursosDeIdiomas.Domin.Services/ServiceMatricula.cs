using CursosDeIdiomas.Domain;
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

        public Matricula GetByAlunoIdAndTurmaId(int alunoId, int turmaId)
        {
            return this.repository.GetByAlunoIdAndTurmaId(alunoId, turmaId);
        }

        public List<Matricula> GetTurmaId(int TurmaId)
        {
            return this.repository.GetTurmaId(TurmaId);
        }
    }
}
