using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome_Logic
{
    public class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public string Lozinka { get; set; }
        public string KorisnickoIme { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public DateTime DatumZadnjePrijave { get; set; }
        public Domacinstvo Domacinstvo { get; set; }
        public bool Prijavljen { get; set; }

        public Korisnik(string ime, string prezime, string mail, string lozinka, string korisnickoIme, DateTime datumRegistracije, DateTime datumZadnjePrijave, Domacinstvo domacinstvo)
        {
            Ime = ime;
            Prezime = prezime;
            Mail = mail;
            Lozinka = lozinka;
            KorisnickoIme = korisnickoIme;
            DatumRegistracije = datumRegistracije;
            DatumZadnjePrijave = datumZadnjePrijave;
            Domacinstvo = domacinstvo;
        }
    }
}
