using System.Data.SqlClient;
using DBLayer;
using TourManager.Models;

namespace TourManager.Repositories
{
    public class KorisnikRepository
    {
        public static Korisnik DohvatiKorisnika(string korisnickoIme)
        {
            Korisnik korisnik = null;

            string sigurnoKorisnickoIme = korisnickoIme.Replace("'", "''");
            string sql = $"SELECT * FROM Korisnik WHERE korisnicko_ime = '{sigurnoKorisnickoIme}'";

            DB.OpenConnection();

            SqlDataReader reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                korisnik = CreateObject(reader);
            }

            reader.Close();
            DB.CloseConnection();

            return korisnik;
        }

        private static Korisnik CreateObject(SqlDataReader reader)
        {
            Korisnik korisnik = new Korisnik
            {
                KorisnikId = int.Parse(reader["korisnik_id"].ToString()),
                UlogaId = int.Parse(reader["uloga_id"].ToString()),
                KorisnickoIme = reader["korisnicko_ime"].ToString(),
                Lozinka = reader["lozinka"].ToString()
            };

            return korisnik;
        }
    }
}