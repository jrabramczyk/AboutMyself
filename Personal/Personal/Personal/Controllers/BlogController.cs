using System.Web.Mvc;
using Personal.DataAccess;

namespace Personal.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Message = "You can find my LinkedIn profile in the footer.";

            var postShortDescriptions = new PostShortDescriptionCollection().GetAll();

            return View(postShortDescriptions);
        }

        public ActionResult Details(int postId)
        {
            var post = new PostShortDescriptionCollection().GetById(postId);

            return View(post);
        }
    }
}