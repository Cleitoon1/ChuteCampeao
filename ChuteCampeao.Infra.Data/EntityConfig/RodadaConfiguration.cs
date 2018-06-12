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
           
        }

    }
}
