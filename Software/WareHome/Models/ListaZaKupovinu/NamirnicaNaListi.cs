using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome.Models.ListaZaKupovinu
{
    public class NamirnicaNaListi
    {
        public int IdNamirnice { get; set; }
        public int ListaNamirnice { get; set; }
        public string NazivNamirnice { get; set; }
        public string KoličinaNamirnice { get; set; }
        public string CijenaNamirnice { get; set; }
        public string TrgovinaNamirnice { get; set; }
        public NamirnicaNaListi(int id, int lista, string naziv, string kolicina, string cijena, string trgovina)
        {
            IdNamirnice = id;
            ListaNamirnice = lista;
            NazivNamirnice = naziv;
            KoličinaNamirnice = kolicina;
            CijenaNamirnice = cijena;
            TrgovinaNamirnice = trgovina;
        }
    }
}
