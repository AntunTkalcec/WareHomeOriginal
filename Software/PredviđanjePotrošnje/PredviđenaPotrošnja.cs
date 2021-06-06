using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredviđanjePotrošnje
{
    public class PredviđenaPotrošnja
    {
        public int NamirnicaId { get; set; }
        public string NamirnicaNaziv { get; set; }
        public float DostupnaKoličina { get; set; }
        public string MjernaJedinica { get; set; }
        public float PredviđenoTrajanje { get; set; }
        public PredviđenaPotrošnja()
        {

        }
    }
}
