using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaLisesi.Web.Areas.Ogretmen.Controllers
{
    public class SinavlarController : Controller
    {
        private readonly IService<Sinavlar> _service;

        public SinavlarController(IService<Sinavlar> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(Sinavlar sinavlar)
        {
            return Ok(_service.Add(sinavlar));
        }

        public IActionResult Update(Sinavlar sinavlar)
        {
            _service.Update(sinavlar);
            return Ok(sinavlar);
        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }

        public IActionResult GetAll()
        {
            return Json(_service.GetAll());
        }





    }
}
