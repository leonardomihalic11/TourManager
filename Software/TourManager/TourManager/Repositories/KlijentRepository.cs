using DBLayer;

namespace TourManager.Repositories
{
    public class KlijentRepository
    {
        public static int SpremiKlijenta(string imePrezime, string kontakt)
        {
            string sigurnoImePrezime = imePrezime.Replace("'", "''");
            string siguranKontakt = kontakt.Replace("'", "''");

            string sql = $"INSERT INTO Klijent (ime_prezime, kontakt) " +
                         $"VALUES ('{sigurnoImePrezime}', '{siguranKontakt}'); " +
                         $"SELECT SCOPE_IDENTITY();";

            DB.OpenConnection();
            object rezultat = DB.GetScalar(sql);
            DB.CloseConnection();

            return int.Parse(rezultat.ToString());
        }
    }
}