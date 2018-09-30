using System;
using System.Collections.Generic;

namespace TicketSystem.API.Models.DB
{
    public partial class Tickets
    {
        public int Id { get; set; }
        public string AssignDate { get; set; }
        public int AssignUser { get; set; }
        public string CreateDate { get; set; }
        public int CreateUser { get; set; }
        public string Status { get; set; }
        public string TicketDescription { get; set; }
        public string TicketTitle { get; set; }
        public string UpdateDate { get; set; }
        public int UpdateUser { get; set; }
        public int? UserIdid { get; set; }

        public Users UserId { get; set; }
    }
}
