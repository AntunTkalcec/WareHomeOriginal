using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome_Logic
{
    public static class KorisnikRepository
    {
        public static Korisnik DohvatiKorisnika(IDataReader dataReader, Domacinstvo domacinstvo)
        {
            Korisnik korisnik = null;

            if (dataReader != null)
            {
                korisnik = new Korisnik();
                korisnik.Identifikator = int.Parse(dataReader["korisnik_id"].ToString());
                korisnik.Ime = dataReader["ime"].ToString();
                korisnik.Prezime = dataReader["prezime"].ToString();
                korisnik.Mail = dataReader["e-mail"].ToString();
                korisnik.Lozinka = dataReader["lozinka"].ToString();
                korisnik.KorisnickoIme = dataReader["korisnicko_ime"].ToString();
                korisnik.DatumRegistracije = DateTime.Parse(dataReader["datum_registracije"].ToString());
                korisnik.DatumZadnjePrijave = DateTime.Parse(dataReader["datum_zadnje_prijave"].ToString());
                korisnik.Domacinstvo = domacinstvo;
            }
            return korisnik;
        }

        public static List<Korisnik> DohvatiKorisnike(Domacinstvo domacinstvo)
        {
            List<Korisnik> lista = new List<Korisnik>();
            string sql = $"SELECT * FROM Korisnik WHERE domacinstvo_id = {domacinstvo.Identifikator}";
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                Korisnik korisnik = DohvatiKorisnika(dataReader, domacinstvo);
                lista.Add(korisnik);
            }
            dataReader.Close();
            return lista;
        }

        public static int Spremi(Korisnik korisnik)
        {
            string sql;
            if (korisnik.Identifikator == 0)
            {
                sql = $"INSERT INTO Korisnik (Ime, Prezime, [e-mail], lozinka, korisnicko_ime, datum_registracije, datum_zadnje_prijave, domacinstvo_id)" +
                    $"VALUES (N'{korisnik.Ime}', N'{korisnik.Prezime}', N'{korisnik.Mail}', '{korisnik.Lozinka}', N'{korisnik.KorisnickoIme}', '{korisnik.DatumRegistracije:yyyyMMdd}', " +
                    $"'{korisnik.DatumZadnjePrijave:yyyyMMdd}', '{korisnik.Domacinstvo.Identifikator}')";
            }
            else
            {
                sql = $"UPDATE Korisnik SET ime = N'{korisnik.Ime}', prezime = N'{korisnik.Prezime}', [e-mail] = N'{korisnik.Mail}', lozinka = '{korisnik.Lozinka}', " +
                    $"korisnicko_ime = N'{korisnik.KorisnickoIme}', datum_registracije = '{korisnik.DatumRegistracije:yyyyMMdd}', datum_zadnje_prijave = '{korisnik.DatumZadnjePrijave:yyyyMMdd}'," +
                    $"domacinstvo_id = {korisnik.Domacinstvo.Identifikator})";
            }
            return Database.Instance.ExecuteCommand(sql);
        }

        public static int Obrisi(Korisnik korisnik)
        {
            string sql = $"DELETE FROM Korisnik WHERE korisnik_id = {korisnik.Identifikator}";
            return Database.Instance.ExecuteCommand(sql);
        }
    }
}
