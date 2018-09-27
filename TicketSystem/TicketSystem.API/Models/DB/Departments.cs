using System;
using System.Collections.Generic;

namespace TicketSystem.API.Models.DB
{
    public partial class Departments
    {
        public Departments()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
