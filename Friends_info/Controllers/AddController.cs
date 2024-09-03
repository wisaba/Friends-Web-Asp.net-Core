using Microsoft.AspNetCore.Mvc;

namespace Friends_info.Controllers
{
    public class AddController : Controller
    {

        [HttpPost]
        public async Task<IActionResult> Index(Data.Friend FR_Name)
        {
            return Redirect($"/Home/Index/?message = {FR_Name.Name} added successfully .");
        }
    }
}
