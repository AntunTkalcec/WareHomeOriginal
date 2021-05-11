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
    public partial class RasporedForm : Form
    {
        Korisnik trenutniKorisnik;
        Raspored glavniRaspored;

        public RasporedForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
        }

        private void RasporedForm_Load(object sender, EventArgs e)
        {
            UcitajRaspored();
            ProvjeriDan();
        }

        private void UcitajRaspored()
        {
            glavniRaspored = RasporedRepository.DohvatiRaspored(trenutniKorisnik);
            danComboBox.DataSource = Dozvoljeno.Dani;
            satComboBox.DataSource = Dozvoljeno.Sati;
            minutaComboBox.DataSource = Dozvoljeno.Minute;
            ponavljanjeComboBox.DataSource = Dozvoljeno.Ponavljanja;

            if (glavniRaspored != null)
            {
                danComboBox.SelectedIndex = ComboPostaviDan();
                satComboBox.SelectedIndex = int.Parse(glavniRaspored.OdabraniSat.SatOdlaska);
                minutaComboBox.SelectedIndex = int.Parse(glavniRaspored.OdabranaMinuta.MinutaOdlaska)/5;
                ponavljanjeComboBox.SelectedIndex = glavniRaspored.OdabirPonavljanja.UcestalostPonavljanja-1;
            }
            
        }

        private int ComboPostaviDan()
        {
            for (int i = 0; i < Dozvoljeno.Dani.Count; i++)
            {
                if (glavniRaspored.OdabraniDan.DanOdlaska == Dozvoljeno.Dani[i].DanOdlaska)
                {
                    return i;
                }
            }
            return 0;
        }

        private void ProvjeriDan()
        {
            if (danComboBox.SelectedItem == Dozvoljeno.Dani[0])
            {
                satComboBox.Enabled = false;
                minutaComboBox.Enabled = false;
                ponavljanjeComboBox.Enabled = false;
            }
            else
            {
                satComboBox.Enabled = true;
                minutaComboBox.Enabled = true;
                ponavljanjeComboBox.Enabled = true;
                if (ponavljanjeComboBox.SelectedIndex < 0 || ponavljanjeComboBox.SelectedIndex > 9)
                {
                    ponavljanjeComboBox.SelectedIndex = 0;
                }
            }
        }

        private void SpremiRaspored()
        {
            if (danComboBox.SelectedIndex != 0)
            {
                glavniRaspored.OdabraniDan = danComboBox.SelectedItem as Dan;
                glavniRaspored.OdabraniSat = satComboBox.SelectedItem as Sat;
                glavniRaspored.OdabranaMinuta = minutaComboBox.SelectedItem as Minuta;
                glavniRaspored.OdabirPonavljanja = ponavljanjeComboBox.SelectedItem as Ponavljanje;
            }
            else
            {
                glavniRaspored.OdabraniDan = new Dan("-");
                glavniRaspored.OdabraniSat = new Sat ("00");
                glavniRaspored.OdabranaMinuta = new Minuta("00");
                glavniRaspored.OdabirPonavljanja = new Ponavljanje(0);
            }
            RasporedRepository.SpremiRaspored(glavniRaspored);
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            SpremiRaspored();
            MessageBox.Show("Raspored uspješno spremljen!");
            Close();
        }

        private void danComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProvjeriDan();
        }
    }
}
