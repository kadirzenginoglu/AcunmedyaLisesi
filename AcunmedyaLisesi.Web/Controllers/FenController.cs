using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaLisesi.Web.Controllers
{
    public class FenController : Controller
    {
        private readonly IService<Fen> _service;

        public FenController(IService<Fen> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(Fen fen)
        {
            return Ok(_service.Add(fen));
        }
        public IActionResult Update(Fen fen)
        {
            return Ok(_service.Update(fen));
        }

        public IActionResult Delete(Fen fen)
        {
            _service.Delete(fen.Id);
            return Ok();
        }
    }
}
