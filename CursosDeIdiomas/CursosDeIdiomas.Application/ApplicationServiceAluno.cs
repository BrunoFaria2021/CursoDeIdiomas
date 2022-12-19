using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Application.Interfaces;
using CursosDeIdiomas.Application.Interfaces.Mappers;
using CursosDeIdiomas.Application.Mappers;
using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Domain.core.Interfaces.Services;
using CursosDeIdiomas.Domain.Entities;

namespace CursosDeIdiomas.Application
{
    public class ApplicationServiceAluno : IApplicationServiceAluno
    {
        private readonly IServiceAluno serviceAluno;
        private readonly IMapperAluno mapperAluno;
        private readonly IMapperMatricula mapperMatricula;
        private readonly IServiceMatricula serviceMatricula;
        private readonly IServiceTurma serviceTurma;
        public ApplicationServiceAluno(IServiceAluno serviceAluno, IMapperAluno mapperAluno, IMapperMatricula mapperMatricula, IServiceMatricula serviceMatricula, IServiceTurma serviceTurma)
        {
            this.serviceAluno = serviceAluno;
            this.mapperAluno = mapperAluno;
            this.mapperMatricula = mapperMatricula;
            this.serviceMatricula = serviceMatricula;
            this.serviceTurma = serviceTurma;
        }
        public void Add(DtoAlunoAdicionar dtoAluno)
        {
            Aluno aluno = this.mapperAluno.MapperDtoAddToEntity(dtoAluno);

            var existeAluno = serviceAluno.GetAlunoByCpf(aluno);
            if (existeAluno != null)
                throw new ArgumentException("Já existe aluno com esse CPF");

            var alunoCriado = this.serviceAluno.Add(aluno);

            var dtoMatricula = new DtoMatricula()
            {
                TurmaId = dtoAluno.TurmaId,
                AlunoId = alunoCriado.Id,
            };

            Matricula matricula = this.mapperMatricula.MapperDtoToEntity(dtoMatricula);

            serviceMatricula.Add(matricula);

        }

        public IEnumerable<DtoAluno> GetAll()
        {

            IEnumerable<Aluno> alunos = this.serviceAluno.GetAll();
            IEnumerable<DtoAluno> dtoAlunos = this.mapperAluno.MapperListDtoAlunos(alunos);

            return dtoAlunos;
        }

        public DtoAluno GetById(int id)
        {
            Aluno aluno = this.serviceAluno.GetById(id);
            DtoAluno dtoAluno = this.mapperAluno.MapperEntityToDto(aluno);

            return dtoAluno;
        }

        public void Remove(DtoAluno dtoAluno)
        {
            Aluno aluno = this.mapperAluno.MapperDtoToEntity(dtoAluno);
            this.serviceAluno.Remove(aluno);
        }

        public void Update(DtoAluno dtoAluno)
        {
            Aluno aluno = this.mapperAluno.MapperDtoToEntity(dtoAluno);
            this.serviceAluno.Update(aluno);


        }
    }
}
