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
            PrijaviKorisnika();
            if (PrijaviKorisnika())
            {
                Hide();
                UpaliGlavnuFormu();
                Show();
            }
        }

        private bool PrijaviKorisnika()
        {
            Korisnik korisnik = new Korisnik();
            Domacinstvo domacinstvo = new Domacinstvo();
            string sql = "SELECT * FROM Korisnik";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                if (dataReader["korisnicko_ime"].ToString() == usernameTextBox.Text && dataReader["lozinka"].ToString() == passwordTextBox.Text)
                {
                    korisnik.Ime = dataReader["ime"].ToString();
                    korisnik.Prezime = dataReader["prezime"].ToString();
                    korisnik.Mail = dataReader["e-mail"].ToString();
                    korisnik.Lozinka = dataReader["lozinka"].ToString();
                    korisnik.KorisnickoIme = usernameTextBox.Text;
                    korisnik.DatumRegistracije = DateTime.Parse(dataReader["datum_registracije"].ToString());
                    korisnik.DatumZadnjePrijave = DateTime.Now;
                    korisnik.Prijavljen = true;
                    return true;
                }
            }
            if (!korisnik.Prijavljen)
            {
                MessageBox.Show("Ne postoji korisnik s upisanom kombinacijom korisničkog imena i lozinke!");
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return false;
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
    }
}
