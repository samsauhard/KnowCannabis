using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KnowCannabis.Models;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;

namespace KnowCannabis.Controllers
{

    public class HomeController : Controller
    {
        public static int count = 0;
        static HttpClient client = new HttpClient();
        static List<Cannabis> ctype = new List<Cannabis>();

        public  HomeController()
        {
            
            
            
        }

        public IActionResult Index()
        {


            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
     


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public static async Task<int> RunAsync()
        {
            client.BaseAddress = new Uri("http://cannabisweb.us-east-1.elasticbeanstalk.com");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           
                String json;
                HttpContent content;
                HttpResponseMessage response;
                Cannabis cannabis;
            response = await client.GetAsync("/api/cannabis.json");
            if (response.IsSuccessStatusCode)
            {


                json = await response.Content.ReadAsStringAsync();


                IEnumerable<Cannabis> chapters = JsonConvert.DeserializeObject<IEnumerable<Cannabis>>(json);
                foreach (Cannabis c in chapters)
                {
                    ctype.Add(c);

                    Console.WriteLine(c.Name);
                    
                }
               
            }
            return 0;
        }
    }
}
