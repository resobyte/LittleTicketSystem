using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Core.Models.Db
{
    public class Mail
    {
        public int Id { get; set; }
        public int MailDescription { get; set; }
        public int MailTitle { get; set; }
        public int? UserIdid { get; set; }

        public Users UserId { get; set; }
    }
}
