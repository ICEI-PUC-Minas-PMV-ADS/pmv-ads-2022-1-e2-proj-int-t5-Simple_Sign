namespace MailSenderApi.ViewModels
{
    public class SendMailViewModel
    {
        public string[] Emails { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public bool IsHtml { get; set; }
    }
}