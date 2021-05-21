using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WareHomeEmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql = "SELECT [e-mail], dan_odlaska, sat_odlaska, minuta_odlaska FROM Korisnik, " +
                "Raspored WHERE upper(dan_odlaska) = upper(datename(dw, getdate())) and korisnik.korisnik_id = raspored.korisnik_id";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            List<Podsjetnik> podsjetnici = new List<Podsjetnik>();
            List<MailDanCombine> mailovi = new List<MailDanCombine>();
            while (dataReader.Read())
            {
                mailovi.Add(new MailDanCombine(dataReader["e-mail"].ToString(), dataReader["dan_odlaska"].ToString(), dataReader["sat_odlaska"].ToString(), dataReader["minuta_odlaska"].ToString()));
            }
            dataReader.Close();
            foreach (var korisnik in mailovi)
            {
                sql = $"SELECT DISTINCT naziv_namirnice, optimalna_kolicina-dostupna_kolicina as kolicina from raspored, korisnik, namirnica " +
                    $"WHERE korisnik.[e-mail] = '{korisnik.Email}' and namirnica.dostupna_kolicina < namirnica.optimalna_kolicina " +
                    $"and korisnik.domacinstvo = namirnica.domacinstvo_id and raspored.korisnik_id = korisnik.korisnik_id";
                dataReader = Database.Instance.GetDataReader(sql);
                while (dataReader.Read())
                {
                    Podsjetnik podsjetnik = new Podsjetnik
                    {
                        NazivNamirnice = dataReader["naziv_namirnice"].ToString(),
                        Kolicina = dataReader["kolicina"].ToString()
                    };
                    podsjetnici.Add(podsjetnik);
                }
                dataReader.Close();
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("warehomeapp@gmail.com");
                try
                {
                    mail.To.Add(korisnik.Email);
                }
                catch
                {
                    continue;
                }
                mail.Subject = "Danas odlazite u kupovinu!";
                mail.Body = $"Ovo je automatski generiran e-mail. \nDanas u {korisnik.SatOdlaska}:{korisnik.MinutaOdlaska} Vam je po rasporedu odlazak u trgovinu." +
                    $"\nNamirnice za kupiti: \n";
                foreach (var item in podsjetnici)
                {
                    mail.Body += $"{item.NazivNamirnice} - {item.Kolicina}\n";
                }
                podsjetnici.Clear();
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("warehomeapp", "WarehomeApp246.");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                Console.WriteLine($"{korisnik.Email} je primio mail.");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Svim korisnicima je poslan mail za danas.");
            Console.Read();
            Database.Instance.Disconnect();
        }
    }
}
