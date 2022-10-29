using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebMyAppAspdotnetmvcapi.Models;

namespace WebMyAppAspdotnetmvcapi.Controllers
{
    public class ConsumeController : Controller
    {
        // GET: Consume
        HttpClient client = new HttpClient(); 
        public ActionResult Index()
        {
            List<Student> list = new List<Student>();
            client.BaseAddress = new Uri("http://localhost:52768/api/NewApi");
            var response = client.GetAsync("NewApi");
            response.Wait();
            var test = response.Result;
            if(test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Student>>();
                display.Wait();
                list = display.Result;
            }
            return View(list);
        }
    }
}