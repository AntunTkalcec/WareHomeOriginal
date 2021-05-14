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
            List<PredviđenaPotrošnja> predviđenaPotrošnja = PredviđanjePotrošnjeRepository.PredvidiPotrošnju(trenutniKorisnik);
            dataGridView1.DataSource = predviđenaPotrošnja;
        }
    }
}
