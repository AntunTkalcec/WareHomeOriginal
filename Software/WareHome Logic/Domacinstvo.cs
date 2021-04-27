using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome_Logic
{
    public class Domacinstvo
    {
        public int Identifikator { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public List<Korisnik> popisKorisnika { get; set; }
        public Korisnik KorisnikKreator { get; set; }
        public string OpisRadnje { get; set; }
        public DateTime DatumRadnje { get; set; }
        
        public Domacinstvo ()
        {

        }
    }
}
