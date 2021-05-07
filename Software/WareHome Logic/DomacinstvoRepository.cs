using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome_Logic
{
    public static class DomacinstvoRepository
    {
        public static Domacinstvo DohvatiDomacinstvo(IDataReader dataReader)
        {
            Domacinstvo domacinstvo = null;
            if (dataReader != null)
            {
                domacinstvo = new Domacinstvo();
                domacinstvo.Identifikator = int.Parse(dataReader["domacinstvo_id"].ToString());
                domacinstvo.Naziv = dataReader["naziv"].ToString();
                domacinstvo.DatumKreiranja = DateTime.Parse(dataReader["datum_kreiranja"].ToString());
                domacinstvo.KorisnikKreator = dataReader["korisnik_kreator"].ToString();
                domacinstvo.OpisRadnje = dataReader["opis_radnje"].ToString();
                domacinstvo.DatumRadnje = DateTime.Parse(dataReader["datum_radnje"].ToString());
            }
            return domacinstvo;
        }

        public static int Spremi(Domacinstvo domacinstvo)
        {
            string sql;
            if (domacinstvo.Identifikator == 0)
            {
                sql = $"INSERT INTO Domacinstvo (naziv, datum_kreiranja, korisnik_kreator, opis_radnje, datum_radnje) VALUES ('{domacinstvo.Naziv}', " +
                    $"'{domacinstvo.DatumKreiranja:yyyyMMdd}', '{domacinstvo.KorisnikKreator}', '{domacinstvo.OpisRadnje}', '{domacinstvo.DatumRadnje:yyyyMMdd}')";
            }
            else
            {
                sql = $"UPDATE Domacinstvo SET naziv = '{domacinstvo.Naziv}', datum_kreiranja = '{domacinstvo.DatumKreiranja:yyyyMMdd}', korisnik_kreator = '{domacinstvo.KorisnikKreator}', " +
                    $"opis_radnje = '{domacinstvo.OpisRadnje}', datum_radnje = '{domacinstvo.DatumRadnje:yyyyMMdd}' WHERE domacinstvo_id = {domacinstvo.Identifikator}";
            }
            return Database.Instance.ExecuteCommand(sql);
        }
    }
}
