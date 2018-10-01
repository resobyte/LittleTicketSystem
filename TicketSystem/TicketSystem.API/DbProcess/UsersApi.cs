﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.API.Models.DB;

namespace TicketSystem.API.DbProcess
{
    public class UsersApi
    {
        LittleTicketSystemContext _contextUsers = new LittleTicketSystemContext();


        public void AddUsers(Users user)
        {
            var entityQuery = _contextUsers.Users.Where(u => u.UserName == user.UserName && u.UserEmail == user.UserEmail);
            var dataEntity = entityQuery.FirstOrDefault();

            if (dataEntity == null)
            {
                var dataUser = new Users();
                dataUser.UserAvatar = user.UserAvatar;
                dataUser.UserEmail = user.UserEmail;
                dataUser.UserLastIp = user.UserLastIp;
                dataUser.UserLastLogin = user.UserLastLogin;
                dataUser.UserName = user.UserName;
                dataUser.UserPassword = user.UserPassword;
                dataUser.UserPhoneNumber = user.UserPhoneNumber;
                dataUser.DeparmentIdid = user.DeparmentIdid;
                dataUser.UserPassword = user.UserPassword;

                _contextUsers.Add(dataUser);
                _contextUsers.SaveChanges();
            }

        }

        public List<Users> GetUsers()
        {
            var userlist = new List<Users>();
            userlist = _contextUsers.Users.ToList();

            return userlist;
        }


        public Users GetUser(int id)
        {
            Users user = new Users();
            user = _contextUsers.Users.FirstOrDefault(u => u.Id == id);

            return user!=null?user:null;
        }

        public void UpdateUser(Users user)
        {
            var entityQuery = _contextUsers.Users.Where(u => u.Id == user.Id);
            var dataEntity = entityQuery.FirstOrDefault();

            if (dataEntity != null)
            {
                _contextUsers.Attach(dataEntity);

                dataEntity.Mail = user.Mail;
                dataEntity.DeparmentId = user.DeparmentId;
                dataEntity.UserAvatar = user.UserAvatar;
                dataEntity.UserEmail = user.UserEmail;
                dataEntity.UserLastIp = user.UserLastIp;
                dataEntity.UserLastLogin = user.UserLastLogin;
                dataEntity.UserName = user.UserName;
                dataEntity.UserPassword = user.UserPassword;
                dataEntity.UserPhoneNumber = user.UserPhoneNumber;

                _contextUsers.SaveChanges();
            }
        }


        public void DeleteUser(int id, string name)
        {
            var entityUserQuery = _contextUsers.Users.Where(u => u.Id == id && u.UserName == name);
            var dataEntity = entityUserQuery.FirstOrDefault();

            if (dataEntity != null)
            {
                _contextUsers.Remove(dataEntity);
                _contextUsers.SaveChanges();
            }
        }

    }
}
