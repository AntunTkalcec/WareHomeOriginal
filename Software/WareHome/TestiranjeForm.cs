using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHome.Models.PredviđanjePotrošnje;
using WareHome_Logic;

namespace WareHome
{
    public partial class TestiranjeForm : Form
    {
        Korisnik trenutniKorisnik;
        List<Korisnik> ukucani;

        public TestiranjeForm(Korisnik korisnik)
        {
            InitializeComponent();
            UpišiKorisnika(korisnik);
            CancelButton = povratakButton;
        }

        private void UpišiKorisnika(Korisnik korisnik)
        {
            trenutniKorisnik = null;
            trenutniKorisnik = korisnik;
        }

        private void TestiranjeForm_Load(object sender, EventArgs e)
        {
            OsvjeziPodatkeDomacinstvo();
            OsvjeziPodatkeKorisnik();
            //postavkeLozinkaTextBox.PasswordChar = '*';
        }

        private void OsvjeziPodatkeKorisnik()
        {
            postavkeImeTextBox.Text = trenutniKorisnik.Ime;
            postavkePrezimeTextBox.Text = trenutniKorisnik.Prezime;
            postavkeMailTextBox.Text = trenutniKorisnik.Mail;
            postavkeKorisnickoImeTextBox.Text = trenutniKorisnik.KorisnickoIme;
            postavkeLozinkaTextBox.Text = trenutniKorisnik.Lozinka;
        }

        private void OsvjeziPodatkeDomacinstvo()
        {
            korisnikLabel2.Text = trenutniKorisnik.KorisnickoIme;
            trenutnoDomacinstvoLabel2.Text = trenutniKorisnik.Domacinstvo.Naziv;
            brojUkucanaLabel2.Text = IzbrojiUkucane().ToString();
            brojNamirnicaLabel2.Text = IzbrojiNamirnice().ToString();
            nazivDomacinstvaTextBox.Text = trenutniKorisnik.Domacinstvo.Naziv;

            ukućaniDataGridView.DataSource = ukucani;
            ukućaniDataGridView.Columns["Identifikator"].Visible = false;
            ukućaniDataGridView.Columns["Mail"].Visible = false;
            ukućaniDataGridView.Columns["Lozinka"].Visible = false;
            ukućaniDataGridView.Columns["KorisnickoIme"].Visible = false;
            ukućaniDataGridView.Columns["DatumRegistracije"].Visible = false;
            ukućaniDataGridView.Columns["DatumZadnjePrijave"].Visible = false;
            ukućaniDataGridView.Columns["Domacinstvo"].Visible = false;
            ukućaniDataGridView.Columns["Prijavljen"].Visible = false;

            ukućaniDataGridView.Columns["ime"].ReadOnly = true;
            ukućaniDataGridView.Columns["prezime"].ReadOnly = true;
            ukućaniDataGridView.Columns["ime"].HeaderText = "Ime";
            ukućaniDataGridView.Columns["ime"].Width = 190;
            ukućaniDataGridView.Columns["prezime"].HeaderText = "Prezime";
            ukućaniDataGridView.Columns["prezime"].Width = 190;
    }

        private int IzbrojiUkucane()
        {
            string sql = "SELECT * FROM Korisnik where Domacinstvo = " + trenutniKorisnik.Domacinstvo.Identifikator;
            int brojUkucana = 0;
            ukucani = null;
            ukucani = new List<Korisnik>();
            Database.Instance.Connect();
            IDataReader reader = Database.Instance.GetDataReader(sql);
            while (reader.Read())
            {
                string ime = reader["Ime"].ToString();
                string prezime = reader["Prezime"].ToString();
                Korisnik korisnik = new Korisnik
                {
                    Ime = ime,
                    Prezime = prezime
                };
                ukucani.Add(korisnik);

                brojUkucana++;
            }
            Database.Instance.Disconnect();
            return brojUkucana;
        }

        private int IzbrojiNamirnice()
        {
            string sql = "SELECT * FROM Namirnica where domacinstvo_id = " + trenutniKorisnik.Domacinstvo.Identifikator;
            int brojNamirnica = 0;
            Database.Instance.Connect();
            IDataReader reader = Database.Instance.GetDataReader(sql);
            while (reader.Read())
            {
                brojNamirnica++;
            }
            Database.Instance.Disconnect();
            return brojNamirnica;
        }

        private void odjavaDomacinstvaButton_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Korisnik SET domacinstvo = null WHERE korisnik_id = " + trenutniKorisnik.Identifikator;
            Database.Instance.Connect();
            Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            trenutniKorisnik.Domacinstvo = null;
            Close();
        }
        
        private void preimenovanjeDomacinstvaButton_Click(object sender, EventArgs e)
        {
            string provjera = "SELECT * FROM Domacinstvo";
            bool postoji = false;
            Database.Instance.Connect();
            IDataReader reader = Database.Instance.GetDataReader(provjera);
            while (reader.Read())
            {
                string naziv = reader["naziv"].ToString();
                if (naziv == nazivDomacinstvaTextBox.Text)
                {
                    postoji = true;
                }
            }
            Database.Instance.Disconnect();
            if (!postoji)
            {
                Database.Instance.Connect();
                string sql = $"UPDATE Domacinstvo SET naziv = '{nazivDomacinstvaTextBox.Text}' WHERE domacinstvo_id = " + trenutniKorisnik.Domacinstvo.Identifikator;
                Database.Instance.ExecuteCommand(sql);
                Database.Instance.Disconnect();
                trenutniKorisnik.Domacinstvo.Naziv = nazivDomacinstvaTextBox.Text;
                MessageBox.Show("Domaćinstvo preimenovano!\nUkoliko ste koristili dijakritike (č, ć, ž...), spremit će se slova bez dijakritičkih znakova (c, z...).", "Obavijest");
            }
            else
            {
                MessageBox.Show("Uneseni naziv već se koristi!", "Greška!");
            }
            OsvjeziPodatkeDomacinstvo();
        }

        private void tester1Button_Click_1(object sender, EventArgs e)
        {
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;
            MessageBox.Show(culture.Name + "\n" + culture.NumberFormat.NumberDecimalSeparator);
        }

        private void povratakButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void postavkePoništiButton_Click(object sender, EventArgs e)
        {
            OsvjeziPodatkeKorisnik();
        }

        private void postavkeSpremiButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pomalo, bit će.", "Greška!");
        }
    }
}
