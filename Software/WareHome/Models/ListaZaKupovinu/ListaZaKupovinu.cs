using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHome_Logic;

namespace WareHome.Models.ListaZaKupovinu
{
    public class ListaZaKupovinu
    {
        public string NazivListe { get; set; }
        public bool PrivatnaLista { get; set; }
        public string LozinkaListe { get; set; }
        //public string KorisnikKreator { get; set; }
        public ListaZaKupovinu(string naziv, bool privatna, string lozinka)
        {
            NazivListe = naziv;
            PrivatnaLista = privatna;
            LozinkaListe = lozinka;
            //KorisnikKreator = trenutniKorisnik.KorisnickoIme;
        }
    }
}
