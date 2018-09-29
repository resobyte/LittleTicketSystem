﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketSystem.API.DbProcess;
using Newtonsoft.Json;
using TicketSystem.API.Models.DB;
using Microsoft.AspNetCore.Http.Features;

namespace TicketSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class PageController : Controller
    {


        #region Tickets

        //TICKETS API'S

        // GET api/page
        [HttpGet]
        public IEnumerable<string> GetTickets()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/page/5
        [HttpGet("{id}")]
        public string GetTicket(int id)
        {
            return "value";
        }

        // POST api/page
        [HttpPost]
        public string SetTicket(string name)//[FromBody]string value    
        {
            return "post işlemi yapılıyor..";
        }

        // PUT api/page/5
        [HttpPut("{id}")]
        public void PutTicket(int id, [FromBody]string value)
        {
        }

        // DELETE api/page/5
        [HttpDelete("{id}")]
        public void DeleteTicket(int id)
        {
        }
        #endregion


        #region Users
        //TICKETS API'S

        // GET api/page
        [HttpGet]
        public string GetUsers()
        {
            UsersApi users = new UsersApi();
            var jsonData = JsonConvert.SerializeObject(users.GetUsers());

            return jsonData;
        }

        // GET api/page/5
        [HttpGet("{id}")]
        public string GetUser(int id)
        {
            UsersApi user = new UsersApi();
            var jsonData = JsonConvert.SerializeObject(user.GetUser(id));

            return jsonData;
        }

        // POST api/page
        [HttpPost]
        public void AddUser(Users user)//[FromBody]string value    
        {
            //var ip = HttpContext.Features.Get<IHttpConnectionFeature>()?.RemoteIpAddress?.ToString();
            UsersApi userApi = new UsersApi();
            Users user1 = new Users();

            user1.UserEmail = user.UserEmail;
            user1.UserPhoneNumber = user.UserName;
            user1.UserName = user.UserName;
            user1.UserLastLogin = (DateTime.Now).ToString();
            user1.UserLastIp = user.UserLastIp != null ? user.UserLastIp : null;
            user1.UserAvatar = user.UserAvatar;
            user1.DeparmentIdid = user.DeparmentIdid;
            user1.UserPassword = user.UserPassword!="" ? "1234" : "000";

            userApi.AddUsers(user1);

        }

        // PUT api/page/5
        [HttpPut("{id}")]
        public void UpdateUser(Users user)   //int id, [FromBody]string value
        {
            UsersApi userApi = new UsersApi();
            userApi.UpdateUser(user);
        }

        // DELETE api/page/5
        [HttpDelete("{id},{name}")]
        public void DeleteUser(int id, string name)
        {
            UsersApi userApi = new UsersApi();
            userApi.DeleteUser(id, name);

        }

        #endregion
        #region UserFunction

        public string LokalIP()
        {
             //LokalIP bilgileri alınıyor

            string IPadresimiz = null;
            
            // Bir IPHostEntry örneğine; IP adresi veya host adını çözümler...

            // IPHostEntry - bir konteynır sınıfı internet host adres bilgilerini içerir.
            System.Net.IPHostEntry _IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());


            // IPAddress sınıfı Bir IP ağı üzerinde bir bilgisayarın adresini içerir. 
            foreach (System.Net.IPAddress LokalIPAddress in _IPHostEntry.AddressList)
            {

                // Soket son noktaya bağlandığında

                // InterNetwork IP'nin beklenen 4 adresini gösterir
                if (LokalIPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    IPadresimiz = LokalIPAddress.ToString();
                }
            }
            return IPadresimiz;
            
        }




        #endregion

        #region Departmets
        //TICKETS API'S

        // GET api/page
        [HttpGet]
        public IEnumerable<string> GetDepartmets()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/page/5
        [HttpGet("{id}")]
        public string GetDepartmet(int id)
        {
            return "value";
        }

        // POST api/page
        [HttpPost]
        public string SetDepartmet(string name)//[FromBody]string value    
        {
            return "post işlemi yapılıyor..";
        }

        // PUT api/page/5
        [HttpPut("{id}")]
        public void PutDepartmets(int id, [FromBody]string value)
        {
        }

        // DELETE api/page/5
        [HttpDelete("{id}")]
        public void DeleteDepartmet(int id)
        {
        }

        #endregion


        #region Mail
        //TICKETS API'S

        // GET api/page
        [HttpGet]
        public IEnumerable<string> GetMails()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/page/5
        [HttpGet("{id}")]
        public string GetMail(int id)
        {
            return "value";
        }

        // POST api/page
        [HttpPost]
        public string SetMail(string name)//[FromBody]string value    
        {
            return "post işlemi yapılıyor..";
        }

        // PUT api/page/5
        [HttpPut("{id}")]
        public void PutMail(int id, [FromBody]string value)
        {
        }

        // DELETE api/page/5
        [HttpDelete("{id}")]
        public void DeleteMail(int id)
        {
        }

        #endregion


        #region Notifications
        //TICKETS API'S

        // GET api/page
        [HttpGet]
        public IEnumerable<string> GetNotifications()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/page/5
        [HttpGet("{id}")]
        public string GetNotification(int id)
        {
            return "value";
        }

        // POST api/page
        [HttpPost]
        public string SetNotification(string name)//[FromBody]string value    
        {
            return "post işlemi yapılıyor..";
        }

        // PUT api/page/5
        [HttpPut("{id}")]
        public void PutNotification(int id, [FromBody]string value)
        {
        }

        // DELETE api/page/5
        [HttpDelete("{id}")]
        public void DeleteNotification(int id)
        {
        }

        #endregion

    }
}