namespace AcunmedyaLisesi.Web.Models
{
    public class Bilisim : BaseModel
    {
        public int OgrenciId { get; set; }
        public int SınavId { get; set; }
        public int EgitimciId { get; set; }
        public ICollection<Egitimciler> Egitimciler { get; set; } = [];
        public ICollection<Ogrenciler> Ogrenciler { get; set; } = [];
        public ICollection<Sınavlar> Sınavlars { get; set; } = [];
    }
}
