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
using WareHome.Models.ListaZaKupovinu;

namespace WareHome
{
    public partial class DodajNaListuForm : Form
    {
        public ListaZaKupovinu odabranaLista;

        public DodajNaListuForm(ListaZaKupovinu odabrana)
        {
            InitializeComponent();
            odabranaLista = odabrana;
            AcceptButton = dodajButton;
            CancelButton = odustaniButton;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            string nazivArtikla = ProvjeriUnos(nazivTextBox.Text);
            string cijena = ProvjeriUnos(cijenaTextBox.Text);
            string količina = ProvjeriUnos(kolicinaTextBox.Text);
            string trgovina = ProvjeriUnos(trgovinaTextBox.Text);
            if (nazivArtikla.Length <= 30 && nazivArtikla.Length >= 1 && cijena.Length <= 10 && količina.Length <= 10 && trgovina.Length <= 30)
            {
                NamirnicaNaListiRepository.DodajNamirnicu(new NamirnicaNaListi(0, odabranaLista.IdListe, nazivArtikla, cijena, količina, trgovina));
                Close();
            }
            else
            {
                MessageBox.Show("Neispravan unos!\nProvjerite naziv (max. 30 znakova), količina (max. 10 znakova), cijena (max. 10 znakova) i trgovina (max. 30 znakova).", "Greška!");
            }
        }

        private string ProvjeriUnos(string text)
        {
            string unos = "";
            foreach (char c in text)
            {
                string slovo = "" + c;
                if (slovo != "'")
                {
                    unos += slovo;
                }
            }
            return unos;
        }

        private void DodajNaListuForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string helpLocation = Path.Combine(executableLocation, "helpfile.chm");
            string helpfile = "File://" + helpLocation;
            Help.ShowHelp(this, helpfile, HelpNavigator.KeywordIndex, "6.5. Dodavanje namirnice na listu za kupovinu");
        }
    }
}