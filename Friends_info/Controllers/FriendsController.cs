using Friends_info.Data.Context;
using Friends_info.Services;
using Microsoft.AspNetCore.Mvc;

namespace Friends_info.Controllers { 

    public class FriendsController : Controller
    {
        FriendsRepository friendsrepo;

        public FriendsController(FriendsRepository friendsRepository) { 
        
        friendsrepo = friendsRepository;
        
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var friends = await this.friendsrepo.Read();
            ViewBag.ThisPageTitle = "friendsList";
            ViewData["PageTitle"] = "You can view all friends here.";
            return View(friends);
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var friend = await this.friendsrepo.Read();
            return View(friend);
        }
    }
}
    