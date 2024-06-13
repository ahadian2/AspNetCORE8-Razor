using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            List<Users> users = new List<Users>() {
              new Users { Id=1,Name="Mohammadreza",Family="Ahadian"},
              new Users { Id=2,Name="Ahmadreza",Family="Jafari"},
              new Users { Id=3,Name="Alireza",Family="Akbari"},
              new Users { Id=4,Name="Hoda",Family="Mahmodi"},
              new Users { Id=5,Name="Tanaz",Family="Rezaei"}
            };
            return View(users);
        }
        public IActionResult info()
        {
            Users users = new Users()
            {
                Id = 1,
                Name = "Mohammadreza",
                Family = "Ahadian"
            };

            return View(users);
        }
    }
}
