using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome.Models.ListaZaKupovinu
{
    public static class NamirnicaNaListiRepository
    {
        public static List<NamirnicaNaListi> PopisNamirnica;
        private static void IspuniPopis()
        {
            PopisNamirnica = new List<NamirnicaNaListi>();
            PopisNamirnica.Add(new NamirnicaNaListi("KTC", "Kruh", "1", "", "KTC"));
            PopisNamirnica.Add(new NamirnicaNaListi("KTC", "Mlijeko", "6", "7,99", ""));
            PopisNamirnica.Add(new NamirnicaNaListi("Zabava u petak", "Jack Daniels 10l", "1", "1499", "KTC"));
            PopisNamirnica.Add(new NamirnicaNaListi("Zabava u petak", "Karlovačko", "20", "8", "KTC"));
            PopisNamirnica.Add(new NamirnicaNaListi("KTC", "Kuhalo za vodu", "", "", ""));
        }

        public static List<NamirnicaNaListi> DohvatiPopisNamirnica(ListaZaKupovinu odabranaLista)
        {
            if (PopisNamirnica == null)
            {
                IspuniPopis();
            }

            List<NamirnicaNaListi> filtrirano = new List<NamirnicaNaListi>();

            foreach (var item in PopisNamirnica)
            {
                if (item.ListaNamirnice == odabranaLista.NazivListe)
                {
                    filtrirano.Add(item);
                }
            }

            return filtrirano;
        }

        public static void DodajNamirnicu(NamirnicaNaListi dodajNamirnicu)
        {
            PopisNamirnica.Add(dodajNamirnicu);
        }

        public static void UkloniNamirnicu(NamirnicaNaListi ukloniNamirnicu)
        {
            PopisNamirnica.Remove(ukloniNamirnicu);
        }
    }
}
