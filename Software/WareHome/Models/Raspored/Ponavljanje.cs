using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome.Models.Raspored
{
    public class Ponavljanje
    {
        public int UcestalostPonavljanja { get; set; }
        public Ponavljanje(int ponavljanje)
        {
            UcestalostPonavljanja = ponavljanje;
        }
        public override string ToString()
        {
            return UcestalostPonavljanja.ToString();
        }
    }
}
