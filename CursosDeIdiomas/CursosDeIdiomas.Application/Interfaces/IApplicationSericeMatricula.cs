using CursosDeIdiomas.Application.Dtos;

namespace CursosDeIdiomas.Application.Interfaces
{
    public interface IApplicationServiceMatricula
    {
        public void Add(DtoMatricula dtoMatricula);
        public void Update(DtoMatricula dtoMatricula);
        public void Remove(DtoMatricula dtoMatricula);
        public IEnumerable<DtoMatricula> GetAll();
        public DtoMatricula GetById(int id);
    }
}
