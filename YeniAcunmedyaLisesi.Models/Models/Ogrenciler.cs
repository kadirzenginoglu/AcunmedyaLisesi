namespace AcunmedyaLisesi.Web.Models
{
    public class Ogrenciler : BaseModel
    {
        public int EgitimciId { get; set; }
        public int MatematikId { get; set; }
        public int FenId { get; set; }
        public int BilisimId { get; set; }
        public int SınavId { get; set; }

        public virtual Egitimciler Egitimciler { get; set; }
        public virtual Matematik Matematik { get; set; }
        public virtual Fen Fen { get; set; }
        public virtual Bilisim Bilisim { get; set; }
        public ICollection<Sinavlar> Sınavlar { get; set; } = [];
    }
}
