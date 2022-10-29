using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebMyAppAspdotnetmvcapi.Models;

namespace WebMyAppAspdotnetmvcapi.Controllers
{
    public class NewApiController : ApiController
    {
        GoogleEntities db = new GoogleEntities();
        [System.Web.Http.HttpGet]
        public IHttpActionResult Index()
        {
            List<Student> obj = db.Students.ToList();
            return Ok(obj);
        }
        [System.Web.Http.HttpGet]
        public IHttpActionResult Index(int id)
        {
            var obj = db.Students.Where(m => m.Id == id).FirstOrDefault();
            return Ok(obj);
        }
    }
}
