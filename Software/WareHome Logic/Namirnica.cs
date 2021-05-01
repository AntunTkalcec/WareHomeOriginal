using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome_Logic
{
    public class Namirnica
    {
        public int Identifikator { get; set; }
        [DisplayName("Naziv namirnice")]
        public string NazivNamirnice { get; set; }
        [DisplayName("Dostupna količina")]
        public float DostupnaKolicina { get; set; }
        [DisplayName("Optimalna količina")]
        public float OptimalnaKolicina { get; set; }
        [DisplayName("Mjerna jedinica")]
        public string MjernaJedinica { get; set; }
        [DisplayName("Cijena namirnice")]
        public float Cijena { get; set; }
        [DisplayName("Dućan za kupiti")]
        public string Ducan { get; set; }
        [DisplayName("Namirnica kreirana")]
        public DateTime DatumKreiranja { get; set; }
        [DisplayName("Namirnica zadnje promijenjena")]
        public DateTime DatumZadnjePromjene { get; set; }
        [DisplayName("Kreator namirnice")]
        public string KorisnikKreator { get; set; }
        [DisplayName("Domaćinstvo")]
        public Domacinstvo Domacinstvo { get; set; }

        public Namirnica()
        {
        }
    }
}
