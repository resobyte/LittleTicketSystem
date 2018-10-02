using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.API.Models.DB;

namespace TicketSystem.API.DbProcess
{
    public class NotificationsApi
    {

        LittleTicketSystemContext _contextNotifications = new LittleTicketSystemContext();



        public void AddNotifications(Notifications notification)
        {
            Notifications newNotification = new Notifications();

            if (notification != null)
            {
                newNotification.NotificationDescription = notification.NotificationDescription;
                newNotification.NotificationTitle = notification.NotificationTitle;
                newNotification.UserIdid = notification.UserIdid;

                _contextNotifications.Notifications.Add(newNotification);
                _contextNotifications.SaveChanges();

            }


            _contextNotifications.Notifications.Add(_notification);

        }

        public List<Notifications> GetNotifications()
        {
            List<Notifications> notifications = new List<Notifications>();

            notifications = _contextNotifications.Notifications.ToList();

            return notifications;
        }

        public Notifications GetNotification(int id)
        {
            var notificationQuery = _contextNotifications.Notifications.Where(n => n.Id == id);
            var dataEntity = notificationQuery.FirstOrDefault();

            return dataEntity != null ? dataEntity : null;

        }

        public void UpdateNotification(Notifications notification)
        {
            var notificationQuery = _contextNotifications.Notifications.Where(n => n.Id == notification.Id);
            var dataEntity = notificationQuery.FirstOrDefault();

            if (dataEntity != null)
            {
                _contextNotifications.Attach(dataEntity);

                dataEntity.NotificationDescription = notification.NotificationDescription;
                dataEntity.NotificationTitle = notification.NotificationTitle;
                dataEntity.UserIdid = notification.UserIdid;

                _contextNotifications.SaveChanges();

            }
        }

        public void DeleteNotification(int id)
        {
            var notificationQuery = _contextNotifications.Notifications.Where(n => n.Id == id);
            var dataEntity = notificationQuery.FirstOrDefault();

            if (dataEntity != null)
            {
                _contextNotifications.Notifications.Remove(dataEntity);
            }


        }


    }
}
