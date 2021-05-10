using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHome_Logic;
using DatabaseAccess;
using System.Data;

namespace WareHome.Models.ListaZaKupovinu
{
    public static class ListaZaKupovinuRepository
    {
        public static List<ListaZaKupovinu> PopisLista;
        public static Korisnik trenutniKorisnik;
        public static string NoviNaziv;

        private static void IspuniPopisLista()
        { 
            PopisLista = new List<ListaZaKupovinu>();
            Database.Instance.Connect();
            string sql = "SELECT * FROM Lista_za_kupovinu WHERE Lista_za_kupovinu.domacinstvo_id = " + trenutniKorisnik.Domacinstvo.Identifikator;
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                if (dataReader != null)
                {
                    int id = int.Parse(dataReader["lista_id"].ToString());
                    string naziv = dataReader["naziv_liste"].ToString();
                    int privat = int.Parse(dataReader["privatna_lista"].ToString());
                    bool privatna;
                    string lozinka = dataReader["lozinka_liste"].ToString();
                    int domacinstvo = int.Parse(dataReader["domacinstvo_id"].ToString());
                    if (privat == 0)
                    {
                        privatna = false;
                    }
                    else
                    {
                        privatna = true;
                    }
                    ListaZaKupovinu listaZaKupovinu = new ListaZaKupovinu(id, naziv, privatna, lozinka, domacinstvo);
                    PopisLista.Add(listaZaKupovinu);
                }
            }
        }

        public static List<ListaZaKupovinu> DohvatiPopisLista(Korisnik korisnik)
        {
            trenutniKorisnik = null;
            trenutniKorisnik = korisnik;
            PopisLista = null;
            IspuniPopisLista();
            return PopisLista;
        }

        public static void DodajListu(string naziv, bool privatna, string lozinka)
        {
            bool duplikat = false;
            foreach (var item in PopisLista)
            {
                if (naziv.ToLower() == item.NazivListe.ToLower())
                {
                    duplikat = true;
                }
            }

            if (!duplikat)
            {
                int privatnaInt = 0;
                if (privatna)
                {
                    privatnaInt = 1;
                }
                Database.Instance.Connect();
                string sql = "INSERT INTO Lista_za_kupovinu (naziv_liste, privatna_lista, lozinka_liste, domacinstvo_id) VALUES " +
                    $"('{naziv}', {privatnaInt}, '{lozinka}', {trenutniKorisnik.Domacinstvo.Identifikator})";
                Database.Instance.ExecuteCommand(sql);
                Database.Instance.Disconnect();
                PopisLista = null;
                IspuniPopisLista();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Uneseni naziv se već koristi!");
            }
        }
        
        public static void UkloniListu(ListaZaKupovinu ukloniListu)
        {
            Database.Instance.Connect();
            string sql1 = "DELETE FROM Namirnica_na_listi WHERE lista_id = " + ukloniListu.IdListe;
            Database.Instance.ExecuteCommand(sql1);
            string sql2 = "DELETE FROM Lista_za_kupovinu WHERE lista_id = " + ukloniListu.IdListe;
            Database.Instance.ExecuteCommand(sql2);
            Database.Instance.Disconnect();
            PopisLista = null;
            IspuniPopisLista();
        }

        public static void PreimenujListu(ListaZaKupovinu preimenujListu, string naziv, bool privatna, string lozinka)
        {
            int privatnaInt = 0;
            if (privatna)
            {
                privatnaInt = 1;
            }
            Database.Instance.Connect();
            string sql = $"UPDATE Lista_za_kupovinu SET naziv_liste = '{naziv}', privatna_lista = {privatnaInt}, lozinka_liste = '{lozinka}' WHERE lista_id = {preimenujListu.IdListe}";
            Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            PopisLista = null;
            IspuniPopisLista();
            NoviNaziv = naziv;
        }
    }
}
