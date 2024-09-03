using Microsoft.AspNetCore.Mvc;

namespace Friends_info.Controllers
{
    public class AuthenticationController : Controller
    {

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(Models.LoginModel LoginModel)
        {
            return View();
        }
    }
}
