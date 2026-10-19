using System;
using DBLayer;
using System.Globalization;
using System.Collections.Generic;
using System.Data.SqlClient;
using TourManager.Models;

namespace TourManager.Repositories
{
    public class RezervacijaRepository
    {
        public static int DohvatiBrojRezerviranihMjesta(int turaId)
        {
            string sql = $"SELECT ISNULL(SUM(broj_prijavljenih_osoba), 0) FROM Rezervacija WHERE tura_id = {turaId}";

            DB.OpenConnection();
            object rezultat = DB.GetScalar(sql);
            DB.CloseConnection();

            return int.Parse(rezultat.ToString());
        }

        public static int IzracunajBrojSlobodnihMjesta(int turaId, int maksimalanBrojSudionika)
        {
            int brojRezerviranihMjesta = DohvatiBrojRezerviranihMjesta(turaId);
            return maksimalanBrojSudionika - brojRezerviranihMjesta;
        }
        public static bool SpremiRezervaciju(int turaId, int klijentId, int korisnikId, int brojOsoba, decimal ukupanIznos)
        {
            string sql = $"INSERT INTO Rezervacija " +
                         $"(tura_id, klijent_id, korisnik_id, broj_prijavljenih_osoba, datum_rezervacije, ukupan_iznos) " +
                         $"VALUES ({turaId}, {klijentId}, {korisnikId}, {brojOsoba}, GETDATE(), {ukupanIznos.ToString(System.Globalization.CultureInfo.InvariantCulture)})";

            DB.OpenConnection();
            int brojRedaka = DB.ExecuteCommand(sql);
            DB.CloseConnection();

            return brojRedaka > 0;
        }
        public static List<Rezervacija> DohvatiRezervacije()
        {
            List<Rezervacija> rezervacije = new List<Rezervacija>();

            string sql = "SELECT * FROM Rezervacija";

            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Rezervacija rezervacija = CreateObject(reader);
                rezervacije.Add(rezervacija);
            }

            reader.Close();
            DB.CloseConnection();

            return rezervacije;
        }
        public static List<Rezervacija> DohvatiRezervacijePoRazdoblju(DateTime pocetniDatum, DateTime zavrsniDatum)
        {
            List<Rezervacija> rezervacije = new List<Rezervacija>();

            string pocetak = pocetniDatum.ToString("yyyy-MM-dd");
            string kraj = zavrsniDatum.ToString("yyyy-MM-dd");

            string sql = $"SELECT * FROM Rezervacija " +
                         $"WHERE datum_rezervacije >= '{pocetak}' " +
                         $"AND datum_rezervacije <= '{kraj} 23:59:59'";

            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Rezervacija rezervacija = CreateObject(reader);
                rezervacije.Add(rezervacija);
            }

            reader.Close();
            DB.CloseConnection();

            return rezervacije;
        }
        public static bool AzurirajRezervaciju(int rezervacijaId, int brojOsoba, decimal ukupanIznos)
        {
            string sql = $"UPDATE Rezervacija " +
                         $"SET broj_prijavljenih_osoba = {brojOsoba}, " +
                         $"ukupan_iznos = {ukupanIznos.ToString(System.Globalization.CultureInfo.InvariantCulture)} " +
                         $"WHERE rezervacija_id = {rezervacijaId}";

            DB.OpenConnection();
            int brojRedaka = DB.ExecuteCommand(sql);
            DB.CloseConnection();

            return brojRedaka > 0;
        }
        public static bool ObrisiRezervaciju(int rezervacijaId)
        {
            string sql = $"DELETE FROM Rezervacija WHERE rezervacija_id = {rezervacijaId}";

            DB.OpenConnection();
            int brojRedaka = DB.ExecuteCommand(sql);
            DB.CloseConnection();

            return brojRedaka > 0;
        }

        private static Rezervacija CreateObject(SqlDataReader reader)
        {
            Rezervacija rezervacija = new Rezervacija
            {
                RezervacijaId = int.Parse(reader["rezervacija_id"].ToString()),
                TuraId = int.Parse(reader["tura_id"].ToString()),
                KlijentId = int.Parse(reader["klijent_id"].ToString()),
                KorisnikId = int.Parse(reader["korisnik_id"].ToString()),
                BrojPrijavljenihOsoba = int.Parse(reader["broj_prijavljenih_osoba"].ToString()),
                DatumRezervacije = System.DateTime.Parse(reader["datum_rezervacije"].ToString()),
                UkupanIznos = decimal.Parse(reader["ukupan_iznos"].ToString())
            };

            return rezervacija;
        }
    }
}