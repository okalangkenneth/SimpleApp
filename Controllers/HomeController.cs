using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new MessageModel
            {
                Message = "Hello from DevOps Kurs!"
            };

            return View(model);
        }
    }
}

