using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHome_Logic;

namespace WareHome
{
    public partial class PromijeniNamirnicuForm : Form
    {
        Namirnica trenutnaNamirnica = new Namirnica();
        public PromijeniNamirnicuForm(Namirnica namirnica)
        {
            InitializeComponent();
            trenutnaNamirnica = namirnica;
            CancelButton = exitAppButton;
            AcceptButton = spremiNamirnicuButton;
        }
        float staraVrijednost = 0;
        float novaVrijednost = 0;
        private void PromijeniNamirnicuForm_Load(object sender, EventArgs e)
        {
            if (trenutnaNamirnica.Identifikator != 0)
            {
                nazivNamirniceTextBox.Text = trenutnaNamirnica.NazivNamirnice;
                dostupnaKolicinaTextBox.Text = trenutnaNamirnica.DostupnaKolicina.ToString();
                staraVrijednost = trenutnaNamirnica.DostupnaKolicina;
                optimalnaKolicinaTextBox.Text = trenutnaNamirnica.OptimalnaKolicina.ToString();
                mjernaJedinicaComboBox.SelectedItem = trenutnaNamirnica.MjernaJedinica.ToString();
                cijenaTextBox.Text = trenutnaNamirnica.Cijena.ToString();
                ducanTextBox.Text = trenutnaNamirnica.Ducan.ToString();
            }
        }

        private void spremiNamirnicuButton_Click(object sender, EventArgs e)
        {
            if (nazivNamirniceTextBox.Text == null || nazivNamirniceTextBox.Text == "" || dostupnaKolicinaTextBox.Text == null ||
                dostupnaKolicinaTextBox.Text == "" || optimalnaKolicinaTextBox.Text == null || optimalnaKolicinaTextBox.Text == "" || mjernaJedinicaComboBox.SelectedItem == null)
            {
                MessageBox.Show("Nisu popunjena sva obavezna polja.", "Greška!");
            }
            else if (dostupnaKolicinaTextBox.BackColor == Color.Red || optimalnaKolicinaTextBox.BackColor == Color.Red || cijenaTextBox.BackColor == Color.Red)
            {
                MessageBox.Show("Jedno ili više polja nije ispravno popunjeno.", "Greška!");
            }
            else
            {
                trenutnaNamirnica.NazivNamirnice = nazivNamirniceTextBox.Text;
                trenutnaNamirnica.DostupnaKolicina = float.Parse(dostupnaKolicinaTextBox.Text);
                novaVrijednost = trenutnaNamirnica.DostupnaKolicina;
                trenutnaNamirnica.OptimalnaKolicina = float.Parse(optimalnaKolicinaTextBox.Text);
                trenutnaNamirnica.MjernaJedinica = mjernaJedinicaComboBox.SelectedItem.ToString();
                trenutnaNamirnica.Cijena = ProvjeriDecimalnuCijenu();
                trenutnaNamirnica.Ducan = ducanTextBox.Text;
                trenutnaNamirnica.DatumZadnjePromjene = DateTime.Today;
                Database.Instance.Connect();
                NamirnicaRepository.Spremi(trenutnaNamirnica);
                if (novaVrijednost < staraVrijednost)
                {
                    DogadajRepository.Spremi(trenutnaNamirnica, novaVrijednost - staraVrijednost);
                }
                Database.Instance.Disconnect();
                Close();
            }
        }

        private string ProvjeriDecimalnuCijenu()
        {
            string cijena = cijenaTextBox.Text;
            if (cijena.Length > 0)
            {
                if (!cijena.Contains('.'))
                {
                    cijena = cijena + ".00";
                }
                else if (cijena.Contains('.') && ProvjeriBrojDecimala(cijena) == 0)
                {
                    cijena = cijena + "00";
                }
                else if (cijena.Contains('.') && ProvjeriBrojDecimala(cijena) == 1)
                {
                    cijena = cijena + "0";
                }
            }
            return cijena;
        }

        private void dostupnaKolicinaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dostupnaKolicinaTextBox.Text.Contains("-") || dostupnaKolicinaTextBox.Text.Contains(",") || dostupnaKolicinaTextBox.Text.Contains("+") || IzbrojiTocke(dostupnaKolicinaTextBox.Text) > 0 || ProvjeriBrojDecimala(dostupnaKolicinaTextBox.Text) > 1)
            {
                dostupnaKolicinaTextBox.BackColor = Color.Red;
            }
            else
            {
                dostupnaKolicinaTextBox.BackColor = Color.White;
            }
        }

        private void optimalnaKolicinaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (optimalnaKolicinaTextBox.Text.Contains("-") || optimalnaKolicinaTextBox.Text.Contains(",") || optimalnaKolicinaTextBox.Text.Contains("+") || IzbrojiTocke(optimalnaKolicinaTextBox.Text) > 0 || ProvjeriBrojDecimala(optimalnaKolicinaTextBox.Text) > 1)
            {
                optimalnaKolicinaTextBox.BackColor = Color.Red;
            }
            else
            {
                optimalnaKolicinaTextBox.BackColor = Color.White;
            }
        }

        private void cijenaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cijenaTextBox.Text.Contains("-") || cijenaTextBox.Text.Contains(",") || cijenaTextBox.Text.Contains("+") || IzbrojiTocke(cijenaTextBox.Text) > 1 || ProvjeriBrojDecimala(cijenaTextBox.Text) > 2)
            {
                cijenaTextBox.BackColor = Color.Red;
            }
            else
            {
                cijenaTextBox.BackColor = Color.White;
            }
        }

        private int ProvjeriBrojDecimala(string text)
        {
            int brojDecimala = 0;
            if (IzbrojiTocke(text) > 0)
            {
                brojDecimala = text.Length - text.IndexOf(".") - 1;
            }
            return brojDecimala;
        }

        public int IzbrojiTocke(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (c == '.')
                {
                    count++;
                }
            }
            return count;
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PromijeniNamirnicuForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string helpLocation = Path.Combine(executableLocation, "helpfile.chm");
            string helpfile = "File://" + helpLocation;
            Help.ShowHelp(this, helpfile, HelpNavigator.KeywordIndex, "4.2. Uredivanje namirnice");
        }
    }
}
