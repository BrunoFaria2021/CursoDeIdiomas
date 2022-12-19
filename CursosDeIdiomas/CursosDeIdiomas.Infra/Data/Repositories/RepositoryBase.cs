using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Domain.core.Interfaces.Repositories;
using CursosDeIdiomas.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CursosDeIdiomas.Infra.Data.Repositories
{
    public class RepositoryBase<TIntity> : IRepositoryBase<TIntity> where TIntity : Base
    {
        private readonly SqlContext sqlContext;
        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public TIntity Add(TIntity obj)
        {
            try
            {
                var tIntity = this.sqlContext.Set<TIntity>().Add(obj);
                this.sqlContext.SaveChanges();

                return tIntity.Entity;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public IEnumerable<TIntity> GetAll()
        {
            return this.sqlContext.Set<TIntity>().ToList();
        }

        public TIntity GetById(int id)
        {
            return sqlContext.Set<TIntity>()
                                 .Where(x => x.Id == id)
                                 .FirstOrDefault();
        }

        public void Remove(TIntity obj)
        {
            try
            {

                sqlContext.Entry(obj).State = EntityState.Deleted;
                this.sqlContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Update(TIntity obj)
        {
            try
            {
                //this.sqlContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                this.sqlContext.Set<TIntity>().Update(obj);
                this.sqlContext.SaveChanges();
            }

            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
