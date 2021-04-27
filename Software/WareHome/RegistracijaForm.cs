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
                Hide();
            }
        }
        private bool RegistrirajKorisnika()
        {
            Database.Instance.Connect();
            bool Uspjeh = false;
            string sql;
            string Ime = regImeTextBox.Text;
            string Prezime = regPrezimeTextBox.Text;
            string Mail = regMailTextBox.Text;
            string KorisnickoIme = regKorImeTextBox.Text;
            string Lozinka = regLozinkaTextBox.Text;
            string PotvrdaLozinke = regPotvrdiLozinkuTextBox.Text;
            DateTime DatumRegistracije = DateTime.UtcNow;

            if (Lozinka != PotvrdaLozinke)
            {
                MessageBox.Show("Polja Lozinka i Potvrdi Lozinku se ne poklapaju!");
                Database.Instance.Disconnect();
                return Uspjeh;
            }
            else
            {
                if (Ime != null && Prezime != null && Mail != null && KorisnickoIme != null && Lozinka != null)
                {
                    sql = $"INSERT INTO Korisnik (ime, prezime, [e-mail], lozinka, korisnicko_ime, datum_registracije) " +
                        $"VALUES ('{Ime}', '{Prezime}', '{Mail}', '{Lozinka}', '{KorisnickoIme}', '{DatumRegistracije:yyyyMMdd}')";
                    Database.Instance.ExecuteCommand(sql);
                    Uspjeh = true;
                    Database.Instance.Disconnect();
                }
                else
                {
                    MessageBox.Show("Ostavili ste nepopunjena polja!");
                    Database.Instance.Disconnect();
                    return Uspjeh;
                }
            }
            return Uspjeh;
        }
    }
}
