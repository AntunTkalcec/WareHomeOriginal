using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome_Logic
{
    public static class NamirnicaRepository
    {
        public static Namirnica DohvatiNamirnicu(IDataReader dataReader, Domacinstvo domacinstvo)
        {
            Namirnica namirnica = null;
            if (dataReader != null)
            {
                namirnica = new Namirnica();
                namirnica.Identifikator = int.Parse(dataReader["namirnica_id"].ToString());
                namirnica.NazivNamirnice = dataReader["naziv_namirnice"].ToString();
                namirnica.DostupnaKolicina = float.Parse(dataReader["dostupna_kolicina"].ToString());
                namirnica.OptimalnaKolicina = float.Parse(dataReader["optimalna_kolicina"].ToString());
                namirnica.MjernaJedinica = dataReader["mjerna_jedinica"].ToString();
                namirnica.Cijena = dataReader["cijena"].ToString();
                namirnica.Ducan = dataReader["ducan"].ToString();
                namirnica.DatumZadnjePromjene = DateTime.Parse(dataReader["datum_zadnje_promjene"].ToString());
                namirnica.Domacinstvo = domacinstvo;
            }
            return namirnica;
        }

        public static List<Namirnica> DohvatiNamirnice(Domacinstvo domacinstvo)
        {
            List<Namirnica> lista = new List<Namirnica>();
            string sql = $"SELECT * FROM Namirnica WHERE domacinstvo_id = {domacinstvo.Identifikator}";
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                Namirnica namirnica = DohvatiNamirnicu(dataReader, domacinstvo);
                lista.Add(namirnica);
            }
            dataReader.Close();
            return lista;
        }

        public static int Spremi(Namirnica namirnica)
        {
            string sql;
            if (namirnica.Identifikator == 0)
            {
                sql = $"INSERT INTO Namirnica (naziv_namirnice, dostupna_kolicina, optimalna_kolicina, mjerna_jedinica, " +
                    $"cijena, ducan, datum_zadnje_promjene, domacinstvo_id) VALUES " +
                    $"(N'{namirnica.NazivNamirnice}', '{namirnica.DostupnaKolicina}', '{namirnica.OptimalnaKolicina}', " +
                    $"'{namirnica.MjernaJedinica}', '{namirnica.Cijena}', N'{namirnica.Ducan}', '{namirnica.DatumZadnjePromjene:yyyyMMdd}', " +
                    $"'{namirnica.Domacinstvo.Identifikator}')";
            }
            else
            {
                sql = $"UPDATE Namirnica SET naziv_namirnice = N'{namirnica.NazivNamirnice}', dostupna_kolicina = '{namirnica.DostupnaKolicina}', optimalna_kolicina = '{namirnica.OptimalnaKolicina}', " +
                    $"mjerna_jedinica = '{namirnica.MjernaJedinica}', cijena = '{namirnica.Cijena}', ducan = N'{namirnica.Ducan}', " +
                    $"datum_zadnje_promjene = '{namirnica.DatumZadnjePromjene:yyyyMMdd}', domacinstvo_id = '{namirnica.Domacinstvo.Identifikator}' " +
                    $"WHERE namirnica_id = {namirnica.Identifikator}";
            }
            return Database.Instance.ExecuteCommand(sql);
        }

        public static int Obrisi(Namirnica namirnica)
        {
            string sql = $"DELETE FROM Dogadaj WHERE id_namirnice = {namirnica.Identifikator}";
            Database.Instance.ExecuteCommand(sql);
            sql = $"DELETE FROM Namirnica WHERE namirnica_id = {namirnica.Identifikator}";
            return Database.Instance.ExecuteCommand(sql);
        }
    }
}
