using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaLisesi.Web.Controllers
{
    public class BilisimController : Controller
    {
        private readonly IService<Bilisim> _service;

        public BilisimController(IService<Bilisim> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Add(Bilisim bilisim)
        {
            return Ok(_service.Add(bilisim));
            
        }
        public IActionResult Update(Bilisim bilisim)
        {
            return Ok( _service.Update(bilisim));
            
        }

        public IActionResult Delete(Bilisim bilisim)
        {
            _service.Delete(bilisim.Id);
            return Ok();
        }
    }
}
