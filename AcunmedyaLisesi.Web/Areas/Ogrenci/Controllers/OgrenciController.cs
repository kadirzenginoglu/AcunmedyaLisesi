using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;
using YeniAcunmedyaLisesi.Models.Dto;

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
        

        public IActionResult GetAll()
        {
            return Json(_service.GetAll());
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login (LoginDto loginDto)
        {
            return Ok(loginDto);
        }





    }
}
