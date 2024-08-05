using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaLisesi.Web.Controllers
{
    public class OgrencilerController : Controller
    {
        private readonly IService<Ogrenciler> _service;

        public OgrencilerController(IService<Ogrenciler> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(Ogrenciler ogrenciler)
        {
            return Ok(_service.Add(ogrenciler));
        }
        public IActionResult Update(Ogrenciler ogrenciler)
        {
            return Ok(_service.Update(ogrenciler));
        }

        public IActionResult Delete(Ogrenciler ogrenciler)
        {
            _service.Delete(ogrenciler.Id);
            return Ok();
        }
        
        public IActionResult GetByName(string name)
        {
            List<Ogrenciler> ogrenciler = _service.GetByName(name);
            return Ok(ogrenciler);
        }








    }
}
