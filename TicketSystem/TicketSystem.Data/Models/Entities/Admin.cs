using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Data.Models.Entities
{
    public class Admin
    {
        public int ID { get; set; }

        public int AdminUserName { get; set; }

        public int AdminPassword { get; set; }
    }
}
