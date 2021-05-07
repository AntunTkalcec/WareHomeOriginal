using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome.Models.ListaZaKupovinu
{
    public class ListeZaKupovinu
    {
        public string NazivListe { get; set; }
        public bool PrivatnaLista { get; set; }
        public string LozinkaListe { get; set; }
        public ListeZaKupovinu(string naziv, bool privatna, string lozinka)
        {
            NazivListe = naziv;
            PrivatnaLista = privatna;
            LozinkaListe = lozinka;
        }
    }
}
