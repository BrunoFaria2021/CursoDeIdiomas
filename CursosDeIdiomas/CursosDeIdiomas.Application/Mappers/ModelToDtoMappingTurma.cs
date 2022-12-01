using AutoMapper;
using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Domain;

namespace CursosDeIdiomas.Application.Mappers
{
    public class ModelToDtoMappingTurma : Profile
    {
        public ModelToDtoMappingTurma()
        {
            DtoTurmaMap();
        }
        private void DtoTurmaMap()
        {
            CreateMap<Turma, DtoTurma>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.AnoLetivo, opt => opt.MapFrom(x => x.AnoLetivo))
                .ForMember(dest => dest.Numero, opt => opt.MapFrom(x => x.Numero));
        }
    }
}
