using Microsoft.EntityFrameworkCore;
using Parcial3_RamirezQuinteroGloria.DAL.Entities;

namespace Parcial3_RamirezQuinteroGloria.DAL
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base (options)
        {

        }
        public DbSet<Service> Service { get; set; } 
    }
}
