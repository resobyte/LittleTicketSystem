using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Core.Models.Db
{
    public class Notifications
    {
        public int Id { get; set; }
        public int NotificationDescription { get; set; }
        public int NotificationId { get; set; }
        public int NotificationTitle { get; set; }
        public int? UserIdid { get; set; }

        public Users UserId { get; set; }

    }
}
