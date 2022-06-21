using System.Net;
using System.Net.Mail;

namespace SimpleSign.Services
{
    public class Suporte 
    {
        public void EnviarEmail(string Assunto, string emailDestinatario,string corpoEmail)
        {
            MailMessage objmail = new MailMessage();
            objmail.To.Add(emailDestinatario);
            objmail.From = new MailAddress("sacsimplesign@hotmail.com");
            objmail.Body = corpoEmail;
            objmail.Subject = Assunto;

            SmtpClient objsmtp = new SmtpClient();
            objsmtp.Host = "smtp-mail.outlook.com";
            objsmtp.Port = 587;
            objsmtp.UseDefaultCredentials = false;
            objsmtp.Credentials = new NetworkCredential("sacsimplesign@hotmail.com", "SimpleSign123");
            objsmtp.EnableSsl = true;
            objsmtp.Send(objmail);
        }
    }
}
