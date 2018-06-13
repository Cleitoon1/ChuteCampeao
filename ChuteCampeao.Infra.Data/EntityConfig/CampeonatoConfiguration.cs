using ChuteCampeao.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuteCampeao.Infra.Data.EntityConfig
{
    public class CampeonatoConfiguration : EntityTypeConfiguration<Campeonato>
    {
        public CampeonatoConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired();
            Property(x => x.DataInicio).IsRequired();
            Property(x => x.DataFim).IsRequired();
            Property(x => x.Status).IsRequired();
            HasMany(x => x.Rodadas).WithRequired(x => x.Campeonato).HasForeignKey(x => x.CampeonatoId);
            HasMany(x => x.Times).WithMany(x => x.Campeonatos).Map(x =>
            {
                x.ToTable("CampeonatosTimes");
                x.MapLeftKey("timeId");
                x.MapRightKey("campeonatoId");
            });
        }
    }
}
