using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Services
{
    interface INotification
    {
        bool Send(Notification notification);
    }
}
