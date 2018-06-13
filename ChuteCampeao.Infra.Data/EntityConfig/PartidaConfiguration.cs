using ChuteCampeao.Domain.Entites;
using System.Data.Entity.ModelConfiguration;

namespace ChuteCampeao.Infra.Data.EntityConfig
{
    public class PartidaConfiguration : EntityTypeConfiguration<Partida>
    {
        public PartidaConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired().HasMaxLength(250);
            Property(x => x.Data).IsRequired();
            HasRequired(x => x.TimeLocal).WithMany().HasForeignKey(x => x.TimeLocalId);
            HasRequired(x => x.TimeVisitante).WithMany().HasForeignKey(x => x.TimeVisitanteId);
            HasRequired(x => x.Rodada).WithMany().HasForeignKey(x => x.RodadaId);
            HasRequired(x => x.Estadio).WithMany().HasForeignKey(x => x.EstadioId);
        }
    }
}
