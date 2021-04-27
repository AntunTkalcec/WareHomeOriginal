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

namespace WareHome
{
    public partial class RasporedForm : Form
    {
        Raspored raspored;

        public RasporedForm(Raspored glavniRaspored)
        {
            InitializeComponent();
            raspored = glavniRaspored;
        }

        private void RasporedForm_Load(object sender, EventArgs e)
        {
            UcitajRaspored();
            ProvjeriDan();
        }

        private void UcitajRaspored()
        {
            danComboBox.DataSource = Dozvoljeno.Dani;
            danComboBox.SelectedItem = raspored.OdabraniDan;
            satComboBox.DataSource = Dozvoljeno.Sati;
            satComboBox.SelectedItem = raspored.OdabraniSat;
            minutaComboBox.DataSource = Dozvoljeno.Minute;
            minutaComboBox.SelectedItem = raspored.OdabranaMinuta;
            ponavljanjeComboBox.DataSource = Dozvoljeno.Ponavljanja;
            ponavljanjeComboBox.SelectedItem = raspored.OdabirPonavljanja;

            satComboBox.Enabled = true;
            minutaComboBox.Enabled = true;
            ponavljanjeComboBox.Enabled = true;
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
                UcitajRaspored();
            }
        }

        private void SpremiRaspored()
        {
            raspored.OdabraniDan = danComboBox.SelectedItem as Dan;
            raspored.OdabraniSat = satComboBox.SelectedItem as Sat;
            raspored.OdabranaMinuta = minutaComboBox.SelectedItem as Minuta;
            raspored.OdabirPonavljanja = ponavljanjeComboBox.SelectedItem as Ponavljanje;
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
