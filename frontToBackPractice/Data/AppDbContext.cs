using frontToBackPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace frontToBackPractice.Data;

public class AppDbContext :DbContext
{
    public DbSet<Slider> Sliders { get; set; }  
    public DbSet<SliderInfo> SliderInfos { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}
    
}