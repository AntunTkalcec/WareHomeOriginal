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
using WareHome_Logic;

namespace WareHome
{
    public partial class LozinkaZaListuForm : Form
    {
        ListaZaKupovinu odabranaLista;
        int pokusaji = 3;
        Korisnik trenutniKorisnik;

        public LozinkaZaListuForm(ListaZaKupovinu odabrana, Korisnik korisnik)
        {
            InitializeComponent();
            odabranaLista = odabrana;
            trenutniKorisnik = korisnik;
            AcceptButton = prikažiButton;
            CancelButton = odustaniButton;
            prikažiButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LozinkaZaListuForm_Load(object sender, EventArgs e)
        {
            lozinkaTextBox.PasswordChar = '*';
            nazivTextBox.Text = odabranaLista.NazivListe;
        }

        private void prikažiButton_Click(object sender, EventArgs e)
        {
            if (odabranaLista.LozinkaListe == lozinkaTextBox.Text)
            {
                ListaForm listaForm = new ListaForm(odabranaLista, trenutniKorisnik);
                listaForm.ShowDialog();
                Close();
            }
            else
            {
                if (pokusaji == 0)
                {
                    Close();
                }
                MessageBox.Show("Pogrešna lozinka! Preostalo pokušaja: " + pokusaji);
                pokusaji--;
            }
        }

        private void LozinkaZaListuForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string helpLocation = Path.Combine(executableLocation, "helpfile.chm");
            string helpfile = "File://" + helpLocation;
            Help.ShowHelp(this, helpfile, HelpNavigator.KeywordIndex, "6.1. Pregledavanje izradenih lista");
        }
    }
}
