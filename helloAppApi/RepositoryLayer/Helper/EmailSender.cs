using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Helper
{
    public class EmailSender
    {
        public Task SendEmailAsync(string Email , string Subject , string Message)
        {
            var mailSender = "rohitdixit570@gmail.com";
            var password = "nddn mtrf kstf qtjf";

            var client = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(mailSender, password)
            };

            return client.SendMailAsync(
                new MailMessage(
                    from: mailSender,
                    to: Email,
                    Subject,
                    Message
                    )
                );
        }
    }
}
