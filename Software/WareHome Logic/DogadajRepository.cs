using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome_Logic
{
    public static class DogadajRepository
    {
        public static int Spremi(Namirnica namirnica, float promjena)
        {
            string sql = "";
            if (namirnica.Identifikator != 0)
            {
                sql = $"INSERT INTO Dogadaj (id_namirnice, promjena, datum_dogadaja) VALUES ({namirnica.Identifikator}, {promjena}, '{namirnica.DatumZadnjePromjene:yyyyMMdd}')";
            }
            return Database.Instance.ExecuteCommand(sql);
        }

        public static List<Dogadaj> DohvatiDogadaje()
        {
            List<Dogadaj> dogadaji = new List<Dogadaj>();
            string sql = "SELECT * FROM Dogadaj";
            Database.Instance.Connect();
            IDataReader reader = Database.Instance.GetDataReader(sql);
            while (reader.Read())
            {
                int dogadaj_id = int.Parse(reader["dogadaj_id"].ToString());
                int namirnica_id = int.Parse(reader["id_namirnice"].ToString());
                float promjena = float.Parse(reader["promjena"].ToString());
                DateTime datum = DateTime.Parse(reader["datum_dogadaja"].ToString());

                Dogadaj dogadaj = new Dogadaj
                {
                    Dogadaj_id = dogadaj_id,
                    Namirnica_id = namirnica_id,
                    Promjena = promjena,
                    Datum_dogadaja = datum
                };

                dogadaji.Add(dogadaj);
            }
            Database.Instance.Disconnect();

            return dogadaji;
        }
    }
}
