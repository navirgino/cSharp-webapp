using cSharp_webapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace cSharp_webapp.Controllers
{
    public class AntiquesController : Controller
    {
        // GET: Antiques
        public ActionResult Random()

        {

            var antique = new Antique() { Name = "Old watch", Cost = 4 };


            return View(antique);
        }
    }
}