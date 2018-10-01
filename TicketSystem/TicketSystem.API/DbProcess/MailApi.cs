using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.API.Models.DB;

namespace TicketSystem.API.DbProcess
{
    public class MailApi : DbContext
    {
        LittleTicketSystemContext _contextMail = new LittleTicketSystemContext();

        public List<Mail> GetMails()
        {
            var mails = new List<Mail>();

            mails = _contextMail.Mail.ToList();

            return mails;

        }

        public Mail GetMail(int id)
        {
            var mailQuery = _contextMail.Mail.Where(m => m.Id == id);
            var dataEntity = mailQuery.FirstOrDefault();

            return dataEntity != null ? dataEntity : null;
        }

        public void AddMail(Mail mail)
        {
            Mail newMail = new Mail();

            if (mail != null)
            {
                try
                {
                    newMail.MailTitle = mail.MailTitle;
                    newMail.MailDescription = mail.MailDescription;
                    newMail.UserIdid = mail.UserIdid;

                    _contextMail.Mail.Add(newMail);
                    _contextMail.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }

        }

        public void UpdateMail(Mail mail)
        {
            var mailQuery = _contextMail.Mail.Where(m => m.Id == mail.Id);
            var dataEntity = mailQuery.FirstOrDefault();

            if (dataEntity != null)
            {
                try
                {
                    _contextMail.Attach(dataEntity);

                    dataEntity.MailTitle = mail.MailTitle;
                    dataEntity.MailDescription = mail.MailDescription;
                    dataEntity.UserIdid = mail.UserIdid;

                    _contextMail.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }


        public void DeleteMail(int id)
        {
            var mailQuery = _contextMail.Mail.Where(m => m.Id == id);
            var dataEntity = mailQuery.FirstOrDefault();

            if (dataEntity != null)
            {
                _contextMail.Mail.Remove(dataEntity);
            }

        }
    }
}
