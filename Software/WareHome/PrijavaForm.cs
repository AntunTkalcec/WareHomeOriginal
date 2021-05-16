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
    public partial class PrijavaForm : Form
    {
        public PrijavaForm()
        {
            InitializeComponent();
            AcceptButton = prijavaButton;
            prijavaButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void PrijavaForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void PrijavaButton_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik();
            if (PrijaviKorisnika(korisnik) != null)
            {
                Hide();
                UpaliGlavnuFormu(korisnik);
                passwordTextBox.Text = "";
                usernameTextBox.Text = "";
                ActiveControl = usernameTextBox;
                Show();
            }
        }

        private Korisnik PrijaviKorisnika(Korisnik korisnik)
        {
            string sql = "SELECT * FROM Korisnik";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                if (dataReader["korisnicko_ime"].ToString() == usernameTextBox.Text && dataReader["lozinka"].ToString() == passwordTextBox.Text)
                {
                    korisnik.Identifikator = int.Parse(dataReader["korisnik_id"].ToString());
                    korisnik.Ime = dataReader["ime"].ToString();
                    korisnik.Prezime = dataReader["prezime"].ToString();
                    korisnik.Mail = dataReader["e-mail"].ToString();
                    korisnik.Lozinka = dataReader["lozinka"].ToString();
                    korisnik.KorisnickoIme = dataReader["korisnicko_ime"].ToString();
                    korisnik.DatumRegistracije = DateTime.Parse(dataReader["datum_registracije"].ToString());
                    korisnik.DatumZadnjePrijave = DateTime.UtcNow;
                    korisnik.Prijavljen = true;
                    dataReader.Close();
                    UpdateZadnjuPrijavu(korisnik);

                    ProvjeriKorisnikovoDomacinstvo(korisnik);

                    Database.Instance.Disconnect();
                    return korisnik;
                }
            }

            MessageBox.Show("Ne postoji korisnik s upisanom kombinacijom korisničkog imena i lozinke!", "Greška!");
            dataReader.Close();
            Database.Instance.Disconnect();
            return null;
        }

        private void ProvjeriKorisnikovoDomacinstvo(Korisnik korisnik)
        {
            string sql = $"SELECT * from Korisnik, Domacinstvo where Korisnik.domacinstvo = Domacinstvo.domacinstvo_id and Korisnik.korisnicko_ime = '{usernameTextBox.Text}'";
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                if (int.Parse(dataReader["domacinstvo"].ToString()) != 0)
                {
                    korisnik.Domacinstvo = DomacinstvoRepository.DohvatiDomacinstvo(dataReader);
                }
            }
        }

        private void UpdateZadnjuPrijavu(Korisnik korisnik)
        {
            string sql = $"UPDATE Korisnik SET datum_zadnje_prijave = '{korisnik.DatumZadnjePrijave:yyyyMMdd}' WHERE korisnicko_ime = '{korisnik.KorisnickoIme}'";
            Database.Instance.ExecuteCommand(sql);
        }

        private void UpaliGlavnuFormu(Korisnik korisnik)
        {
            GlavnaForm Glavna = new GlavnaForm(korisnik);
            Glavna.ShowDialog();
        }

        private void RegistracijaButton_Click(object sender, EventArgs e)
        {
            Hide();
            UpaliRegistracijskuFormu();
            Show();
        }

        private void UpaliRegistracijskuFormu()
        {
            RegistracijaForm Registracija = new RegistracijaForm();
            Registracija.ShowDialog();
        }

        private void zaboravljenaLozinkaButton_Click(object sender, EventArgs e)
        {
            ZaboravljenaLozinkaForm zaboravljenaLozinka = new ZaboravljenaLozinkaForm();
            zaboravljenaLozinka.StartPosition = FormStartPosition.Manual;
            zaboravljenaLozinka.Left = 450;
            zaboravljenaLozinka.Top = 500;
            zaboravljenaLozinka.ShowDialog();
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
