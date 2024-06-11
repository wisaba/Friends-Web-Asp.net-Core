using Microsoft.AspNetCore.Mvc;

namespace Friends_info.Controllers
{
    public class FriendsController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult List()
        {
            var friend = Data.Database.GetFriends();
            return View(friend);
        }
    }
}
