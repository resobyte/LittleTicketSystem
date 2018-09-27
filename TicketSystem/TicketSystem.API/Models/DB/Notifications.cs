using System;
using System.Collections.Generic;

namespace TicketSystem.API.Models.DB
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public int NotificationDescription { get; set; }
        public int NotificationId { get; set; }
        public int NotificationTitle { get; set; }
        public int? UserIdid { get; set; }

        public Users UserId { get; set; }
    }
}
