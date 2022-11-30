using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Application.Interfaces;
using CursosDeIdiomas.Application.Interfaces.Mappers;
using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Domain.core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosDeIdiomas.Application
{
    public class ApplicationServiceTurma : IApplicationServiceTurma
    {
        private readonly IServiceTurma serviceTurma;
        private readonly IMapperTurma mapperTurma;
        public ApplicationServiceTurma(IServiceTurma serviceTurma, IMapperTurma mapperTurma)
        {
            this.serviceTurma = serviceTurma;
            this.mapperTurma = mapperTurma;
        }

        public void Add(DtoTurma dtoTurma)
        {
            Turma turma = this.mapperTurma.MapperDtoToEntity(dtoTurma);
            this.serviceTurma.Add(turma);
        }

        public IEnumerable<DtoTurma> GetAll()
        {
            IEnumerable<Turma> turmas = this.serviceTurma.GetAll();
            IEnumerable<DtoTurma> dtoTurmas = this.mapperTurma.MapperListDtoTurmas(turmas);

            return dtoTurmas;
        }

        public DtoTurma GetById(int id)
        {
            Turma turma = this.serviceTurma.GetById(id);
            DtoTurma dtoTurma = this.mapperTurma.MapperEntityToDto(turma);

            return dtoTurma;
        }

        public void Remove(DtoTurma dtoTurma)
        {
            Turma turma = this.mapperTurma.MapperDtoToEntity(dtoTurma);
            this.serviceTurma.Remove(turma);
        }

        public void Update(DtoTurma dtoTurma)
        {
            Turma turma = this.mapperTurma.MapperDtoToEntity(dtoTurma);
            this.serviceTurma.Update(turma);
        }
    }
}
