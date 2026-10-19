using System.Collections.Generic;
using System.Data.SqlClient;
using DBLayer;
using TourManager.Models;

namespace TourManager.Repositories
{
    public class TuraRepository
    {
        public static List<TuristickaTura> DohvatiTure()
        {
            List<TuristickaTura> ture = new List<TuristickaTura>();

            string sql = "SELECT * FROM TuristickaTura";

            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                TuristickaTura tura = CreateObject(reader);
                ture.Add(tura);
            }

            reader.Close();
            DB.CloseConnection();

            return ture;
        }

        public static List<TuristickaTura> PretraziTure(string nazivTure)
        {
            List<TuristickaTura> ture = new List<TuristickaTura>();

            string siguranNaziv = nazivTure.Replace("'", "''");
            string sql = $"SELECT * FROM TuristickaTura WHERE naziv_ture LIKE '%{siguranNaziv}%'";

            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                TuristickaTura tura = CreateObject(reader);
                ture.Add(tura);
            }

            reader.Close();
            DB.CloseConnection();

            return ture;
        }

        public static TuristickaTura DohvatiTuru(int turaId)
        {
            TuristickaTura tura = null;

            string sql = $"SELECT * FROM TuristickaTura WHERE tura_id = {turaId}";

            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                tura = CreateObject(reader);
            }

            reader.Close();
            DB.CloseConnection();

            return tura;
        }
        public static bool DodajTuru(TuristickaTura tura)
        {
            string siguranNaziv = tura.NazivTure.Replace("'", "''");
            string sigurnoTrajanje = tura.Trajanje.Replace("'", "''");

            string cijena = tura.CijenaPoOsobi.ToString(System.Globalization.CultureInfo.InvariantCulture);
            string datum = tura.DatumVrijeme.ToString("yyyy-MM-dd HH:mm:ss");

            string sql = $"INSERT INTO TuristickaTura " +
                         $"(naziv_ture, datum_vrijeme, trajanje, cijena_po_osobi, maksimalan_broj_sudionika) " +
                         $"VALUES ('{siguranNaziv}', '{datum}', '{sigurnoTrajanje}', {cijena}, {tura.MaksimalanBrojSudionika})";

            DB.OpenConnection();
            int brojRedaka = DB.ExecuteCommand(sql);
            DB.CloseConnection();

            return brojRedaka > 0;
        }

        private static TuristickaTura CreateObject(SqlDataReader reader)
        {
            TuristickaTura tura = new TuristickaTura
            {
                TuraId = int.Parse(reader["tura_id"].ToString()),
                NazivTure = reader["naziv_ture"].ToString(),
                DatumVrijeme = System.DateTime.Parse(reader["datum_vrijeme"].ToString()),
                Trajanje = reader["trajanje"].ToString(),
                CijenaPoOsobi = decimal.Parse(reader["cijena_po_osobi"].ToString()),
                MaksimalanBrojSudionika = int.Parse(reader["maksimalan_broj_sudionika"].ToString())
            };

            return tura;
        }
        public static bool AzurirajTuru(TuristickaTura tura)
        {
            string siguranNaziv = tura.NazivTure.Replace("'", "''");
            string sigurnoTrajanje = tura.Trajanje.Replace("'", "''");

            string cijena = tura.CijenaPoOsobi.ToString(System.Globalization.CultureInfo.InvariantCulture);
            string datum = tura.DatumVrijeme.ToString("yyyy-MM-dd HH:mm:ss");

            string sql = $"UPDATE TuristickaTura SET " +
                         $"naziv_ture = '{siguranNaziv}', " +
                         $"datum_vrijeme = '{datum}', " +
                         $"trajanje = '{sigurnoTrajanje}', " +
                         $"cijena_po_osobi = {cijena}, " +
                         $"maksimalan_broj_sudionika = {tura.MaksimalanBrojSudionika} " +
                         $"WHERE tura_id = {tura.TuraId}";

            DB.OpenConnection();
            int brojRedaka = DB.ExecuteCommand(sql);
            DB.CloseConnection();

            return brojRedaka > 0;
        }

        public static bool ObrisiTuru(int turaId)
        {
            string sql = $"DELETE FROM TuristickaTura WHERE tura_id = {turaId}";

            DB.OpenConnection();
            int brojRedaka = DB.ExecuteCommand(sql);
            DB.CloseConnection();

            return brojRedaka > 0;
        }
    }
}