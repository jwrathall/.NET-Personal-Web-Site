using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Model;

namespace Domain.Services
{
    public class Notification
    {
        public ContactInfo contactInfo;

        public string toEmail
        {
            get { return Config.DefaultToEmail; }
        }
        public string fromEmail
        {
            get { return Config.DefaultFromEmail; }
        }

        public string subject { get; set; }
        public string message
        {
            get { return "Notification: you have received a contact request."; }
        }

        public Notification (ContactInfo  contactInfo)
        {
            this.contactInfo = contactInfo;
        }
        public Notification()
        {
        }


    }
}
