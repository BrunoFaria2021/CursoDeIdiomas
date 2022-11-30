using CursosDeIdiomas.Application;
using CursosDeIdiomas.Application.Interfaces;
using CursosDeIdiomas.Application.Interfaces.Mappers;
using CursosDeIdiomas.Application.Mappers;
using CursosDeIdiomas.Domain.core.Interfaces.Repositories;
using CursosDeIdiomas.Domain.core.Interfaces.Services;
using CursosDeIdiomas.Domin.Services;
using CursosDeIdiomas.Infra.Data;
using CursosDeIdiomas.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CursoDeIdiomas.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

/*var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region DI
var connectionString = builder.Configuration.GetConnectionString("ConnectionStrings");

builder.Services.AddDbContext<SqlContext>(options => options
        .UseSqlServer(connectionString),
        ServiceLifetime.Transient
        );

builder.Services.AddScoped<IApplicationServiceAluno, ApplicationServiceAluno>();
builder.Services.AddScoped<IApplicationServiceTurma, ApplicationServiceTurma>();
builder.Services.AddScoped<IServiceAluno, ServiceAluno>();
builder.Services.AddScoped<IServiceTurma, ServiceTurma>();
builder.Services.AddScoped<IRepositoryAluno, RepositoryAluno>();
builder.Services.AddScoped<IRepositoryTurma, RepositoryTurma>();
builder.Services.AddScoped<IMapperAluno, MapperAluno>();
builder.Services.AddScoped<IMapperTurma, MapperTurma>();



#endregion

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
*/