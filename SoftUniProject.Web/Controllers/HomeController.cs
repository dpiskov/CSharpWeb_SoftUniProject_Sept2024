using System.Diagnostics; // System namespaces

using Microsoft.AspNetCore.Mvc; // Third-party namespaces

using SoftUniProject.Web.ViewModels; // Internal project namespaces

namespace SoftUniProject.Web.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
          
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
