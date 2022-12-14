namespace CursosDeIdiomas.Domain.core.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {

        TEntity Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
