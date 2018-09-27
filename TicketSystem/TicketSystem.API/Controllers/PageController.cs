using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.API.Controllers
{
    [Route("api/[controller]")]
    public class PageController : Controller
    {
        
        #region Tickets
        
        //TICKETS API'S

        // GET api/values
        [HttpGet]
        public IEnumerable<string> GetTickets()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string GetTicket(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string SetTicket(string name)//[FromBody]string value    
        {
            return "post işlemi yapılıyor..";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void PutTicket(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteTicket(int id)
        {
        }
        #endregion


        #region Users
        //TICKETS API'S

        // GET api/values
        [HttpGet]
        public IEnumerable<string> GetUsers()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string GetUser(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string SetUser(string name)//[FromBody]string value    
        {
            return "post işlemi yapılıyor..";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void PutUser(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
        }

        #endregion


        #region Departmets
        //TICKETS API'S

        // GET api/values
        [HttpGet]
        public IEnumerable<string> GetDepartmets()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string GetDepartmet(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string SetDepartmet(string name)//[FromBody]string value    
        {
            return "post işlemi yapılıyor..";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void PutDepartmets(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteDepartmet(int id)
        {
        }

        #endregion


        #region Mail
        //TICKETS API'S

        // GET api/values
        [HttpGet]
        public IEnumerable<string> GetMails()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string GetMail(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string SetMail(string name)//[FromBody]string value    
        {
            return "post işlemi yapılıyor..";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void PutMail(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteMail(int id)
        {
        }

        #endregion


        #region Notifications
        //TICKETS API'S

        // GET api/values
        [HttpGet]
        public IEnumerable<string> GetNotifications()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string GetNotification(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string SetNotification(string name)//[FromBody]string value    
        {
            return "post işlemi yapılıyor..";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void PutNotification(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteNotification(int id)
        {
        }

        #endregion
        
    }
}