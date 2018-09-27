using System;
using System.Collections.Generic;

namespace TicketSystem.API.Models.DB
{
    public partial class Mail
    {
        public int Id { get; set; }
        public int MailDescription { get; set; }
        public int MailTitle { get; set; }
        public int? UserIdid { get; set; }

        public Users UserId { get; set; }
    }
}
