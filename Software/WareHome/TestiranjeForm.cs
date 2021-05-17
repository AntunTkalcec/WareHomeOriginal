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
        static Korisnik trenutniKorisnik;

        public TestiranjeForm(Korisnik korisnik)
        {
            InitializeComponent();
            UpišiKorisnika(korisnik);
        }

        private void UpišiKorisnika(Korisnik korisnik)
        {
            trenutniKorisnik = null;
            trenutniKorisnik = korisnik;
        }

        private void TestiranjeForm_Load(object sender, EventArgs e)
        {
            List<PredviđenaPotrošnja> predviđenaPotrošnja = null;
            predviđenaPotrošnja = PredviđanjePotrošnjeRepository.PredvidiPotrošnju(trenutniKorisnik);
            predvidanjeDataGridView.DataSource = predviđenaPotrošnja;

            predvidanjeDataGridView.Columns["NamirnicaId"].ReadOnly = true;
            predvidanjeDataGridView.Columns["NamirnicaId"].HeaderText = "ID";
            predvidanjeDataGridView.Columns["NamirnicaId"].Width = 25;

            predvidanjeDataGridView.Columns["NamirnicaNaziv"].ReadOnly = true;
            predvidanjeDataGridView.Columns["NamirnicaNaziv"].HeaderText = "Naziv";
            predvidanjeDataGridView.Columns["NamirnicaNaziv"].Width = 221;

            predvidanjeDataGridView.Columns["DostupnaKoličina"].ReadOnly = true;
            predvidanjeDataGridView.Columns["DostupnaKoličina"].HeaderText = "Dostupna količina";
            predvidanjeDataGridView.Columns["DostupnaKoličina"].Width = 150;
            
            predvidanjeDataGridView.Columns["MjernaJedinica"].ReadOnly = true;
            predvidanjeDataGridView.Columns["MjernaJedinica"].HeaderText = "Mjerna jedinica";
            predvidanjeDataGridView.Columns["MjernaJedinica"].Width = 150;

            predvidanjeDataGridView.Columns["PredviđenoTrajanje"].ReadOnly = true;
            predvidanjeDataGridView.Columns["PredviđenoTrajanje"].HeaderText = "Predviđeno trajanje (u danima)";
            predvidanjeDataGridView.Columns["PredviđenoTrajanje"].Width = 175;

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

        private void nazivDomacinstvaButton_Click(object sender, EventArgs e)
        {

            CultureInfo culture = Thread.CurrentThread.CurrentCulture;
            MessageBox.Show(culture.Name + "\n" + culture.NumberFormat.NumberDecimalSeparator);
        }
    }
}
