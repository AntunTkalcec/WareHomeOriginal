using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome.Models.Raspored
{
    public class Dan
    {
        public string DanOdlaska { get; set; }
        public Dan(string dan)
        {
            DanOdlaska = dan;
        }
        public override string ToString()
        {
            return DanOdlaska.ToString();
        }
    }
}
