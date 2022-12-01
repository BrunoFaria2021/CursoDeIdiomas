using AutoMapper;
using CursosDeIdiomas.Application.Dtos;
using CursosDeIdiomas.Domain;

namespace CursosDeIdiomas.Application.Mappers
{
    public class ModelToDtoMappingAluno : Profile
    {

        public ModelToDtoMappingAluno()
        {
            DtoAlunoMap();
        }

        private void DtoAlunoMap()
        {
            CreateMap<Aluno, DtoAluno>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Cpf, opt => opt.Ignore());
        }
    }
}
