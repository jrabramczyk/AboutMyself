using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Personal.DataAccess;

namespace Personal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Experience()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can find my LinkedIn profile in the footer.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "You can find my LinkedIn profile in the footer.";

            var postShortDescriptions = new PostShortDescriptionCollection().GetAll();

            return View(postShortDescriptions);
        }
    }
}