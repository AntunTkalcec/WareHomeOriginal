using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome_Logic
{
    public class Domacinstvo
    {
        public int Identifikator { get; set; }
        [DisplayName("Naziv domaćinstva")]
        public string Naziv { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public string KorisnikKreator { get; set; }
        public string OpisRadnje { get; set; }
        public DateTime DatumRadnje { get; set; }
        
        public Domacinstvo ()
        {

        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
