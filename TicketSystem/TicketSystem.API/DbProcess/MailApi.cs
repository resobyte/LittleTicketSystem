using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.API.Models.DB;

namespace TicketSystem.API.DbProcess
{
    public class MailApi:DbContext
    {


        LittleTicketSystemContext _contextMail = new LittleTicketSystemContext();


        public void setMail(Mail _mail)
        {
            _contextMail.Mail.Add(_mail);

        }


    }
}
