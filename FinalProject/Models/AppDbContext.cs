using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GiganticModdingHub.Models
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
                    Name = "HD Texture Pack",
                    Description = "Improves character and environment textures.",
                    Author = "You",
                    ReleaseDate = new DateTime(2024, 1, 10)
                },
                new Mod
                {
                    Id = 2,
                    Name = "Custom UI Overhaul",
                    Description = "Redesigns the in-game UI for better clarity.",
                    Author = "You",
                    ReleaseDate = new DateTime(2024, 2, 5)
                },
                new Mod
                {
                    Id = 3,
                    Name = "Hero Balance Tweaks",
                    Description = "Adjusts stats for better gameplay balance.",
                    Author = "You",
                    ReleaseDate = new DateTime(2024, 3, 15)
                }
            );
        }
    }
}