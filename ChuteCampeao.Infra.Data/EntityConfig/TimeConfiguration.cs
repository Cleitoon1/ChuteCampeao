using ChuteCampeao.Domain.Entites;
using System.Data.Entity.ModelConfiguration;

namespace ChuteCampeao.Infra.Data.EntityConfig
{
    public class TimeConfiguration : EntityTypeConfiguration<Time>
    {
        public TimeConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.NomeCompleto).IsRequired().HasMaxLength(150);
            Property(x => x.NomeConhecido).IsRequired();
            HasRequired(x => x.Estadio).WithMany().HasForeignKey(x => x.EstadioId);
            HasMany(x => x.PartidasLocal).WithRequired(x => x.TimeLocal).HasForeignKey(x => x.TimeLocalId);
            HasMany(x => x.PartidasVisitante).WithRequired(x => x.TimeVisitante).HasForeignKey(x => x.TimeVisitanteId);
            
        }
    }
}
