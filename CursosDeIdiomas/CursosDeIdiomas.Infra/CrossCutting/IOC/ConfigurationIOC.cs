using Autofac;
using AutoMapper;
using CursosDeIdiomas.Application;
using CursosDeIdiomas.Application.Interfaces;
using CursosDeIdiomas.Application.Mappers;
using CursosDeIdiomas.Domain.core.Interfaces.Repositories;
using CursosDeIdiomas.Domain.core.Interfaces.Services;
using CursosDeIdiomas.Domin.Services;
using CursosDeIdiomas.Infra.Data.Repositories;

namespace CursosDeIdiomas.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceAluno>().As<IApplicationServiceAluno>();
            builder.RegisterType<ApplicationServiceTurma>().As<IApplicationServiceTurma>();
            builder.RegisterType<ServiceAluno>().As<IServiceAluno>();
            builder.RegisterType<ServiceTurma>().As<IServiceTurma>();
            builder.RegisterType<RepositoryAluno>().As<IRepositoryAluno>();
            builder.RegisterType<RepositoryTurma>().As<IRepositoryTurma>();
            builder.RegisterType<MapperAluno>().As<IMapperAluno>();
            builder.RegisterType<MapperTurma>().As<IMapperTurma>();
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingAluno());
                cfg.AddProfile(new ModelToDtoMappingAluno());
                cfg.AddProfile(new DtoToModelMappingTurma());
                cfg.AddProfile(new ModelToDtoMappingTurma());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
            #endregion
        }


    }
}
