using Microsoft.AspNetCore.Mvc;

namespace CoreAzureWeb.Controllers
{
    public class AboutController : Controller
    {
        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }
    }
}