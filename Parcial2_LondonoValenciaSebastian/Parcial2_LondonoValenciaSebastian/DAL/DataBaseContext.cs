using Microsoft.EntityFrameworkCore;
using Parcial2_LondonoValenciaSebastian.DAL.Entities;
using System.Diagnostics.Metrics;

namespace Parcial2_LondonoValenciaSebastian.DAL
{
    public class DataBaseContext :DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        // Se mapea la identidad para convertirla en una tabla
        public DbSet<Ticket> Tickets { get; set; }



        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(c => c.Id).IsUnique();
            

        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            for (int i = 0; i < 5; i++)
            {
                modelBuilder.Entity<Ticket>().HasData(
                    new Ticket
                    {
                        Id = Guid.NewGuid(),
                        UseDate = null,
                        IsUsed = false,
                        EntranceGate = null
                    }
                );
            }
        }



    }
}
