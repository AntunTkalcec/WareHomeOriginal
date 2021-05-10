using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome.Models.ListaZaKupovinu
{
    public static class ListaZaKupovinuRepository
    {
        public static List<ListaZaKupovinu> PopisLista;

        public static void IspuniPopisLista()
        {
            PopisLista = new List<ListaZaKupovinu>();
            PopisLista.Add(new ListaZaKupovinu("KTC", false, null));
            PopisLista.Add(new ListaZaKupovinu("Zabava u petak", true, "123"));
        }

        public static List<ListaZaKupovinu> DohvatiPopisLista()
        {
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
                PopisLista.Add(new ListaZaKupovinu(naziv, privatna, lozinka));
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Uneseni naziv se već koristi!");
            }
        }
        
        public static void UkloniListu(ListaZaKupovinu ukloniListu)
        {
            List<ListaZaKupovinu> filtrirano = new List<ListaZaKupovinu>();
            foreach (var item in PopisLista)
            {
                if (item.NazivListe.ToLower() != ukloniListu.NazivListe.ToLower())
                {
                    filtrirano.Add(item);
                }
            }
            PopisLista.Clear();
            PopisLista = filtrirano;
        }
    }
}
