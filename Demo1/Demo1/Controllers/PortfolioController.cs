using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Carusel()
        {
            return View();
        }

        public ActionResult Constrained()
        {
            return View();
        }

        public ActionResult FullWidth()
        {
            return  View();
        }

        public ActionResult SidebarGalleryFullwidth()
        {
            return View();
        }

        public ActionResult Zigzag()
        {
            return View();
        }

        public ActionResult RightSidebarFullWidth()
        {
            return View();
        }

        public ActionResult FullWidthConstrained()
        {
            return View();
        }

        public ActionResult FullScreenSlider()
        {
            return View();
        }

        public ActionResult SidebarConstrained()
        {
            return View();
        }
    }
}