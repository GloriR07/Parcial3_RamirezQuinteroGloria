using Microsoft.EntityFrameworkCore;
using Parcial3_RamirezQuinteroGloria.DAL.Entities;
using System.Diagnostics.Metrics;

namespace Parcial3_RamirezQuinteroGloria.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base (options)
        {

        }
        public DbSet<Service> Services { get; set; } 
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet <VehicleDatail> VehicleDatails { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Service>().HasIndex(s => s .Name).IsUnique();
            modelBuilder.Entity<Vehicle>().HasIndex("Name", "ServiceId").IsUnique(); // índices compuestos
            modelBuilder.Entity<VehicleDatail>().HasIndex("Name", "VehuculeId").IsUnique(); // índices compuestos
        }

    }
}
