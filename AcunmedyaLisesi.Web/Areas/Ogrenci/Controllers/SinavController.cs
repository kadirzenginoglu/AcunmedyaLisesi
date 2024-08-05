using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaLisesi.Web.Areas.Ogrenci.Controllers
{
    public class SinavController : Controller
    {
        private readonly IService<Sinavlar> _service;

        public SinavController(IService<Sinavlar> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            return Json(_service.GetAll());
        }
    }
}
