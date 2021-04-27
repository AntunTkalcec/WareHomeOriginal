using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome.Models.Raspored
{
    public static class Dozvoljeno
    {
        public static List<Dan> Dani = new List<Dan>
        {
            new Dan("-"),
            new Dan("Ponedjeljak"),
            new Dan("Utorak"),
            new Dan("Srijeda"),
            new Dan("Četvrtak"),
            new Dan("Petak"),
            new Dan("Subota"),
            new Dan("Nedjelja")
        };

        public static List<Sat> Sati = new List<Sat>
        {
            new Sat("00"),
            new Sat("01"),
            new Sat("02"),
            new Sat("03"),
            new Sat("04"),
            new Sat("05"),
            new Sat("06"),
            new Sat("07"),
            new Sat("08"),
            new Sat("09"),
            new Sat("10"),
            new Sat("11"),
            new Sat("12"),
            new Sat("13"),
            new Sat("14"),
            new Sat("15"),
            new Sat("16"),
            new Sat("17"),
            new Sat("18"),
            new Sat("19"),
            new Sat("20"),
            new Sat("21"),
            new Sat("22"),
            new Sat("23")
        };

        public static List<Minuta> Minute = new List<Minuta>
        {
            new Minuta("00"),
            new Minuta("05"),
            new Minuta("10"),
            new Minuta("15"),
            new Minuta("20"),
            new Minuta("25"),
            new Minuta("30"),
            new Minuta("35"),
            new Minuta("40"),
            new Minuta("45"),
            new Minuta("50"),
            new Minuta("55")
        };

        public static List<Ponavljanje> Ponavljanja = new List<Ponavljanje>
        {
            new Ponavljanje(1),
            new Ponavljanje(2),
            new Ponavljanje(3),
            new Ponavljanje(4),
            new Ponavljanje(5),
            new Ponavljanje(6),
            new Ponavljanje(7),
            new Ponavljanje(8),
            new Ponavljanje(9),
            new Ponavljanje(10)
        };
}
}
