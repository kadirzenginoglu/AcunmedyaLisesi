using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using AcunmedyaUzmanlık.Business.Shared.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using YeniAcunmedyaLisesi.Models.Dto;
using YeniAcunmedyaLisesi.Models.Models;

namespace AcunmedyaLisesi.Web.Areas.Ogretmen.Controllers
{
    [Area("Ogretmen")]
    public class OgretmenController : Controller
    {
        private readonly IService<Egitimciler> _service;
        private readonly IUserService _userService;
        

        public OgretmenController(IService<Egitimciler> service, IUserService userservice)
        {
            _service = service;
            _userService = userservice;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginDto loginDto)
        {

            User user = _userService.Login(loginDto);
            if (user == null) {
                return RedirectToAction("Login");
            }

            return RedirectToAction("Index");
        }



        public IActionResult GetAll()
        {
            return Json(_service.GetAll());
        }


        



    }
}
