using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Domain.core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosDeIdiomas.Infra.Data.Repositories
{
    public class RepositoryTurma : RepositoryBase<Turma>, IRepositoryTurma
    {
        private readonly SqlContext sqlContext;
        public RepositoryTurma(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;   
        }
    }
}
