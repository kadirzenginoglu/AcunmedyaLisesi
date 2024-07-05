using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaLisesi.Web.Controllers
{
    public class EgitimcilerController : Controller
    {
        private readonly IService<Egitimciler> _service;

        public EgitimcilerController(IService<Egitimciler> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(Egitimciler egitimciler)
        {
            return Ok(_service.Add(egitimciler));
        }
        public IActionResult Update(Egitimciler egitimciler)
        {
            return Ok(_service.Update(egitimciler));
        }

        public IActionResult Delete(Egitimciler egitimciler)
        {
            _service.Delete(egitimciler.Id);
            return Ok();
        }
    }
}
