using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHome_Logic;

namespace WareHome.Models.Raspored
{
    public class Raspored
    {
        public int RasporedId { get; set; }
        public Dan OdabraniDan { get; set; }
        public Sat OdabraniSat { get; set; }
        public Minuta OdabranaMinuta { get; set; }
        public Ponavljanje OdabirPonavljanja { get; set; }
        public Korisnik Korisnik { get; set; }
        public Raspored()
        {
        }
    }
}
