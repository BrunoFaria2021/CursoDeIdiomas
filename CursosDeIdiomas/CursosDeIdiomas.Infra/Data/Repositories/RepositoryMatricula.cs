using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Domain.core.Interfaces.Repositories;
using CursosDeIdiomas.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CursosDeIdiomas.Infra.Data.Repositories
{
    public class RepositoryMatricula : RepositoryBase<Matricula>, IRepositoryMatricula
    {
        private readonly SqlContext sqlContext;
        public RepositoryMatricula(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public List<Matricula> GetTurmaId(int TurmaId)
        {
            return sqlContext.Matriculas
                                .Where(t => t.TurmaId == TurmaId)
                                .ToList();
        }
    }
}

