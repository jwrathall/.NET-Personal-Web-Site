using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using Domain.Model;
using Domain.Services;

namespace Domain.Services
{
    public class NotificationService : INotification
    {
        private readonly SmtpClient _client;
        public NotificationService()
        {
            _client = new SmtpClient(Config.SmtpHost);
            _client.Credentials = new NetworkCredential("***","***");
        }
        public bool Send(Notification notification)
        {
            var success = false;

            var from =
                new MailAddress(notification.fromEmail);
            var to =
                new MailAddress(notification.toEmail);

            var email =
                new MailMessage(from, to)
                {
                    Subject = notification.contactInfo.Subject,
                    Body = notification.message,
                    IsBodyHtml = false,
                    Sender = from
                };

            try

            {
                _client.Send(email);
                success = true;
            }
            catch (InvalidOperationException)
            {
            }
            catch (SmtpFailedRecipientsException ex)
            {
                success = false;
            }

            return success;
        }
    }
}
