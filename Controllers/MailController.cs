using FormMail.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace FormMail.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index() { return View(); }
        public IActionResult SendMail(FormModel obj)
        {



            MailMessage email = new MailMessage();
            email.From = new MailAddress("steveeb08@gmail.com.com");
            email.To.Add(new MailAddress(obj.ToMail));
            email.Subject = obj.Subject;
            email.IsBodyHtml = true;
            email.Body = obj.Message;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("steveeb@gmail.com", "wevb zvav vqkm vnsg");
            smtp.EnableSsl = true;
            smtp.Send(email);

            ViewBag.Result = "Mailed";

            return View();
        }

    }

}
