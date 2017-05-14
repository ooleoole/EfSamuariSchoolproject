using System;
using System.Security.Cryptography.X509Certificates;
using EfSamuariDomain;
using EfSamuariDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfSamuariData
{
    public interface ISamuraiContext
    {
        DbSet<Samurai> Samurais { get; set; }
        DbSet<Battle> Battle { get; set; }
        DbSet<SamuariBattle> SamuariBattles { get; set; }
        DbSet<Quote> Quotes { get; set; }
        DbSet<BattleLog> BattleLogs { get; set; }
        DbSet<BattleEvent> BattleEvents { get; set; }
    }

    public class SamuraiContext : DbContext, ISamuraiContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battle { get; set; }
        public DbSet<SamuariBattle> SamuariBattles { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<BattleLog> BattleLogs { get; set; }
        public DbSet<BattleEvent> BattleEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = EfSamurai; Trusted_Connection = True; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuariBattle>().HasKey(x => new { x.BattleId, x.SamuraiId });

            modelBuilder.Entity<SamuariBattle>()
        .HasOne(pc => pc.Samurai)
        .WithMany(p => p.Battles)
        .HasForeignKey(pc => pc.SamuraiId);

            modelBuilder.Entity<SamuariBattle>()
                .HasOne(pc => pc.Battle);
        
        

           

        }
    }

}
