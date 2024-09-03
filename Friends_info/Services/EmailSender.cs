using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace Friends_info.Services
{
    public class EmailSender()
    {
       public static void SendEmail(string toEmail)
        {
            Console.WriteLine(toEmail);
        }
    }
}
