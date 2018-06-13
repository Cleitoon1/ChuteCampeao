using ChuteCampeao.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuteCampeao.Infra.Data.EntityConfig
{
    public class RodadaConfiguration : EntityTypeConfiguration<Rodada>
    {
        public RodadaConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.DataInicio).IsRequired();
            Property(x => x.DataFim).IsRequired();
            Property(x => x.Status).IsRequired();
            HasRequired(x => x.Campeonato).WithMany().HasForeignKey(x => x.CampeonatoId);
            HasMany(x => x.Partidas).WithRequired(x => x.Rodada).HasForeignKey(x => x.RodadaId);

        }

    }
}
