using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Data.Models.Entities
{
    public class Users
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public string UserEmail { get; set; }// Diğer modelden gelecek

        public string UserLastIP { get; set; }

        public string UserAvatar { get; set; }

        public string UserLastLogin { get; set; }

        public string UserPhoneNumber { get; set; }

        //DEPARTMAN GELECEK
    }
}
