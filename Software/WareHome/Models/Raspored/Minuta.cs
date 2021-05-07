using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome.Models.Raspored
{
    public class Minuta
    {
        public string MinutaOdlaska { get; set; }
        public Minuta(string minuta)
        {
            MinutaOdlaska = minuta;
        }
        public override string ToString()
        {
            return MinutaOdlaska.ToString();
        }
    }
}
