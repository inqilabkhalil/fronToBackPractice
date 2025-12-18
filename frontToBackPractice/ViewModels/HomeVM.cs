
using frontToBackPractice.Models;
using System.Collections.Generic;

namespace frontToBackPractice.ViewModels;

public class HomeVM
{
    public IEnumerable<Slider> Sliders { get; set; }   
    public SliderInfo SliderInfo { get; set; }       
    public List<Blog> Blogs { get; set; }
}
