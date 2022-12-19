using CursosDeIdiomas.Domain.core.Interfaces.Repositories;
using CursosDeIdiomas.Domain.Entities;

namespace CursosDeIdiomas.Infra.Data.Repositories
{
    public class RepositoryMatricula : RepositoryBase<Matricula>, IRepositoryMatricula
    {
        private readonly SqlContext sqlContext;
        public RepositoryMatricula(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}

