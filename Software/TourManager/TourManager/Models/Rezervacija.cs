using System;

namespace TourManager.Models
{
    public class Rezervacija
    {
        public int RezervacijaId { get; set; }
        public int TuraId { get; set; }
        public int KlijentId { get; set; }
        public int KorisnikId { get; set; }
        public int BrojPrijavljenihOsoba { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public decimal UkupanIznos { get; set; }
    }
}