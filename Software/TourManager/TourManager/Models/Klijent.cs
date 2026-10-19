namespace TourManager.Models
{
    public class Klijent
    {
        public int KlijentId { get; set; }
        public string ImePrezime { get; set; }
        public string Kontakt { get; set; }

        public override string ToString()
        {
            return ImePrezime;
        }
    }
}