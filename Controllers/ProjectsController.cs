using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cSharp_webapp.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult RentTheOutdoors()
        {
            ViewBag.Message = "Rent the Outdoors page";
            return View();
        }

        public ActionResult Tamaraland()
        {
            ViewBag.Message = "Tamaraland page";
            return View();
        }

        public ActionResult Pep()
        {
            ViewBag.Message = "Party even planner page";
            return View();
        }
    }
}