using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Data.Models.Entities
{
    public class Mail
    {
        public int ID{ get; set; }

        public int MailTitle { get; set; }

        public int MailDescription { get; set; }
    }
}
