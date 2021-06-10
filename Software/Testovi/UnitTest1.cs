using DatabaseAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using WareHome;
using WareHome_Logic;

namespace Testovi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Database.Instance.Connect();
            Domacinstvo domacinstvo = new Domacinstvo()
            {
                Identifikator = 0,
                Naziv = "TestDomacinstvo",
                DatumKreiranja = DateTime.Today
            };

            Assert.IsNotNull(DomacinstvoRepository.Spremi(domacinstvo));
            Database.Instance.Disconnect();
        }

        [TestMethod]
        public void Provjera_upis_dogadaja()
        {
            Domacinstvo dom = new Domacinstvo()
            {
                Identifikator = 2,
                Naziv = "Habdija",
                DatumKreiranja = DateTime.Parse("2021-05-10"),
            };
            Namirnica namirnica = new Namirnica()
            {
                Identifikator = 13,
                NazivNamirnice = "Jaja",
                DostupnaKolicina = 6,
                OptimalnaKolicina = 4,
                MjernaJedinica = "kom",
                Cijena = "9.99",
                Ducan = "Lidl",
                DatumZadnjePromjene = DateTime.Parse("2021-05-16"),
                Domacinstvo = dom
            };
            Database.Instance.Connect();

            Assert.IsNotNull(DogadajRepository.Spremi(namirnica, 10));
            Database.Instance.Disconnect();
        }

        [TestMethod]
        public void Provjera_dohvacanja_dogadaja()
        {
            Assert.IsNotNull(DogadajRepository.DohvatiDogadaje());
        }
    }
}
