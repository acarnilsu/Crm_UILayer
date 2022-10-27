using Crm_UILayer.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace Crm_UILayer.Controllers
{
    public class MailController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
            //xxvksinrkafovglj
        }
        [HttpPost]
        public IActionResult Index(MailRequest p)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Proje Admin", "nilsuacar97@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("Kullanıcı",p.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            var bodybuilder=new BodyBuilder();
            bodybuilder.TextBody = p.Body;
            mimeMessage.Body=bodybuilder.ToMessageBody();
            mimeMessage.Subject = p.Subject;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587,false);
            smtpClient.Authenticate("nilsuacar97@gmail.com", "xxvksinrkafovglj");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
            return RedirectToAction("Index");
            //xxvksinrkafovglj

        }

    }
}
