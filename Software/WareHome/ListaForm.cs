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
using WareHome.Models.ListaZaKupovinu;
using WareHome_Logic;

namespace WareHome
{
    public partial class ListaForm : Form
    {
        List<NamirnicaNaListi> namirniceNaListi;
        ListaZaKupovinu odabranaLista;
        
        public ListaForm(ListaZaKupovinu odabrana)
        {
            InitializeComponent();
            odabranaLista = odabrana;
            nazivLabel.Text = odabranaLista.NazivListe;
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
            DodajArtiklNaListu dodajArtiklNaListu = new DodajArtiklNaListu(odabranaLista);
            dodajArtiklNaListu.ShowDialog();
            OsvjeziListu();
        }

        private void OsvjeziListu()
        {
            namirniceNaListi = null;
            namirniceDataGridView.DataSource = null;

            if (nazivLabel.Text == "[WH] Potrošene namirnice")
            {
                nazivLabel.Text = "[WH] Potrošene namirnice - automatska lista";
                namirniceNaListi = DohvatiPotrošeneNamirnice(ListaZaKupovinuRepository.trenutniKorisnik);
                namirniceDataGridView.DataSource = namirniceNaListi;
                preimenujButton.Visible = false;
                ukloniButton.Visible = false;
                dodajButton.Visible = false;
                ukupnoLabel.Visible = true;
                ukupnoTextBox.Visible = true;

                decimal ukupno = 0;
                foreach (var item in namirniceNaListi)
                {
                    if (item.CijenaNamirnice != null && item.KoličinaNamirnice != null)
                    {
                        ukupno += decimal.Parse(item.CijenaNamirnice.ToString()) * decimal.Parse(item.KoličinaNamirnice.ToString());
                    }
                }
                ukupnoTextBox.Text = ukupno / 100 + " kn";
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
            namirniceDataGridView.Columns["NazivNamirnice"].Width = 150;
            namirniceDataGridView.Columns["KoličinaNamirnice"].HeaderText = "Količina";
            namirniceDataGridView.Columns["KoličinaNamirnice"].Width = 100;
            namirniceDataGridView.Columns["CijenaNamirnice"].HeaderText = "Cijena";
            namirniceDataGridView.Columns["CijenaNamirnice"].Width = 100;
            namirniceDataGridView.Columns["TrgovinaNamirnice"].HeaderText = "Trgovina";
            namirniceDataGridView.Columns["TrgovinaNamirnice"].Width = 150;
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
            nazivLabel.Text = ListaZaKupovinuRepository.NoviNaziv;
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
    }
}
