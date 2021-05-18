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

namespace WareHome
{
    public partial class RegistracijaForm : Form
    {
        public RegistracijaForm()
        {
            InitializeComponent();
            AcceptButton = registracijaButton;
        }

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistracijaForm_Load(object sender, EventArgs e)
        {
            regLozinkaTextBox.PasswordChar = '*';
            regPotvrdiLozinkuTextBox.PasswordChar = '*';
        }

        private void RegistracijaButton_Click(object sender, EventArgs e)
        {
            if (RegistrirajKorisnika())
            {
                Close();
            }
        }
        private bool RegistrirajKorisnika()
        {
            bool Uspjeh = false;
            string sql;
            string Ime = regImeTextBox.Text;
            string Prezime = regPrezimeTextBox.Text;
            string Mail = regMailTextBox.Text;
            string KorisnickoIme = regKorImeTextBox.Text;
            string Lozinka = regLozinkaTextBox.Text;
            string PotvrdaLozinke = regPotvrdiLozinkuTextBox.Text;
            DateTime DatumRegistracije = DateTime.UtcNow;

            if (!ProvjeriKorisnickoIme(KorisnickoIme, Mail))
            {
                MessageBox.Show("Već postoji korisnik s unesenim korisničkim imenom i/ili emailom!", "Greška!");
                return Uspjeh;
            }

            if (Lozinka != PotvrdaLozinke)
            {
                MessageBox.Show("Polja Lozinka i Potvrdi Lozinku se ne poklapaju!", "Greška!");
                return Uspjeh;
            }
            else
            {
                if (Ime.Length > 1 && Prezime.Length > 1 && Mail.Length > 1 && KorisnickoIme.Length > 1 && Lozinka.Length > 1)
                {
                    Database.Instance.Connect();
                    sql = $"INSERT INTO Korisnik (ime, prezime, [e-mail], lozinka, korisnicko_ime, datum_registracije) " +
                        $"VALUES ('{Ime}', '{Prezime}', '{Mail}', '{Lozinka}', '{KorisnickoIme}', '{DatumRegistracije:yyyyMMdd}')";
                    Database.Instance.ExecuteCommand(sql);
                    Uspjeh = true;
                    MessageBox.Show("Korisnik registriran.", "Obavijest");
                    Database.Instance.Disconnect();
                }
                else
                {
                    MessageBox.Show("Ostavili ste nepopunjena polja!", "Greška!");
                    return Uspjeh;
                }
            }
            return Uspjeh;
        }

        private bool ProvjeriKorisnickoIme(string korisnickoIme, string email)
        {
            string sql = "SELECT * from Korisnik";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                if (dataReader["korisnicko_ime"].ToString() == korisnickoIme || dataReader["e-mail"].ToString() == email)
                {
                    dataReader.Close();
                    Database.Instance.Disconnect();
                    return false;
                }
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return true;
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
