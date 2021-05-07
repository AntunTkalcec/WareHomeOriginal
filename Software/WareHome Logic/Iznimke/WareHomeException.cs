using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome_Logic.Iznimke
{
    public class WareHomeException : ApplicationException
    {
        public string Poruka { get; set; }

        public WareHomeException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
