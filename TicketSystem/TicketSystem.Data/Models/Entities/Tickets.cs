﻿using System;
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

        public string CreateDate { get; set; }

        public string Status { get; set; }

        public string UpdateDate { get; set; }

        public int UpdateUser { get; set; }//

        public int CreateUser { get; set; }//

        public int AssignUser { get; set; }//

        public string AssignDate { get; set; }

        public virtual Users UserID { get; set; }
    }
}
