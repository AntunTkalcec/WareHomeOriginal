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
    public partial class ListeForm : Form
    {
        List<ListaZaKupovinu> listeZaKupovinu;
        Korisnik trenutniKorisnik;

        public ListeForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
            CancelButton = povratakButton;
        }

        private void ListeForm_Load(object sender, EventArgs e)
        {
            if (trenutniKorisnik.Domacinstvo == null)
            {
                KorisnikNemaDomacinstvo();
            }
            else
            {
                OsvjeziListu();
            }
        }

        private void KorisnikNemaDomacinstvo()
        {
            listeDataGridView.DataSource = null;
            kreirajButton.Enabled = false;
            obrišiButton.Enabled = false;
            prikažiButton.Enabled = false;
            nisteDioDomacinstvaLabel.Visible = true;
        }

        private void povratakButton_Click(object sender, EventArgs e)
        {
            trenutniKorisnik = null;
            Close();
        }

        private void prikažiButton_Click(object sender, EventArgs e)
        {
            if (listeDataGridView.CurrentRow == null)
            {
                OsvjeziListu();
            }
            else
            {
                ListaZaKupovinu odabrana = listeDataGridView.CurrentRow.DataBoundItem as ListaZaKupovinu;

                if (odabrana.PrivatnaLista)
                {
                    LozinkaZaListuForm lozinkaZaListuForm = new LozinkaZaListuForm(odabrana, trenutniKorisnik);
                    lozinkaZaListuForm.ShowDialog();
                    OsvjeziListu();
                }
                else
                {
                    ListaForm listaForm = new ListaForm(odabrana, trenutniKorisnik);
                    listaForm.ShowDialog();
                    OsvjeziListu();
                }
            }
        }

        private void kreirajButton_Click(object sender, EventArgs e)
        {
            NovaListaForm novaListaForm = new NovaListaForm();
            novaListaForm.ShowDialog();
            OsvjeziListu();
        }

        private void OsvjeziListu()
        {
            listeZaKupovinu = null;
            listeZaKupovinu = ListaZaKupovinuRepository.DohvatiPopisLista(trenutniKorisnik);
            ProvjeriListuZaNeoptimalno(listeZaKupovinu);
            listeDataGridView.DataSource = null;
            listeDataGridView.DataSource = listeZaKupovinu;
            ProvjeriOznačeniRed();
            listeDataGridView.Columns["LozinkaListe"].Visible = false;
            listeDataGridView.Columns["IdListe"].Visible = false;
            listeDataGridView.Columns["Domacinstvo"].Visible = false;
            listeDataGridView.Columns["PrivatnaLista"].ReadOnly = true;
            listeDataGridView.Columns["NazivListe"].Width = 420;
            listeDataGridView.Columns["PrivatnaLista"].Width = 150;
            listeDataGridView.Columns["NazivListe"].ReadOnly = true;
            listeDataGridView.Columns["PrivatnaLista"].HeaderText = "Privatna lista";
            listeDataGridView.Columns["NazivListe"].HeaderText = "Naziv liste";
            nisteDioDomacinstvaLabel.Visible = false;
            NamirnicaNaListiRepository.PopisNamirnica = null;
        }

        private void ProvjeriListuZaNeoptimalno(List<ListaZaKupovinu> listeZaKupovinu)
        {
            bool postoji = false;
            string naziv = "[WH] Potrošene namirnice";
            foreach (var item in listeZaKupovinu)
            {
                if (item.NazivListe == naziv)
                {
                    postoji = true;
                }
            }

            if (!postoji)
            {
                ListaZaKupovinuRepository.DodajListu(naziv, postoji, null);
                OsvjeziListu();
            }
        }

        private void obrišiButton_Click(object sender, EventArgs e)
        {
            if (listeDataGridView.CurrentRow == null || (listeDataGridView.CurrentRow.DataBoundItem as ListaZaKupovinu).NazivListe == "[WH] Potrošene namirnice")
            {
                OsvjeziListu();
            }                        
            else
            {
                var jesteLiSigurni = MessageBox.Show($"Jeste li sigurni da želite obrisati listu *{(listeDataGridView.CurrentRow.DataBoundItem as ListaZaKupovinu).NazivListe}* i sve namirnice koje se na njoj nalaze?", "Potvrda brisanja", MessageBoxButtons.YesNo);
                if (jesteLiSigurni == DialogResult.Yes)
                {
                    ListaZaKupovinu obriši = listeDataGridView.CurrentRow.DataBoundItem as ListaZaKupovinu;
                    ListaZaKupovinuRepository.UkloniListu(obriši);
                }
                OsvjeziListu();
            }
        }

        private void listeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ProvjeriOznačeniRed();
        }

        private void ProvjeriOznačeniRed()
        {
            if (listeDataGridView.CurrentRow != null)
            {
                if ((listeDataGridView.CurrentRow.DataBoundItem as ListaZaKupovinu).NazivListe == "[WH] Potrošene namirnice")
                {
                    obrišiButton.Enabled = false;
                }
                else
                {
                    obrišiButton.Enabled = true;
                }
            }
        }

        private void ListeForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string helpLocation = Path.Combine(executableLocation, "helpfile.chm");
            string helpfile = "File://" + helpLocation;
            Help.ShowHelp(this, helpfile, HelpNavigator.KeywordIndex, "6.1. Pregledavanje izradenih lista");
        }
    }
}
