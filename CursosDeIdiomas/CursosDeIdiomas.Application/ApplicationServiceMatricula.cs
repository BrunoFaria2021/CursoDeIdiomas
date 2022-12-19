using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Application.Interfaces;
using CursosDeIdiomas.Application.Interfaces.Mappers;
using CursosDeIdiomas.Application.Mappers;
using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Domain.core.Interfaces.Services;
using CursosDeIdiomas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosDeIdiomas.Application
{
    public class ApplicationServiceMatricula : IApplicationServiceMatricula
    {
        private readonly IServiceMatricula serviceMatricula;
        private readonly IMapperMatricula mapperMatricula;
        public ApplicationServiceMatricula(IServiceMatricula serviceMatricula, IMapperMatricula mapperMatricula)
        {
            this.serviceMatricula = serviceMatricula;
            this.mapperMatricula = mapperMatricula;
        }
        public void Add(DtoMatricula dtoMatricula)

        {
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
