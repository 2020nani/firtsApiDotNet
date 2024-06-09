using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using primeiraApi.Models;

namespace firstApi.Data.Map
{
    public class TarefasMap : IEntityTypeConfiguration<TarefasModel>
    {
        public void Configure(EntityTypeBuilder<TarefasModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255); ;
            builder.Property(x => x.Descricao).HasMaxLength(1255); ;
            builder.Property(x => x.StatusTarefa).HasDefaultValue(Enums.StatusTarefa.AFazer);

        }
    }
}
