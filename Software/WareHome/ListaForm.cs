using DatabaseAccess;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHome.Models.ListaZaKupovinu;
using WareHome_Logic;
using System.Reflection;

namespace WareHome
{
    public partial class ListaForm : Form
    {
        List<NamirnicaNaListi> namirniceNaListi;
        ListaZaKupovinu odabranaLista;
        Korisnik trenutniKorisnik;
        
        public ListaForm(ListaZaKupovinu odabrana, Korisnik korisnik)
        {
            InitializeComponent();
            odabranaLista = odabrana;
            trenutniKorisnik = korisnik;
            nazivLabel.Text = odabranaLista.NazivListe;
            Text = "Lista za kupovinu - " + odabranaLista.NazivListe;
            CancelButton = povratakButton;
        }        

        private void povratakButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListaForm_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DodajNaListuForm dodajArtiklNaListu = new DodajNaListuForm(odabranaLista);
            dodajArtiklNaListu.ShowDialog();
            OsvjeziListu();
        }

        private void OsvjeziListu()
        {
            namirniceNaListi = null;
            namirniceDataGridView.DataSource = null;

            if (nazivLabel.Text == "[WH] Potrošene namirnice")
            {
                nazivLabel.Text = "[WH] Potrošene namirnice (automatska lista)";
                namirniceNaListi = DohvatiPotrošeneNamirnice(ListaZaKupovinuRepository.trenutniKorisnik);
                namirniceDataGridView.DataSource = namirniceNaListi;
                preimenujButton.Visible = false;
                ukloniButton.Visible = false;
                dodajButton.Visible = false;
                ukupnoLabel.Visible = true;
                ukupnoTextBox.Visible = true;

                decimal ukupno = 0;
                bool bezAtributa = false;
                foreach (var item in namirniceNaListi)
                {
                    if (item.CijenaNamirnice != "" && item.KoličinaNamirnice != "")
                    {
                        ukupno += decimal.Parse(item.CijenaNamirnice.ToString()) * decimal.Parse(item.KoličinaNamirnice.ToString());
                    }
                    else
                    {
                        bezAtributa = true;
                    }
                }

                CultureInfo culture = Thread.CurrentThread.CurrentCulture;
                string ispisUkupnog;

                if (culture.NumberFormat.NumberDecimalSeparator == ",")
                {
                    ispisUkupnog = (ukupno / 100).ToString() + " kn";
                }
                else
                {
                    ispisUkupnog = ukupno.ToString() + " kn";
                }

                if (!bezAtributa)
                {
                    ukupnoTextBox.Text = ispisUkupnog;
                }
                else
                {
                    ukupnoTextBox.Text = "≈ " + ispisUkupnog;
                }
            }
            else
            {
                nazivLabel.Text = odabranaLista.NazivListe;
                namirniceNaListi = NamirnicaNaListiRepository.DohvatiPopisNamirnica(odabranaLista);
                namirniceDataGridView.DataSource = namirniceNaListi;
                preimenujButton.Visible = true;
                ukloniButton.Visible = true;
                dodajButton.Visible = true;
                ukupnoLabel.Visible = false;
                ukupnoTextBox.Visible = false;
            }
            namirniceDataGridView.Columns["IdNamirnice"].Visible = false;
            namirniceDataGridView.Columns["ListaNamirnice"].Visible = false;
            
            namirniceDataGridView.Columns["NazivNamirnice"].ReadOnly = true;
            namirniceDataGridView.Columns["KoličinaNamirnice"].ReadOnly = true;
            namirniceDataGridView.Columns["CijenaNamirnice"].ReadOnly = true;
            namirniceDataGridView.Columns["TrgovinaNamirnice"].ReadOnly = true;

            namirniceDataGridView.Columns["NazivNamirnice"].HeaderText = "Naziv";
            namirniceDataGridView.Columns["NazivNamirnice"].Width = 250;
            namirniceDataGridView.Columns["KoličinaNamirnice"].HeaderText = "Količina";
            namirniceDataGridView.Columns["KoličinaNamirnice"].Width = 125;
            namirniceDataGridView.Columns["CijenaNamirnice"].HeaderText = "Cijena";
            namirniceDataGridView.Columns["CijenaNamirnice"].Width = 125;
            namirniceDataGridView.Columns["TrgovinaNamirnice"].HeaderText = "Trgovina";
            namirniceDataGridView.Columns["TrgovinaNamirnice"].Width = 250;
        }

        private List<NamirnicaNaListi> DohvatiPotrošeneNamirnice(Korisnik trenutniKorisnik)
        {
            List<Namirnica> namirnice = null;
            Database.Instance.Connect();
            namirnice = NamirnicaRepository.DohvatiNamirnice(trenutniKorisnik.Domacinstvo);
            Database.Instance.Disconnect();
            List<NamirnicaNaListi> neoptimalno = null;
            neoptimalno = new List<NamirnicaNaListi>();
            foreach (var item in namirnice)
            {
                if (item.DostupnaKolicina < item.OptimalnaKolicina)
                {
                    float kolicina = item.OptimalnaKolicina - item.DostupnaKolicina;
                    NamirnicaNaListi potrošena = new NamirnicaNaListi(0, odabranaLista.IdListe, item.NazivNamirnice, kolicina.ToString(), item.Cijena, item.Ducan);
                    neoptimalno.Add(potrošena);
                }
            }
            return neoptimalno;
        }

        private void preimenujButton_Click(object sender, EventArgs e)
        {
            NovaListaForm novaListaForm = new NovaListaForm(odabranaLista);
            novaListaForm.ShowDialog();
            if (ListaZaKupovinuRepository.NoviNazivSpremljen)
            {
                odabranaLista.NazivListe = ListaZaKupovinuRepository.NoviNaziv;
                nazivLabel.Text = ListaZaKupovinuRepository.NoviNaziv;
            }
            ListaZaKupovinuRepository.NoviNaziv = null;
            ListaZaKupovinuRepository.NoviNazivSpremljen = false;
        }

        private void ukloniButton_Click(object sender, EventArgs e)
        {
            if (namirniceDataGridView.CurrentRow == null)
            {
                OsvjeziListu();
            }
            else
            {
                NamirnicaNaListi ukloniNamirnicu = namirniceDataGridView.CurrentRow.DataBoundItem as NamirnicaNaListi;
                NamirnicaNaListiRepository.UkloniNamirnicu(ukloniNamirnicu);
                OsvjeziListu();
            }
        }

        private void ispisButton_Click(object sender, EventArgs e)
        {
            OdabirNacinaIspisaListeForm form = new OdabirNacinaIspisaListeForm(odabranaLista, namirniceNaListi, trenutniKorisnik);
            form.ShowDialog();
        }

        private void ListaForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string helpLocation = Path.Combine(executableLocation, "helpfile.chm");
            string helpfile = "File://" + helpLocation;
            if (odabranaLista.NazivListe == "[WH] Potrošene namirnice")
            {
                Help.ShowHelp(this, helpfile, HelpNavigator.KeywordIndex, "6.1. Pregledavanje izradenih lista");
            }
            else
            {
                Help.ShowHelp(this, helpfile, HelpNavigator.KeywordIndex, "6.6. Uklanjanje namirnice s liste za kupovinu");
            }
        }
    }
}
