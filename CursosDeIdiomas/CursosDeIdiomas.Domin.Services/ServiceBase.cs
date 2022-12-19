using CursosDeIdiomas.Domain.core.Interfaces.Repositories;
using CursosDeIdiomas.Domain.core.Interfaces.Services;

namespace CursosDeIdiomas.Domin.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public TEntity Add(TEntity obj)
        {
           return this.repository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return this.repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            this.repository.Update(obj);
        }
    }
}
