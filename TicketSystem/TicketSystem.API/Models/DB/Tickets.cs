using System;
using System.Collections.Generic;

namespace TicketSystem.API.Models.DB
{
    public partial class Tickets
    {
        public int Id { get; set; }
        public int AssignDate { get; set; }
        public int AssignUser { get; set; }
        public int CreateDate { get; set; }
        public int CreateUser { get; set; }
        public string Status { get; set; }
        public string TicketDescription { get; set; }
        public string TicketTitle { get; set; }
        public int UpdateDate { get; set; }
        public int UpdateUser { get; set; }
        public int? UserIdid { get; set; }

        public Users UserId { get; set; }
    }
}
