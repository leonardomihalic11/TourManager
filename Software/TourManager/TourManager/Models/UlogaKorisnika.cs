namespace TourManager.Models
{
    public class UlogaKorisnika
    {
        public int UlogaId { get; set; }
        public string NazivUloge { get; set; }

        public override string ToString()
        {
            return NazivUloge;
        }
    }
}