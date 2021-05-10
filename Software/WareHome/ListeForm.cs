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
    public partial class ListeForm : Form
    {
        List<ListaZaKupovinu> listeZaKupovinu;
        Korisnik trenutniKorisnik;

        public ListeForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
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
                    LozinkaZaListuForm lozinkaZaListuForm = new LozinkaZaListuForm(odabrana);
                    lozinkaZaListuForm.ShowDialog();
                    OsvjeziListu();
                }
                else
                {
                    ListaForm listaForm = new ListaForm(odabrana);
                    listaForm.Show();
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
            listeDataGridView.DataSource = null;
            listeDataGridView.DataSource = listeZaKupovinu;
            listeDataGridView.Columns["LozinkaListe"].Visible = false;
            listeDataGridView.Columns["IdListe"].Visible = false;
            listeDataGridView.Columns["Domacinstvo"].Visible = false;
            listeDataGridView.Columns["PrivatnaLista"].ReadOnly = true;
            listeDataGridView.Columns["NazivListe"].ReadOnly = true;
            listeDataGridView.Columns["PrivatnaLista"].HeaderText = "Privatna lista";
            listeDataGridView.Columns["NazivListe"].HeaderText = "Naziv liste";
            nisteDioDomacinstvaLabel.Visible = false;
            NamirnicaNaListiRepository.PopisNamirnica = null;
        }

        private void obrišiButton_Click(object sender, EventArgs e)
        {
            if (listeDataGridView.CurrentRow == null)
            {
                OsvjeziListu();
            }                        
            else
            {
                ListaZaKupovinu obriši = listeDataGridView.CurrentRow.DataBoundItem as ListaZaKupovinu;
                ListaZaKupovinuRepository.UkloniListu(obriši);
                OsvjeziListu();
            }
        }
    }
}
