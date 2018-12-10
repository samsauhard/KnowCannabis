using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using KnowCannabis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

namespace KnowCannabis.Controllers
{
    public class CannabisController : Controller
    {
        HttpClient client = new HttpClient();
        List<Cannabis> ctype = new List<Cannabis>();
        CancellationTokenSource cts = new CancellationTokenSource();
        String json;
        HttpContent content;
        HttpResponseMessage response;
        Cannabis cannabis;
        public CannabisController()
        {

            client.BaseAddress = new Uri("http://cannabisweb.us-east-1.elasticbeanstalk.com");
             
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Cannabis can)
        {
            Cannabis cc = new Cannabis {Id=can.Id, Name = can.Name, Type = can.Type, PostedBy = 32, Thc = can.Thc, Cbd = can.Cbd, EaseMigraine = can.EaseMigraine, High = can.High, IncreaseApetite = can.IncreaseApetite, PainReliever = can.PainReliever, ReduceAnxiety = can.ReduceAnxiety, SideEffects = can.SideEffects };
            response = await client.PutAsJsonAsync("/api/cannabis.json", cc);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Cannabis");
            }

            else
            {
                return View();
            }


        }


        
        public async Task<ActionResult> Delete(int id)
        {
            response = await client.GetAsync("/api/cannabis/" + id.ToString());
            json = await response.Content.ReadAsStringAsync();
            List<Cannabis> chapters = JsonConvert.DeserializeObject<List<Cannabis>>(json);


            cts = null;
            return View(chapters[0]);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirm(int id)
        {
            response = await client.DeleteAsync("/api/cannabis/" + id.ToString());
            json = await response.Content.ReadAsStringAsync();
            List<Cannabis> chapters = JsonConvert.DeserializeObject<List<Cannabis>>(json);


            cts = null;
            return RedirectToAction("Index", "Cannabis");

        }

        public async Task<ActionResult> Edit(int id)
        {
            response = await client.GetAsync("/api/cannabis/" + id.ToString());
            json = await response.Content.ReadAsStringAsync();
            List<Cannabis> chapters = JsonConvert.DeserializeObject<List<Cannabis>>(json);


            cts = null;
            return View(chapters[0]);
            
        }

        public async Task<ActionResult> Details(int id)
        {
            response = await client.GetAsync("/api/cannabis/" + id.ToString());
            json = await response.Content.ReadAsStringAsync();
            List<Cannabis> chapters = JsonConvert.DeserializeObject<List<Cannabis>>(json);
            

            cts = null;
            return View(chapters[0]);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Cannabis can)
        {
            int highest = 0;
                response = await client.GetAsync("/api/cannabis.json");
                json = await response.Content.ReadAsStringAsync();
                List<Cannabis> chapters = JsonConvert.DeserializeObject<List<Cannabis>>(json);
            foreach (Cannabis c in chapters)
            {
                if(c.Id>highest)
                {
                    highest = c.Id;
                        }

                Console.WriteLine(c.Name);

            }
            Cannabis cc = new Cannabis {Id= highest+1, Name= can.Name, Type=can.Type, PostedBy=32, Thc=can.Thc, Cbd= can.Cbd, EaseMigraine= can.EaseMigraine, High= can.High, IncreaseApetite= can.IncreaseApetite, PainReliever= can.PainReliever, ReduceAnxiety= can.ReduceAnxiety, SideEffects= can.SideEffects };
                response = await client.PostAsJsonAsync("/api/cannabis.json", cc);
                if(response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Cannabis");
            }
            else
            {
                return RedirectToAction("Index", "Cannabis");
            }
                
           
        }


        public async Task<ActionResult> Index()
        {

            
            response = await client.GetAsync("/api/cannabis.json");
            json = await response.Content.ReadAsStringAsync();
            List<Cannabis> chapters = JsonConvert.DeserializeObject<List<Cannabis>>(json);

            cts = null;
            return View(chapters);
        }
    }
}