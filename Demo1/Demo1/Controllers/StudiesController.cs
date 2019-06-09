using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class StudiesController : Controller
    {
        // GET: Studies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page2()
        {
            return View();
        }
    }
}