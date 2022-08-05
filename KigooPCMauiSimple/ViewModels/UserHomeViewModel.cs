using KigooPCMauiSimple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigooPCMauiSimple.ViewModels
{
  public class UserHomeViewModel : UserGeneralViewModel
  {
    public IEnumerable<Property> Sliders { get; set; }

    public IEnumerable<OurService> Services { get; set; }

    public IEnumerable<Property> LatestProperties { get; set; }

    public IEnumerable<ApplicationUser> Agents { get; set; }

    public IEnumerable<News> News { get; set; }

    public IEnumerable<Testimonials> Testimonials { get; set; }
  }
}
