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
using WareHome_Logic;

namespace WareHome
{
    public partial class PromijeniNamirnicuForm : Form
    {
        Namirnica trenutnaNamirnica = new Namirnica();
        public PromijeniNamirnicuForm(Namirnica namirnica)
        {
            InitializeComponent();
            trenutnaNamirnica = namirnica;
        }

        private void PromijeniNamirnicuForm_Load(object sender, EventArgs e)
        {
            if (trenutnaNamirnica.Identifikator != 0)
            {
                nazivNamirniceTextBox.Text = trenutnaNamirnica.NazivNamirnice;
                dostupnaKolicinaTextBox.Text = trenutnaNamirnica.DostupnaKolicina.ToString();
                optimalnaKolicinaTextBox.Text = trenutnaNamirnica.OptimalnaKolicina.ToString();
                mjernaJedinicaComboBox.SelectedItem = trenutnaNamirnica.MjernaJedinica.ToString();
                cijenaTextBox.Text = trenutnaNamirnica.Cijena.ToString();
                ducanTextBox.Text = trenutnaNamirnica.Ducan.ToString();
            }
        }

        private void spremiNamirnicuButton_Click(object sender, EventArgs e)
        {
            if (trenutnaNamirnica.Identifikator != 0)
            {
                trenutnaNamirnica.NazivNamirnice = nazivNamirniceTextBox.Text;
                trenutnaNamirnica.DostupnaKolicina = float.Parse(dostupnaKolicinaTextBox.Text);
                trenutnaNamirnica.OptimalnaKolicina = float.Parse(optimalnaKolicinaTextBox.Text);
                trenutnaNamirnica.MjernaJedinica = mjernaJedinicaComboBox.SelectedItem.ToString();
                trenutnaNamirnica.Cijena = float.Parse(cijenaTextBox.Text);
                trenutnaNamirnica.Ducan = ducanTextBox.Text;
                trenutnaNamirnica.DatumZadnjePromjene = DateTime.UtcNow;
                Database.Instance.Connect();
                NamirnicaRepository.Spremi(trenutnaNamirnica);
                Database.Instance.Disconnect();
                Close();
            } 
        }
    }
}
