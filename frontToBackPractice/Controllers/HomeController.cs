using System.Diagnostics;
using frontToBackPractice.Data;
using Microsoft.AspNetCore.Mvc;
using frontToBackPractice.Models;
using frontToBackPractice.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace frontToBackPractice.Controllers;

public class HomeController : Controller

{
    private readonly AppDbContext _context;
    public HomeController(AppDbContext context)
    {
        _context=context;
    }
    
    public IActionResult Index()
    {
        List<Slider> slider = _context.Sliders.ToList();
        SliderInfo sliderInfo = _context.SliderInfos.FirstOrDefault();
        List<Blog> blogs = _context.Blogs.Take(3).Include(m => m.Images).ToList();
        HomeVM model = new HomeVM()
        {
            SliderInfo = sliderInfo,
            Sliders = slider,
            Blogs = blogs
        };
        return View(model);
    }
    

    
}