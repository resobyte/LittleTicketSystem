using System;
using System.Collections.Generic;

namespace TicketSystem.API.Models.DB
{
    public partial class Users
    {
        public Users()
        {
            Mail = new HashSet<Mail>();
            Notifications = new HashSet<Notifications>();
            Tickets = new HashSet<Tickets>();
        }

        public int Id { get; set; }
        public int? DeparmentIdid { get; set; }
        public string UserAvatar { get; set; }
        public string UserEmail { get; set; }
        public string UserLastIp { get; set; }
        public string UserLastLogin { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserPhoneNumber { get; set; }

        public Departments DeparmentId { get; set; }
        public ICollection<Mail> Mail { get; set; }
        public ICollection<Notifications> Notifications { get; set; }
        public ICollection<Tickets> Tickets { get; set; }
    }
}
