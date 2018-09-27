using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.API.Models.DB;

namespace TicketSystem.API.DbProcess
{
    public class TicketsApi
    {

        LittleTicketSystemContext _contextTickets = new LittleTicketSystemContext();

        public void setTickets(Tickets _ticket)
        {
            _contextTickets.Tickets.Add(_ticket);


        }



    }
}
