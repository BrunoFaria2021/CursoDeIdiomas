using CursosDeIdiomas.Application.Dtos;

namespace CursosDeIdiomas.Application.Interfaces
{
    public interface IApplicationServiceAluno
    {
        public void Add(DtoAluno dtoAluno);
        public void Update(DtoAluno dtoAluno);
        public void Remove(DtoAluno dtoAluno);
        public IEnumerable<DtoAluno> GetAll();
        public DtoAluno GetById(int id);
    }
}
