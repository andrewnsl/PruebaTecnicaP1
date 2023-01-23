using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaTecnicaP1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PruebaTecnicaP1.DataAccess
{
    public partial class ProyectoContext : DbContext
    {
        private readonly string _connectionStrings;

        public ProyectoContext(IConfiguration appConfiguration)
        {
            _connectionStrings = appConfiguration.GetConnectionString("Bd")!;
        }

        #region DbSet
        public virtual DbSet<Covid> Covids { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseSqlite(_connectionStrings, p =>
            {
                p.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Regions");
                entity.HasKey(e => e.RegionId);
            });

            modelBuilder.Entity<Covid>(entity =>
            {
                entity.ToTable("Covids");
                entity.HasKey(e => e.CovidId);

                entity.HasOne(d => d.Region).WithMany(p => p.Covids)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
