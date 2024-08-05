using YeniAcunmedyaLisesi.Models.Models;

namespace AcunmedyaLisesi.Web.Models
{
    public class Ogrenciler : BaseModel
    {
        //public string DenemeEkleme { get; set; }
        public ICollection<Dersler> Dersler { get; set; } = [];
        public ICollection<Sinavlar> Sınavlar { get; set; } = [];
    }
}
