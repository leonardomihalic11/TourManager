namespace TourManager.Models
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public bool ProvjeriLozinku(string lozinka)
        {
            return Lozinka == lozinka;
        }

        public override string ToString()
        {
            return KorisnickoIme;
        }
    }
}