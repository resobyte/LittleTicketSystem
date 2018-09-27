using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.API.Models.DB;

namespace TicketSystem.API.DbProcess
{
    public class NotificationsApi
    {

        LittleTicketSystemContext _contextNotifications = new LittleTicketSystemContext();



        public void setNotifications(Notifications _notification)
        {
            _contextNotifications.Notifications.Add(_notification);

        }



    }
}
