﻿using CursosDeIdiomas.Domain;
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

        public Matricula GetByAlunoIdAndTurmaId(int alunoId, int turmaId)
        {
            return sqlContext.Matriculas.Where(m => m.AlunoId == alunoId && m.TurmaId == turmaId).FirstOrDefault();
        }


        public List<Matricula> GetTurmaId(int TurmaId)
        {
            return sqlContext.Matriculas
                                .Where(t => t.TurmaId == TurmaId)
                                .ToList();
        }
       
    }
}

