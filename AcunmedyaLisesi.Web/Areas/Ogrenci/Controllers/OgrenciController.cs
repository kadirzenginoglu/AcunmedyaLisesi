using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaLisesi.Web.Areas.Ogrenci.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly IService<Ogrenciler> _service;

        public OgrenciController(IService<Ogrenciler> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login (Ogrenciler ogrenciler)
        {
            return View();

        }

        public IActionResult GetAll()
        {
            return Json(_service.GetAll());
        }




    }
}
