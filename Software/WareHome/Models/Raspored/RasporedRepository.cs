using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess;
using WareHome_Logic;

namespace WareHome.Models.Raspored
{
    public static class RasporedRepository
    {
        static Korisnik trenutniKorisnik;
        public static Raspored korisnikovRaspored;

        public static Raspored DohvatiRaspored(Korisnik korisnik)
        {
            trenutniKorisnik = null;
            trenutniKorisnik = korisnik;
            korisnikovRaspored = null;
            korisnikovRaspored = DohvatiRasporedZaKorisnika();

            if (korisnikovRaspored == null)
            {
                IzradiNoviRaspored();
                korisnikovRaspored = DohvatiRasporedZaKorisnika();
            }

            return korisnikovRaspored;
        }

        private static void IzradiNoviRaspored()
        {
            string sql = "INSERT INTO Raspored (dan_odlaska, sat_odlaska, minuta_odlaska, ponavljanje, korisnik_id) VALUES "
                + $"('-', '00', '00', 0, {trenutniKorisnik.Identifikator})";
            Database.Instance.Connect();
            Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
        }

        public static void SpremiRaspored(Raspored raspored)
        {
            string sql = $"UPDATE Raspored SET dan_odlaska = '{raspored.OdabraniDan.DanOdlaska}', sat_odlaska = '{raspored.OdabraniSat.SatOdlaska}', minuta_odlaska = '{raspored.OdabranaMinuta.MinutaOdlaska}', ponavljanje = {raspored.OdabirPonavljanja.UcestalostPonavljanja} where korisnik_id = {trenutniKorisnik.Identifikator}";
            Database.Instance.Connect();
            Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
        }

        private static Raspored DohvatiRasporedZaKorisnika()
        {
            string sql = "SELECT * FROM Raspored WHERE korisnik_id = " + trenutniKorisnik.Identifikator;
            Database.Instance.Connect();
            IDataReader reader = Database.Instance.GetDataReader(sql);
            while (reader.Read())
            {
                int id = int.Parse(reader["raspored_id"].ToString());
                string dan = reader["dan_odlaska"].ToString();
                string sat = reader["sat_odlaska"].ToString();
                string minuta = reader["minuta_odlaska"].ToString();
                int ponavljanje = int.Parse(reader["ponavljanje"].ToString());
                Raspored dohvaćeniRaspored = new Raspored
                {
                    Korisnik = trenutniKorisnik,
                    RasporedId = id,
                    OdabraniDan = new Dan(dan),
                    OdabraniSat = new Sat(sat),
                    OdabranaMinuta = new Minuta(minuta),
                    OdabirPonavljanja = new Ponavljanje(ponavljanje)
                };
                korisnikovRaspored = dohvaćeniRaspored;
            }
            Database.Instance.Disconnect();

            return korisnikovRaspored;
        }
    }
}
