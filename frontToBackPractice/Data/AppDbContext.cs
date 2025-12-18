using frontToBackPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace frontToBackPractice.Data;

public class AppDbContext : DbContext
{
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<SliderInfo> SliderInfos { get; set; }

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogImage> BlogImages { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // 🔒 YALNIZ köhnə cədvəlləri bloklayırıq
        modelBuilder.Entity<Slider>()
            .ToTable("Sliders", t => t.ExcludeFromMigrations());

        modelBuilder.Entity<SliderInfo>()
            .ToTable("SliderInfos", t => t.ExcludeFromMigrations());

        base.OnModelCreating(modelBuilder);
    }
}