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
        public int IdListe { get; set; }
        public string NazivListe { get; set; }
        public bool PrivatnaLista { get; set; }
        public string LozinkaListe { get; set; }
        public int Domacinstvo { get; set; }
        public ListaZaKupovinu(int id, string naziv, bool privatna, string lozinka, int domacinstvo)
        {
            IdListe = id;
            NazivListe = naziv;
            PrivatnaLista = privatna;
            LozinkaListe = lozinka;
            Domacinstvo = domacinstvo;
        }
    }
}
