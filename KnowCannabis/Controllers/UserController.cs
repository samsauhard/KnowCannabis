using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using KnowCannabis.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KnowCannabis.Controllers
{
    public class UserController : Controller
    {
        HttpClient client = new HttpClient();
        List<Cannabis> ctype = new List<Cannabis>();
        CancellationTokenSource cts = new CancellationTokenSource();
        String json;
        HttpContent content;
        HttpResponseMessage response;
        Cannabis cannabis;
        public UserController()
        {

            client.BaseAddress = new Uri("http://cannabisweb.us-east-1.elasticbeanstalk.com");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Signup(User can)
        {
            int highest = 0;
            response = await client.GetAsync("/api/user.json");
            json = await response.Content.ReadAsStringAsync();
            List<User> chapters = JsonConvert.DeserializeObject<List<User>>(json);
            foreach (User c in chapters)
            {
                if (c.Id > highest)
                {
                    highest = c.Id;
                }

               

            }
            User cc = new User { Id = highest + 1, FName = can.FName, LName = can.LName, Email = can.Email, Phone = can.Phone };

            response = await client.PostAsJsonAsync("/api/user.json", cc);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Cannabis");
            }
            else
            {
                return RedirectToAction("Index", "Cannabis");
            }


        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
