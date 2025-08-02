using Microsoft.AspNetCore.Mvc;
using OpenIddictWebServer.Models.ViewModels;

namespace OpenIddictWebServer.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Register(string returnUrl = null)
        {
            var registerViewModel = new RegisterViewModel();

            ViewData["ReturnUrl"] = returnUrl;
            return View(registerViewModel);
        }


    }
}
