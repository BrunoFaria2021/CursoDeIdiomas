using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Application.Interfaces;
using CursosDeIdiomas.Application.Interfaces.Mappers;
using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Domain.core.Interfaces.Services;

namespace CursosDeIdiomas.Application
{
    public class ApplicationServiceAluno : IApplicationServiceAluno
    {
        private readonly IServiceAluno serviceAluno;
        private readonly IMapperAluno mapperAluno;
        public ApplicationServiceAluno(IServiceAluno serviceAluno, IMapperAluno mapperAluno)
        {
            this.serviceAluno = serviceAluno;
            this.mapperAluno = mapperAluno;
        }
        public void Add(DtoAluno dtoAluno)
        {
            Aluno aluno = this.mapperAluno.MapperDtoToEntity(dtoAluno);
            this.serviceAluno.Add(aluno);

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
