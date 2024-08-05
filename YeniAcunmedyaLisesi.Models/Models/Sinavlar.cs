using YeniAcunmedyaLisesi.Models.Models;

namespace AcunmedyaLisesi.Web.Models
{
    public class Sinavlar : BaseModel
    {
        public int DerslerId { get; set; }

        public virtual Dersler Dersler { get; set; }

    }
}
