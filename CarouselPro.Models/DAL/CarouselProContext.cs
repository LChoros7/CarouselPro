using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace CarouselPro.Models.DAL
{
    public class CarouselProContext : DbContext
    {
        public CarouselProContext() : base("CarouselProContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CarouselProContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
        }
        public DbSet<Slide> Slides { get; set; }
    }
}