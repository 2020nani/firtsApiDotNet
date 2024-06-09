using Microsoft.EntityFrameworkCore;
using primeiraApi.Data;
using primeiraApi.Repositorios;
using primeiraApi.Repositorios.interfaces;
/* Comandos para utilizar na aplicação
 * Migrar mapeamento de tabelas para o DataBase
   Rodar seguinte comando no packagemanager console
 - Add-Migration InitialDB -Context <nome do contexto a ser migrado>
 * Criar tabelas no database a partir das migrations geradas
 - Update-Database -Context <nome do contexto a ser migrado>
 */
namespace firstApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<SistemaTarefasDBContext>(
                options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
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
