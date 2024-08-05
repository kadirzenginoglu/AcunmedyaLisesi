using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;
using YeniAcunmedyaLisesi.Models.Models;

namespace AcunmedyaLisesi.Web.Controllers
{
    public class DerslerController : Controller
    {
        private readonly IService<Dersler> _service;

        public DerslerController(IService<Dersler> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(Dersler dersler)
        {
            return Ok(_service.Add(dersler));
        }

        public IActionResult Update(Dersler dersler)
        {
            return Ok(_service.Update(dersler));
        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok(id);
        }
        

    }
}
