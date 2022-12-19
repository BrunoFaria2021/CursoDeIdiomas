using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Domain.core.Interfaces.Repositories;

namespace CursosDeIdiomas.Infra.Data.Repositories
{
    public class RepositoryAluno : RepositoryBase<Aluno>, IRepositoryAluno
    {
        private readonly SqlContext sqlContext;
        public RepositoryAluno(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public Aluno GetAlunoByCPF(Aluno aluno)
        {
            return sqlContext.Alunos
                                .Where(a => a.Cpf == aluno.Cpf)
                                .FirstOrDefault();
        }
    }
}