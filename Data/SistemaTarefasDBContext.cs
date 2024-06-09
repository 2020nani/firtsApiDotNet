using Microsoft.EntityFrameworkCore;
using primeiraApi.Models;
using firstApi.Data.Map;
namespace primeiraApi.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options) 
            : base(options) 
        {

        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefasModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefasMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
