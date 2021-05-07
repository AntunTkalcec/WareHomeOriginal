using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome.Models.Raspored
{
    public class Raspored
    {
        public Dan OdabraniDan { get; set; }
        public Sat OdabraniSat { get; set; }
        public Minuta OdabranaMinuta { get; set; }
        public Ponavljanje OdabirPonavljanja { get; set; }
        public Raspored()
        {
            OdabraniDan = Dozvoljeno.Dani[0];
            OdabraniSat = Dozvoljeno.Sati[0];
            OdabranaMinuta = Dozvoljeno.Minute[0];
            OdabirPonavljanja = Dozvoljeno.Ponavljanja[0];
        }
    }
}
