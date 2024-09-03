using Friends_info.Services;
using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace Friends_info.Controllers
{
    public class SubscribeController : Controller
    {
        [HttpPost]
        public IActionResult Index(Data.UserEmailSubscribe userEmail)
        {
            var jobId = BackgroundJob.Enqueue(
    () => EmailSender.SendEmail(userEmail.SubscribingEmail));
            return Redirect($"/Home/Index/?message=Dear {userEmail.SubscribingEmail}You are subscribed");
        }
    }
}
