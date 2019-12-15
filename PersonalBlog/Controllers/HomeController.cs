
using System.Web.Mvc;

namespace PersonalBlog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Anasayfa";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Title = "Hakkımda";
            return View();
        }
    }
}