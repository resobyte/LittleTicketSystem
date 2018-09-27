using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.API.Models.DB;

namespace TicketSystem.API.DbProcess
{
    public class Set:DbContext
    {
        LittleTicketSystemContext _contextTickets = new LittleTicketSystemContext();
        LittleTicketSystemContext _contextDepartments = new LittleTicketSystemContext();
        LittleTicketSystemContext _contextMail = new LittleTicketSystemContext();
        LittleTicketSystemContext _contextUsers = new LittleTicketSystemContext();
        LittleTicketSystemContext _contextNotifications = new LittleTicketSystemContext();


        public void setTickets(Tickets _ticket)
        {
            _contextTickets.Tickets.Add(_ticket);

        }

        public void setDepartments(Departments _department)
        {
            _contextDepartments.Departments.Add(_department);

        }

        public void setMail(Mail _mail)
        {
            _contextMail.Mail.Add(_mail);

        }


        public void setUsers(Users _user)
        {
            _contextUsers.Users.Add(_user);

        }

        public void setNotifications(Notifications _notification)
        {
            _contextNotifications.Notifications.Add(_notification);

        }

    }
}
