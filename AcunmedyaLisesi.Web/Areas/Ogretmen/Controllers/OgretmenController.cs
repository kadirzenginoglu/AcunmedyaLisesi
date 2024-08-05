using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaLisesi.Web.Areas.Ogretmen.Controllers
{
    public class OgretmenController : Controller
    {
        private readonly IService<Egitimciler> _service;
        

        public OgretmenController(IService<Egitimciler> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login (Egitimciler egitimciler)
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(_service.GetAll());
        }





    }
}
