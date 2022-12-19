using Autofac;
using CursosDeIdiomas.Application;
using CursosDeIdiomas.Application.Interfaces;
using CursosDeIdiomas.Application.Interfaces.Mappers;
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
            builder.RegisterType<ApplicationServiceMatricula>().As<IApplicationServiceMatricula>();
            builder.RegisterType<ServiceAluno>().As<IServiceAluno>();
            builder.RegisterType<ServiceTurma>().As<IServiceTurma>();
            builder.RegisterType<ServiceMatricula>().As<IServiceMatricula>();
            builder.RegisterType<RepositoryAluno>().As<IRepositoryAluno>();
            builder.RegisterType<RepositoryTurma>().As<IRepositoryTurma>();
            builder.RegisterType<RepositoryMatricula>().As<IRepositoryMatricula>(); 
            builder.RegisterType<MapperAluno>().As<IMapperAluno>();
            builder.RegisterType<MapperTurma>().As<IMapperTurma>();
            builder.RegisterType<MapperMatricula>().As<IMapperMatricula>();

            #endregion
        }


    }
}
