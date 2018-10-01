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

        public void AddTicket(Tickets ticket)
        {
            var ticketQuery = _contextTickets.Tickets.Where(t => t.Id == -1);
            var dataEntity = ticketQuery.FirstOrDefault();

            if (dataEntity==null)
            {
                dataEntity.Status = (0).ToString();
                dataEntity.AssignUser = ticket.AssignUser;
                dataEntity.CreateDate = (DateTime.Now).ToString();
                dataEntity.CreateUser = ticket.CreateUser;
                dataEntity.TicketTitle = ticket.TicketTitle;
                dataEntity.TicketDescription = ticket.TicketDescription;
                dataEntity.UserIdid = ticket.UserIdid;

                _contextTickets.Tickets.Add(dataEntity);
                _contextTickets.SaveChanges();
            }
            
        }

        public List<Tickets> GetTickets()
        {
            var ticketsList = new List<Tickets>();
            ticketsList = _contextTickets.Tickets.ToList();

            return ticketsList;
        }

        public Tickets GetTicket(int id)
        {
            var ticketQuery = _contextTickets.Tickets.Where(t => t.Id == id);
            var ticket = ticketQuery.FirstOrDefault();

            return ticket!=null?ticket:null;
        }

        public void UpdateTicket(Tickets ticket)
        {
            var ticketQuery = _contextTickets.Tickets.Where(t => t.Id == ticket.Id);
            var dataEntity = ticketQuery.FirstOrDefault();

            if (dataEntity != null)
            {
                _contextTickets.Attach(dataEntity);

                dataEntity.TicketDescription = ticket.TicketDescription;
                dataEntity.TicketTitle = ticket.TicketTitle;
                dataEntity.UpdateDate=(DateTime.Now).ToString();
                dataEntity.Status = (0).ToString();

                _contextTickets.SaveChanges();
            }

        }
        
        public void DeleteTicket(int id, string title)
        {
            var ticketQuery = _contextTickets.Tickets.Where(t => t.Id == id && t.TicketTitle==title);
            var dataEntity = ticketQuery.FirstOrDefault();

            if (dataEntity != null)
            {
                _contextTickets.Remove(dataEntity);
                _contextTickets.SaveChanges();
            }

        }
        
    }
}
