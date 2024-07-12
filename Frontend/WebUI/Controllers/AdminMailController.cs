using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MimeKit;
using WebUI.Models.Mail;

namespace WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var session = HttpContext.Session.GetString("AuthToken");
            if (session.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            var session = HttpContext.Session.GetString("AuthToken");
            if (session.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            MimeMessage message = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin","oguzhanktn0@gmail.com");
            message.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            message.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            message.Body = bodyBuilder.ToMessageBody();
            message.Subject = model.Subject;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("oguzhanktn0@gmail.com", "srsv rhzp fgvv bxsj");
            smtpClient.Send(message);
            smtpClient.Disconnect(true);

            return View();
        }
    }
}
