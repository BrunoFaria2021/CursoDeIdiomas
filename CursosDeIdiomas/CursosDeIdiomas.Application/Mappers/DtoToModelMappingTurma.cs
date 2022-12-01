using AutoMapper;
using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Domain;

namespace CursosDeIdiomas.Application.Mappers
{
    public class DtoToModelMappingTurma : Profile
    {
        public DtoToModelMappingTurma()
        {
            TurmaMap();
        }

        private void TurmaMap()
        {
            CreateMap<DtoTurma, Turma>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.AnoLetivo, opt => opt.MapFrom(x => x.AnoLetivo))
                .ForMember(dest => dest.Numero, opt => opt.MapFrom(x => x.Numero));
               
        }
    }
}
