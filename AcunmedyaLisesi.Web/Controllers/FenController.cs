using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaLisesi.Web.Controllers
{
    public class FenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
