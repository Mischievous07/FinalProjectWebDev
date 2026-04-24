using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Mod> Mods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mod>().HasData(
                new Mod
                {
                    Id = 1,
                    Name = "Oru Rework Guilty by Association.",
                    Description = "Reworks Oru's Guilty by Association upgrade",
                    Author = "Me",
                    FileName = "oru_rework.txt",
                    ReleaseDate = new DateTime(2024, 1, 10)
                },
                new Mod
                {
                    Id = 2,
                    Name = "Oru Cleanse Fix",
                    Description = "Fixes Oru's card effect groups not being removed by Cleanse",
                    Author = "Me",
                    FileName = "oru_cleanse_fix.txt",
                    ReleaseDate = new DateTime(2024, 2, 5)
                },
                new Mod
                {
                    Id = 3,
                    Name = "Xenobia Endlag Reductions",
                    Description = "Reduces endlag for Xenobia's abilities.",
                    Author = "Me",
                    FileName = "xenobia_endlag.txt",
                    ReleaseDate = new DateTime(2024, 3, 15)
                }
            );
        }
    }
}