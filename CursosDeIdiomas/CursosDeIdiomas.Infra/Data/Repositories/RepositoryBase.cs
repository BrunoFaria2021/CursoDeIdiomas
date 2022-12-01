using CursosDeIdiomas.Domain.core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CursosDeIdiomas.Infra.Data.Repositories
{
    public class RepositoryBase<TIntity> : IRepositoryBase<TIntity> where TIntity : class
    {
        private readonly SqlContext sqlContext;
        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public void Add(TIntity obj)
        {
            try
            {
                this.sqlContext.Set<TIntity>().Add(obj);
                this.sqlContext.SaveChanges();

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
            return this.sqlContext.Set<TIntity>().FirstOrDefault();
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
