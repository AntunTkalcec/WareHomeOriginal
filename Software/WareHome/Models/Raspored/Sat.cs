using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome.Models.Raspored
{
    public class Sat
    {
        public string SatOdlaska { get; set; }
        public Sat(string sat)
        {
            SatOdlaska = sat;
        }
        public override string ToString()
        {
            return SatOdlaska.ToString();
        }
    }
}
