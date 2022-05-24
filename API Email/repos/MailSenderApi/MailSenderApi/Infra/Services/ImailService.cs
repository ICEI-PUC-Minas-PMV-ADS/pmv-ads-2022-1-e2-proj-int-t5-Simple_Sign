
namespace MailSenderApi.Infra.Services
{
    public interface IMailService
    {
        void SendMail(string[] emails, string subject, string body, bool isHtml = false);
    }
}