using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome_Logic
{
    public class Namirnica
    {
        public string NazivNamirnice { get; set; }
        public int DostupnaKolicina { get; set; }
        public int OptimalnaKolicina { get; set; }
        public string Cijena { get; set; }
        public string Ducan { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public DateTime DatumZadnjePromjene { get; set; }
        public string KorisnikKreator { get; set; }
        public Domacinstvo Domacinstvo { get; set; }

        public Namirnica(string nazivNamirnice, int dostupnaKolicina, int optimalnaKolicina, string cijena, string ducan, DateTime datumKreiranja, 
            DateTime datumZadnjePromjene, string korisnikKreator, Domacinstvo domacinstvo)
        {
            NazivNamirnice = nazivNamirnice;
            DostupnaKolicina = dostupnaKolicina;
            OptimalnaKolicina = optimalnaKolicina;
            Cijena = cijena;
            Ducan = ducan;
            DatumKreiranja = datumKreiranja;
            DatumZadnjePromjene = datumZadnjePromjene;
            KorisnikKreator = korisnikKreator;
            Domacinstvo = domacinstvo;
        }
    }
}
