using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaLisesi.Web.Controllers
{
    public class MatematikController : Controller
    {
        private readonly IService<Matematik> _service;

        public MatematikController(IService<Matematik> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(Matematik matematik)
        {
            return Ok(_service.Add(matematik));
        }
        public IActionResult Update(Matematik matematik)
        {
            return Ok(_service.Update(matematik));
        }

        public IActionResult Delete(Matematik matematik)
        {
            _service.Delete(matematik.Id);
            return Ok();
        }
    }
}
