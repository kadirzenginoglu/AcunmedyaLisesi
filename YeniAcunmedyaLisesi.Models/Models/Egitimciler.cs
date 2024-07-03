namespace AcunmedyaLisesi.Web.Models
{
    public class Egitimciler : BaseModel
    {
        public int MatematikId { get; set; }
        public int FenId { get; set; }
        public int BilisimId { get; set; }

        public virtual Matematik Matematik { get; set; }
        public virtual Fen Fen { get; set; }
        public virtual Bilisim Bilisim { get; set; }
        
    }
}
