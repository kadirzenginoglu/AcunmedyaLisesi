namespace AcunmedyaLisesi.Web.Models
{
    public class Sinavlar : BaseModel
    {
        public int OgrenciId { get; set; }
        public int FenId { get; set; }
        public int MatematikId { get; set; }
        public int BilisimId { get; set; }

        public ICollection<Ogrenciler> Ogrencilers { get; set; } = [];
        public ICollection<Matematik> Matematik { get; set; } = [];
        public ICollection<Fen> Fen { get; set; } = [];
        public ICollection<Bilisim> Bilisim { get; set; } = [];

    }
}
