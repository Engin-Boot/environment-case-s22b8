using System.Net.Mail;
using System.Net;

namespace Receiver
{
    public interface Alerter
    {
        bool Alert(string message);
    }

    public class EmailAlert : Alerter {
            public bool Alert(string message) {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("atuljha2524@gmail.com", "atuljha910"),
                EnableSsl = true,
            };

            smtpClient.Send("atuljha2524@gmail.com", "keshariananya@gmail.com", "ALERT", message);
            return true;
        }
    }
}
