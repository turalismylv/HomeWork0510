using front_to_back.Models;
using front_to_back.ViewModels.About;
using Microsoft.AspNetCore.Mvc;

namespace front_to_back.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var aimComponents = new List<AimComponent>
            {
                new AimComponent{FilePath="display-4 bx bxs-bulb text-light",Title="Our Vision",Text="Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra."},
                new AimComponent{FilePath="display-4 bx bx-revision text-light",Title="Our Mission",Text="Eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis." },
                new AimComponent{FilePath="display-4 bx bxs-select-multiple text-light",Title="Our Goal",Text="Lorem ipsum dolor sit amet, consectetur adipisicing elit,sed do eiusmod tempor."}
            };

            var model = new AboutIndexViewModel
            {
                AimComponents = aimComponents
            };

            return View(model);
        }
    }
}
