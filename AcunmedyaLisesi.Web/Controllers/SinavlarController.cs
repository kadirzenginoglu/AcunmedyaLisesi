using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaLisesi.Web.Controllers
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
            return Ok(_service.Update(sinavlar));
        }

        public IActionResult Delete(Sinavlar sinavlar)
        {
            _service.Delete(sinavlar.Id);
            return Ok();
        }
    }
}
