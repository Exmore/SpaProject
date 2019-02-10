using System.Web.Mvc;

namespace SpaProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();            
        }
    }
}