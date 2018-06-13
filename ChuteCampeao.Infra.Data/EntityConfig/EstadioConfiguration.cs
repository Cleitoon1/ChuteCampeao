using ChuteCampeao.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuteCampeao.Infra.Data.EntityConfig
{
    public class EstadioConfiguration : EntityTypeConfiguration<Estadio>
    {
        public EstadioConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired();
            HasMany(x => x.Times).WithRequired(x => x.Estadio).HasForeignKey(x => x.EstadioId);
            HasMany(x => x.Partidas).WithRequired(x => x.Estadio).HasForeignKey(x => x.EstadioId);


        }
    }
}
