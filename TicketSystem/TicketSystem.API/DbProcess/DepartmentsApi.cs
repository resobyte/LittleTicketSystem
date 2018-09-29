using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.API.Models.DB;

namespace TicketSystem.API.DbProcess
{
    public class DepartmentsApi
    {

        LittleTicketSystemContext _contextDepartments = new LittleTicketSystemContext();



        public void setDepartments(Departments _department)
        {
            _contextDepartments.Departments.Add(_department);

        }



    }
}
