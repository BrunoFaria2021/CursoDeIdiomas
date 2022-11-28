using CursosDeIdiomas.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
