using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketSystem.Core.Models.Login;

namespace TicketSystem.Core.Controllers
{
    public class PageController : Controller
    {
        static HttpClient client = new HttpClient();
        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public string UserLogin(UserLogin userLogin)
        {
            Boolean state=isLogin(userLogin);

            if (state == true)
                return "Başarılı";
            else
                return "Başarısız";
                        
        }

        public Boolean isLogin(UserLogin userLogin)
        {

            client.BaseAddress = new Uri("http://localhost:64195/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            HttpResponseMessage response = await client.GetAsync(userLogin);

            if (response.IsSuccessStatusCode)
            {

            }

            return true;
        }





    }
}