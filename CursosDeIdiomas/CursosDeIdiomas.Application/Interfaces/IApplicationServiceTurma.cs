using CursosDeIdiomas.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosDeIdiomas.Application.Interfaces
{
    public interface IApplicationServiceTurma
    {
        public void Add(DtoTurma dtoTurma);
        public void Update(DtoTurma dtoTurma);
        public void Remove(DtoTurma dtoTurma);
        public IEnumerable<DtoTurma> GetAll();
        public DtoTurma GetById(int id);
    }
}
