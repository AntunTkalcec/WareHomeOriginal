using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome_Logic
{
    public static class Dogadaj
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
    }
}
