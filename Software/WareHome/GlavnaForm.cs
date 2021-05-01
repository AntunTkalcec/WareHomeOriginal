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
        Korisnik trenutniKorisnik = new Korisnik();
        public GlavnaForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
        }

        Raspored glavniRaspored = new Raspored();

        private void OsvjeziNamirnice()
        {
            
        }

        private void OsvjeziDomacinstvo()
        {
            if (trenutniKorisnik.Domacinstvo == null)
            {
                MessageBox.Show("Ne pripadate nikakvom domaćinstvu. Molimo, izradite novo domaćinstvo ili se pridružite postojećem.");
            }
            else
            {
                trenutnoDomacinstvoLabel2.Text = trenutniKorisnik.Domacinstvo.Naziv;
            }
        }
        private void GlavnaForm_Load(object sender, EventArgs e)
        {
            OsvjeziNamirnice();
            OsvjeziDomacinstvo();
        }

        private void rasporedButton_Click(object sender, EventArgs e)
        {
            RasporedForm rasporedForm = new RasporedForm(glavniRaspored);
            rasporedForm.ShowDialog();
        }

        private void odjavaButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listeButton_Click(object sender, EventArgs e)
        {
            ListeForm listeForm = new ListeForm();
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
    }
}
