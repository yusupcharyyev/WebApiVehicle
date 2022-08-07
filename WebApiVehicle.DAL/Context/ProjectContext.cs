using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiVehicle.Models.Entities.Concrete;
using WebApiVehicle.Models.EntitiesTypeConfiguration.Concrete;

namespace WebApiVehicle.DAL.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Buse> Buses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarMap());
            modelBuilder.ApplyConfiguration(new BoatMap());
            modelBuilder.ApplyConfiguration(new BuseMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
