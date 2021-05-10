using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess;

namespace WareHome.Models.ListaZaKupovinu
{
    public static class NamirnicaNaListiRepository
    {
        public static List<NamirnicaNaListi> PopisNamirnica;
        static ListaZaKupovinu listaZaKupovinu;
        private static void IspuniPopis()
        {
            PopisNamirnica = new List<NamirnicaNaListi>();
            Database.Instance.Connect();
            string sql = "SELECT * FROM Namirnica_na_listi WHERE Namirnica_na_listi.lista_id = " + listaZaKupovinu.IdListe;
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                if (dataReader != null)
                {
                    int id = int.Parse(dataReader["namirnicaNaListi_id"].ToString());
                    string naziv = dataReader["naziv_namirniceNaListi"].ToString();
                    string kolicina = dataReader["kolicina_namirniceNaListi"].ToString();
                    string cijena = dataReader["cijena_namirniceNaListi"].ToString();
                    string trgovina = dataReader["trgovina_namirniceNaListi"].ToString();
                   
                    NamirnicaNaListi namirnica = new NamirnicaNaListi(id, listaZaKupovinu.IdListe, naziv, kolicina, cijena, trgovina);
                    PopisNamirnica.Add(namirnica);
                }
            }
            Database.Instance.Disconnect();
        }

        public static List<NamirnicaNaListi> DohvatiPopisNamirnica(ListaZaKupovinu odabranaLista)
        {
            listaZaKupovinu = odabranaLista;

            if (PopisNamirnica == null)
            {
                IspuniPopis();
            }

            return PopisNamirnica;
        }

        public static void DodajNamirnicu(NamirnicaNaListi dodajNamirnicu)
        {
            Database.Instance.Connect();
            string sql = "INSERT INTO Namirnica_na_listi (lista_id, naziv_namirniceNaListi, kolicina_namirniceNaListi, cijena_namirniceNaListi, trgovina_namirniceNaListi) VALUES " +
                $"({dodajNamirnicu.ListaNamirnice}, '{dodajNamirnicu.NazivNamirnice}', '{dodajNamirnicu.KoličinaNamirnice}', '{dodajNamirnicu.CijenaNamirnice}', '{dodajNamirnicu.TrgovinaNamirnice}')";
            Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            PopisNamirnica = null;
            IspuniPopis();
        }

        public static void UkloniNamirnicu(NamirnicaNaListi ukloniNamirnicu)
        {
            Database.Instance.Connect();
            string sql = "DELETE FROM Namirnica_na_listi WHERE namirnicaNaListi_id = " + ukloniNamirnicu.IdNamirnice;
            Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            PopisNamirnica = null;
            IspuniPopis();
        }
    }
}
