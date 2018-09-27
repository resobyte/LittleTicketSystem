using System;
using System.Collections.Generic;

namespace TicketSystem.API.Models.DB
{
    public partial class Admin
    {
        public int Id { get; set; }
        public int AdminPassword { get; set; }
        public int AdminUserName { get; set; }
    }
}
