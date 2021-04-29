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
        }

        private void PrijavaForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void PrijavaButton_Click(object sender, EventArgs e)
        {
            if (PrijaviKorisnika())
            {
                Hide();
                UpaliGlavnuFormu();
                Show();
            }
        }

        private bool PrijaviKorisnika()
        {
            Korisnik korisnik;
            Domacinstvo domacinstvo = new Domacinstvo();
            string sql = "SELECT * FROM Korisnik";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                if (dataReader["korisnicko_ime"].ToString() == usernameTextBox.Text && dataReader["lozinka"].ToString() == passwordTextBox.Text)
                {
                    korisnik = new Korisnik(dataReader["ime"].ToString(), dataReader["prezime"].ToString(), dataReader["e-mail"].ToString(), dataReader["lozinka"].ToString(),
                        usernameTextBox.Text, DateTime.Parse(dataReader["datum_registracije"].ToString()), DateTime.UtcNow, null);
                    korisnik.Prijavljen = true;
                    dataReader.Close();
                    UpdateZadnjuPrijavu(korisnik);
                    Database.Instance.Disconnect();
                    return true;
                }
            }

            MessageBox.Show("Ne postoji korisnik s upisanom kombinacijom korisničkog imena i lozinke!");
            dataReader.Close();
            Database.Instance.Disconnect();
            return false;
        }

        private void UpdateZadnjuPrijavu(Korisnik korisnik)
        {
            string sql = $"UPDATE Korisnik SET datum_zadnje_prijave = '{korisnik.DatumZadnjePrijave:yyyyMMdd}' WHERE korisnicko_ime = '{korisnik.KorisnickoIme}'";
            Database.Instance.ExecuteCommand(sql);
        }

        private void UpaliGlavnuFormu()
        {
            GlavnaForm Glavna = new GlavnaForm();
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
            Hide();
            ZaboravljenaLozinkaForm zaboravljenaLozinka = new ZaboravljenaLozinkaForm();
            zaboravljenaLozinka.ShowDialog();
            Show();
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
