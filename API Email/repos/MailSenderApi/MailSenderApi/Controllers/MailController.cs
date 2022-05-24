using MailSenderApi.Infra.Services;
using MailSenderApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MailSenderApi.Controllers
{
    [Route("api/mails")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService _mailService;
        public MailController(IMailService mailService)
        {
            _mailService = mailService;
        }

        [HttpPost]
        public IActionResult SendMail([FromBody] SendMailViewModel sendMailViewModel)
        {
            _mailService.SendMail(sendMailViewModel.Emails, sendMailViewModel.Subject, sendMailViewModel.Body,
                sendMailViewModel.IsHtml);

            return Ok();
        }
    }
}