using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}