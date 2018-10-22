using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Core.Models.Db
{
    public class Departments
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
