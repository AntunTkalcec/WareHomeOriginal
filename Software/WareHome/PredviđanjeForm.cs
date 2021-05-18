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
    public partial class PredviđanjeForm : Form
    {
        Korisnik trenutniKorisnik;
        List<PredviđenaPotrošnja> predviđenaPotrošnja;

        public PredviđanjeForm(Korisnik korisnik)
        {
            InitializeComponent();
            UpišiKorisnika(korisnik);
            AcceptButton = ispisiButton;
            CancelButton = povratakButton;
        }

        private void UpišiKorisnika(Korisnik korisnik)
        {
            trenutniKorisnik = null;
            trenutniKorisnik = korisnik;
        }

        private void PredviđanjeForm_Load(object sender, EventArgs e)
        {
            predviđenaPotrošnja = null;
            predviđenaPotrošnja = PredviđanjePotrošnjeRepository.PredvidiPotrošnju(trenutniKorisnik);
            predvidanjeDataGridView.DataSource = predviđenaPotrošnja;

            predvidanjeDataGridView.Columns["NamirnicaId"].ReadOnly = true;
            predvidanjeDataGridView.Columns["NamirnicaId"].HeaderText = "ID";
            predvidanjeDataGridView.Columns["NamirnicaId"].Width = 35;

            predvidanjeDataGridView.Columns["NamirnicaNaziv"].ReadOnly = true;
            predvidanjeDataGridView.Columns["NamirnicaNaziv"].HeaderText = "Naziv";
            predvidanjeDataGridView.Columns["NamirnicaNaziv"].Width = 211;

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

        private void povratakButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ispisiButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
