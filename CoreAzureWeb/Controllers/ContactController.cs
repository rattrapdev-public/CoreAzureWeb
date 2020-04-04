using System;
using CoreAzureWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreAzureWeb.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        [Route("/contact")]
        public IActionResult Contact()
        {
            return View(ContactViewModel.Empty);
        }

        [HttpPost]
        [Route("/contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            return Redirect($"/thankyou?name={model.Name}");
        }

        [HttpGet]
        [Route("/thankyou")]
        public IActionResult ThankYou([FromQuery] string name)
        {
            var model = new ContactViewModel {Name = name};
            Console.WriteLine(model.Name);
            return View("ThankYou", model);
        }
    }
}