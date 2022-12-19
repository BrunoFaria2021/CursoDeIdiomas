using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Application.Interfaces;
using CursosDeIdiomas.Application.Mappers;
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
        private readonly IServiceMatricula serviceMatricula;
        private readonly IMapperTurma mapperTurma;
        public ApplicationServiceTurma(IServiceTurma serviceTurma,IServiceMatricula serviceMatricula, IMapperTurma mapperTurma)
        {
            this.serviceTurma = serviceTurma;
            this.mapperTurma = mapperTurma;
            this.serviceMatricula = serviceMatricula;
        }

        public void Add(DtoTurma dtoTurma)
        {
            if (dtoTurma.Numero.Length > 5)
                throw new ArgumentException("O numero da turma deve ser um número e menor que 5 caracteres");

            if (dtoTurma.AnoLetivo.Length > 4)
                throw new ArgumentException("O ano letivo deve ser um número e menor que 4 caracteres");

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
            var existeAluno = this.serviceMatricula.GetTurmaId(dtoTurma.Id);
            if (existeAluno.Count > 0)
                throw  new ArgumentException("Não e possivel excluir turma, quando se tem pelo menos um aluno matriculado!");

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
