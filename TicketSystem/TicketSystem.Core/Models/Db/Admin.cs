using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Core.Models.Db
{
    public class Admin
    {
        public int Id { get; set; }
        public int AdminPassword { get; set; }
        public int AdminUserName { get; set; }
    }
}
