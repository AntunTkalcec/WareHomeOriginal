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
using WareHome.Models.Raspored;
using WareHome_Logic;

namespace WareHome
{
    public partial class GlavnaForm : Form
    {
        static Korisnik trenutniKorisnik;

        public GlavnaForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
        }

        private void OsvjeziNamirnice()
        {
            if (trenutniKorisnik.Domacinstvo != null)
            {
                Database.Instance.Connect();
                namirniceDGV.DataSource = NamirnicaRepository.DohvatiNamirnice(trenutniKorisnik.Domacinstvo);
                Database.Instance.Disconnect();
            }
        }

        private void OsvjeziDomacinstvo()
        {
            if (trenutniKorisnik.Domacinstvo == null)
            {
                MessageBox.Show("Ne pripadate nikakvom domaćinstvu. Molimo, izradite novo domaćinstvo ili se pridružite postojećem.");
                nisteDioDomacinstvaLabel.Visible = true;
                dodajNamirnicuButton.Enabled = false;
                promijeniNamirnicuButton.Enabled = false;
                obrisiNamirnicuButton.Enabled = false;
            }
            else
            {
                izradiDomacinstvoButton.Enabled = false;
                pridruziDomacinstvuButton.Enabled = false;
                trenutnoDomacinstvoLabel2.Text = trenutniKorisnik.Domacinstvo.Naziv;
                OsvjeziNamirnice();
            }
        }
        private void GlavnaForm_Load(object sender, EventArgs e)
        {
            OsvjeziDomacinstvo();
            OsvjeziNamirnice();
        }

        private void rasporedButton_Click(object sender, EventArgs e)
        {
            RasporedForm rasporedForm = new RasporedForm(trenutniKorisnik);
            rasporedForm.ShowDialog();
        }

        private void odjavaButton_Click(object sender, EventArgs e)
        {
            trenutniKorisnik = null;
            Close();
        }

        private void listeButton_Click(object sender, EventArgs e)
        {
            ListeForm listeForm = new ListeForm(trenutniKorisnik);
            listeForm.Show();
        }

        private void exitAppButton_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dodajNamirnicuButton_Click(object sender, EventArgs e)
        {
            DodajNamirnicuForm dodajNamirnicuForm = new DodajNamirnicuForm(trenutniKorisnik);
            dodajNamirnicuForm.ShowDialog();
            OsvjeziNamirnice();
        }

        private void obrisiNamirnicuButton_Click(object sender, EventArgs e)
        {
            Database.Instance.Connect();
            NamirnicaRepository.Obrisi(namirniceDGV.CurrentRow.DataBoundItem as Namirnica);
            Database.Instance.Disconnect();
            OsvjeziNamirnice();
        }

        private void promijeniNamirnicuButton_Click(object sender, EventArgs e)
        {
            PromijeniNamirnicuForm promijeniNamirnicuForm = new PromijeniNamirnicuForm(namirniceDGV.CurrentRow.DataBoundItem as Namirnica);
            promijeniNamirnicuForm.ShowDialog();
            OsvjeziNamirnice();
        }
    }
}
