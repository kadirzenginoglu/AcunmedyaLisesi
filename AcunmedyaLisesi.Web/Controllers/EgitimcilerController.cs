using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.AspNetCore.Authorization;
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
        //[Authorize("Admin")]- Misafire("User") bu controllerda çalışma imkanının önüne geçmiş oluyoruz.
        public IActionResult Delete(Egitimciler egitimciler)
        {
            _service.Delete(egitimciler.Id);
            return Ok();
        }
    }
}
//Ev (repository)

//Salon - Class
//[koltuk, yemek masası] - Repository (Business) (Misafir(User))
//Oturma Odası - Class- Class
//[Kanepe Tv Çekyat Sehpa]- Repository (Business)(Ev Sahibi(Admin)
//Yatak Odası- Class- Class
//[Yatak Gardılop Tuvalet Masası]- Repository (Business)
//Çocuk Odası- Class- Class
//[Dolap Yatak Çalışma Masası]- Repository (Business
//Banyo- Class- Class
//[Duşakabin tuvalet lavabo]- Repository (Business)
//Tuvalet- Class- Class
//[Tuvalet] - Repository(Business)
//Mutfak- Class- Class
//[Tezgah Dolaplar Beyaz eşya] - Repository(Business)