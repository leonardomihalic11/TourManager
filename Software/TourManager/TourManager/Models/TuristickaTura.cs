using System;

namespace TourManager.Models
{
    public class TuristickaTura
    {
        public int TuraId { get; set; }
        public string NazivTure { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string Trajanje { get; set; }
        public decimal CijenaPoOsobi { get; set; }
        public int MaksimalanBrojSudionika { get; set; }

        public override string ToString()
        {
            return NazivTure;
        }
    }
}