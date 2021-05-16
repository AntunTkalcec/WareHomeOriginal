using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            dataGridView1.DataSource = predviđenaPotrošnja;

            dataGridView1.Columns["NamirnicaId"].ReadOnly = true;
            dataGridView1.Columns["NamirnicaId"].HeaderText = "ID";
            dataGridView1.Columns["NamirnicaId"].Width = 25;

            dataGridView1.Columns["NamirnicaNaziv"].ReadOnly = true;
            dataGridView1.Columns["NamirnicaNaziv"].HeaderText = "Naziv";
            dataGridView1.Columns["NamirnicaNaziv"].Width = 221;

            dataGridView1.Columns["DostupnaKoličina"].ReadOnly = true;
            dataGridView1.Columns["DostupnaKoličina"].HeaderText = "Dostupna količina";
            dataGridView1.Columns["DostupnaKoličina"].Width = 150;
            
            dataGridView1.Columns["MjernaJedinica"].ReadOnly = true;
            dataGridView1.Columns["MjernaJedinica"].HeaderText = "Mjerna jedinica";
            dataGridView1.Columns["MjernaJedinica"].Width = 150;

            dataGridView1.Columns["PredviđenoTrajanje"].ReadOnly = true;
            dataGridView1.Columns["PredviđenoTrajanje"].HeaderText = "Predviđeno trajanje (u danima)";
            dataGridView1.Columns["PredviđenoTrajanje"].Width = 175;

        }
    }
}
