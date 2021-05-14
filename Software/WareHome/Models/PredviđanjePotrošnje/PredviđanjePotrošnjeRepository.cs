using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHome_Logic;

namespace WareHome.Models.PredviđanjePotrošnje
{
    public static class PredviđanjePotrošnjeRepository
    {
        static Korisnik trenutniKorisnik;

        private static List<Namirnica> DohvatiNamirniceDomaćinstva()
        {
            Database.Instance.Connect();
            List<Namirnica> namirniceDomacinstva = NamirnicaRepository.DohvatiNamirnice(trenutniKorisnik.Domacinstvo);
            Database.Instance.Disconnect();
            return namirniceDomacinstva;
        }

        private static List<Dogadaj> DohvatiDogadaje()
        {
            Database.Instance.Connect();
            List<Dogadaj> dogadaji = DogadajRepository.DohvatiDogadaje();
            Database.Instance.Disconnect();
            return dogadaji;
        }

        private static Korisnik DohvatiTrenutnogKorisnika(Korisnik prijavljeniKorisnik)
        {
            trenutniKorisnik = null;
            trenutniKorisnik = prijavljeniKorisnik;
            return trenutniKorisnik;
        }

        public static List<PredviđenaPotrošnja> PredvidiPotrošnju(Korisnik prijavljeniKorisnik)
        {
            trenutniKorisnik = DohvatiTrenutnogKorisnika(prijavljeniKorisnik);
            List<Namirnica> namirniceDomaćinstva = DohvatiNamirniceDomaćinstva();
            List<Dogadaj> dogadaji = DohvatiDogadaje();
            List<PredviđenaPotrošnja> predviđenaPotrošnja = null;
            predviđenaPotrošnja = new List<PredviđenaPotrošnja>();
            DateTime danas = DateTime.Today;

            foreach (var namirnica in namirniceDomaćinstva)
            {
                int id = namirnica.Identifikator;
                string naziv = namirnica.NazivNamirnice;
                float količina = namirnica.DostupnaKolicina;
                float ukupnoPotrošeno = 0;
                DateTime posljednjaPromjena = DateTime.Today;

                foreach (var item in dogadaji)
                {
                    if (namirnica.Identifikator == item.Namirnica_id && item.Promjena < 0 && item.Datum_dogadaja >= danas.AddMonths(-6))
                    {
                        ukupnoPotrošeno += item.Promjena * (-1);
                        if (item.Datum_dogadaja < posljednjaPromjena)
                        {
                            posljednjaPromjena = item.Datum_dogadaja;
                        }
                    }
                }

                float trajanje = 0;
                
                if (količina != 0)
                {
                    trajanje = IzračunajTrajanje(ukupnoPotrošeno, posljednjaPromjena);
                    trajanje = količina/trajanje;
                    float zaokruzeno = (int)(trajanje);

                    if (trajanje - zaokruzeno != 0 && trajanje - zaokruzeno > 0 && trajanje - zaokruzeno < 1)
                    {
                        trajanje = zaokruzeno + 1;
                    }
                }

                PredviđenaPotrošnja novoPredviđanje = new PredviđenaPotrošnja
                {
                    NamirnicaId = id,
                    NamirnicaNaziv = naziv,
                    DostupnaKoličina = količina,
                    PredviđenoTrajanje = trajanje
                };
                predviđenaPotrošnja.Add(novoPredviđanje);

            }

            return predviđenaPotrošnja;
        }

        private static float IzračunajTrajanje(float ukupnoPotrošeno, DateTime posljednjaPromjena)
        {
            if (ukupnoPotrošeno == 0)
            {
                ukupnoPotrošeno++;
            }
            int brojDana = (int)(DateTime.Today - posljednjaPromjena).TotalDays;
            if (brojDana <= 0)
            {
                brojDana = 1;
            }
            float prosječnoTrajanje = ukupnoPotrošeno / float.Parse(brojDana.ToString());

            return prosječnoTrajanje;
        }
    }
}
