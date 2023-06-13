using Microsoft.EntityFrameworkCore;
using Codebridge_Test.Domain.Entities;
using Codebridge_Test.ViewModels;

namespace Codebridge_Test.Domain
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Dog> Dogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Dog>().HasData(new Dog
            {
                Id = 1,
                Name = "Neo",
                Color = "red & amber",
                TailLength = 22,
                Weight = 32
            });

            modelBuilder.Entity<Dog>().HasData(new Dog
            {
                Id = 2,
                Name = "Jessy",
                Color = "black & white",
                TailLength = 7,
                Weight = 14
            });
        }

        public DbSet<Codebridge_Test.ViewModels.DogViewModel>? DogViewModel { get; set; }
    }
}
