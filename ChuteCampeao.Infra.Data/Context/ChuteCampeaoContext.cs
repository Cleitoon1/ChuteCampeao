using ChuteCampeao.Domain.Entites;
using ChuteCampeao.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ChuteCampeao.Infra.Data.Context
{
    public class ChuteCampeaoContext : DbContext
    {
        public ChuteCampeaoContext() : base("ConnectionString")
        {

        }

        public DbSet<Campeonato> Campeonatos { get; set; }
        public DbSet<Rodada> Rodadas { get; set; }
        public DbSet<Partida> Partidas { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Estadio> Estadio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id" || p.Name == "Id")
                .Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(100));

            modelBuilder.Configurations.Add(new CampeonatoConfiguration());
            modelBuilder.Configurations.Add(new RodadaConfiguration());
            modelBuilder.Configurations.Add(new PartidaConfiguration());
            modelBuilder.Configurations.Add(new TimeConfiguration());
            modelBuilder.Configurations.Add(new EstadioConfiguration());
        }

        public override int SaveChanges()
        {
           
            foreach (var entry in ChangeTracker.Entries())
            {
                if(entry.State == EntityState.Added)
                {
                    if(entry.Property("DataCadastro") != null)
                        entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                    if (entry.Property("DataModificacao") != null)
                        entry.Property("DataModificacao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    if (entry.Property("DataCadastro") != null)
                        entry.Property("DataCadastro").IsModified = false;
                    if (entry.Property("DataModificacao") != null)
                        entry.Property("DataModificacao").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
