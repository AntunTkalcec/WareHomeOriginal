using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome.Models.ListaZaKupovinu
{
    public class PrikazLista
    {
        public string NazivListe { get; set; }
        public bool PrivatnaLista { get; set; }
        public PrikazLista(string naziv, bool privatna)
        {
            NazivListe = naziv;
            PrivatnaLista = privatna;
        }
    }
}
