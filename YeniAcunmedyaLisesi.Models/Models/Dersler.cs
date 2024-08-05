using AcunmedyaLisesi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniAcunmedyaLisesi.Models.Models
{
    public class Dersler : BaseModel
    {
        public string DersAdi { get; set; }



        public ICollection<Egitimciler> Egitimci { get; set; } = [];
        public ICollection<Sinavlar> Sinavlar { get; set; } = [];



    }
}
