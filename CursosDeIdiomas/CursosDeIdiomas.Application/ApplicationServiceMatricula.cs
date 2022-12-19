using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Application.Interfaces;
using CursosDeIdiomas.Application.Interfaces.Mappers;
using CursosDeIdiomas.Domain.core.Interfaces.Services;
using CursosDeIdiomas.Domain.Entities;
using System.Reflection.Metadata.Ecma335;

namespace CursosDeIdiomas.Application
{
    public class ApplicationServiceMatricula : IApplicationServiceMatricula
    {
        private readonly IServiceMatricula serviceMatricula;
        private readonly IServiceAluno serviceAluno;
        private readonly IServiceTurma serviceTurma;
        private readonly IMapperMatricula mapperMatricula;
        public ApplicationServiceMatricula(IServiceMatricula serviceMatricula, IServiceAluno serviceAluno, IServiceTurma serviceTurma, IMapperMatricula mapperMatricula)
        {
            this.serviceMatricula = serviceMatricula;
            this.serviceAluno = serviceAluno;
            this.serviceTurma = serviceTurma;
            this.mapperMatricula = mapperMatricula;
        }
        public void Add(DtoMatricula dtoMatricula)
        {
   
            var existeAluno = serviceAluno.GetById(dtoMatricula.AlunoId);
            if (existeAluno == null)
                throw new ArgumentException("esse aluno não existe");

            var existeTurma = serviceTurma.GetById(dtoMatricula.TurmaId);
            if (existeTurma == null)
                throw new ArgumentException("essa turma não existe");

            var quantidadeTurmas = serviceMatricula.GetTurmaId(dtoMatricula.TurmaId);
            if (quantidadeTurmas.Count >= 5)
                throw new ArgumentException("Não é possivel matricular mais alunos nessa turma!");


            Matricula matricula = this.mapperMatricula.MapperDtoToEntity(dtoMatricula);
            this.serviceMatricula.Add(matricula);
        }

        public IEnumerable<DtoMatricula> GetAll()
        {
            IEnumerable<Matricula> matriculas = this.serviceMatricula.GetAll();

            IEnumerable<DtoMatricula> dtoMatriculas = this.mapperMatricula.MapperListDtoMatriculas(matriculas);

            return dtoMatriculas;
        }

        public DtoMatricula GetById(int id)
        {
            Matricula matricula = this.serviceMatricula.GetById(id);
            DtoMatricula dtoMatricula = this.mapperMatricula.MapperEntityToDto(matricula);

            return dtoMatricula;
        }

        public void Remove(DtoMatricula dtoMatricula)
        {
            Matricula matricula = this.mapperMatricula.MapperDtoToEntity(dtoMatricula);
            this.serviceMatricula.Remove(matricula);
        }

        public void Update(DtoMatricula dtoMatricula)
        {
            Matricula matricula = this.mapperMatricula.MapperDtoToEntity(dtoMatricula);
            this.serviceMatricula.Update(matricula);
        }
    }
}
