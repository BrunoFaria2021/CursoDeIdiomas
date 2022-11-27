using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Domain.core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosDeIdiomas.Infra.Data.Repositories
{
    public class RepositoryAluno : RepositoryBase<Aluno>, IRepositoryAluno
    {
        private readonly SqlContext sqlContext;
        public RepositoryAluno(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}