using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Data.Models.Entities
{
    public class Tickets
    {
        public int ID { get; set; }

        public string TicketTitle { get; set; }

        public string TicketDescription { get; set; }
    }
}
