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
        [DisplayName("ID")]
        public int Identifikator { get; set; }
        [DisplayName("Naziv namirnice")]
        public string NazivNamirnice { get; set; }
        [DisplayName("Dostupna količina")]
        public float DostupnaKolicina { get; set; }
        [DisplayName("Optimalna količina")]
        public float OptimalnaKolicina { get; set; }
        [DisplayName("Mjerna jedinica")]
        public string MjernaJedinica { get; set; }
        [DisplayName("Cijena")]
        public string Cijena { get; set; }
        [DisplayName("Dućan")]
        public string Ducan { get; set; }
        [DisplayName("Zadnja promjena")]
        public DateTime DatumZadnjePromjene { get; set; }
        [DisplayName("Domaćinstvo")]
        public Domacinstvo Domacinstvo { get; set; }

        public Namirnica()
        {
        }
    }
}
