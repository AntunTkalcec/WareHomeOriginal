using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHome_Logic;

namespace WareHome
{
    public partial class DodajNamirnicuForm : Form
    {
        Korisnik trenutniKorisnik = new Korisnik();
        public DodajNamirnicuForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void spremiNamirnicuButton_Click(object sender, EventArgs e)
        {
            Namirnica namirnica = new Namirnica();
            namirnica.NazivNamirnice = nazivNamirniceTextBox.Text;
            namirnica.DostupnaKolicina = float.Parse(dostupnaKolicinaTextBox.Text);
            namirnica.OptimalnaKolicina = float.Parse(optimalnaKolicinaTextBox.Text);
            namirnica.MjernaJedinica = mjernaJedinicaComboBox.SelectedItem.ToString();
            namirnica.Cijena = float.Parse(cijenaTextBox.Text);
            namirnica.Ducan = ducanTextBox.Text;
            namirnica.DatumKreiranja = DateTime.UtcNow;
            namirnica.DatumZadnjePromjene = DateTime.UtcNow;
            namirnica.KorisnikKreator = trenutniKorisnik.KorisnickoIme;
            namirnica.Domacinstvo = trenutniKorisnik.Domacinstvo;
            Database.Instance.Connect();
            NamirnicaRepository.Spremi(namirnica);
            Database.Instance.Disconnect();
            Close();
        }
    }
}
