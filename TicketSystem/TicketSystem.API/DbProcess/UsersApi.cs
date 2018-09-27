using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.API.Models.DB;

namespace TicketSystem.API.DbProcess
{
    public class UsersApi
    {


        LittleTicketSystemContext _contextUsers = new LittleTicketSystemContext();


        public void setUsers(Users _user)
        {
            _contextUsers.Users.Add(_user);

        }


    }
}
