using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHome.Models.ListaZaKupovinu;

namespace WareHome
{
    public partial class ListaForm : Form
    {
        List<NamirnicaNaListi> namirniceNaListi;
        ListaZaKupovinu odabranaLista;
        
        public ListaForm(ListaZaKupovinu odabrana)
        {
            InitializeComponent();
            odabranaLista = odabrana;
            nazivLabel.Text = odabranaLista.NazivListe;
        }        

        private void povratakButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListaForm_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DodajArtiklNaListu dodajArtiklNaListu = new DodajArtiklNaListu(odabranaLista);
            dodajArtiklNaListu.ShowDialog();
            OsvjeziListu();
        }

        private void OsvjeziListu()
        {
            namirniceNaListi = null;
            namirniceNaListi = NamirnicaNaListiRepository.DohvatiPopisNamirnica(odabranaLista);
            namirniceDataGridView.DataSource = null;
            namirniceDataGridView.DataSource = namirniceNaListi;
            namirniceDataGridView.Columns["ListaNamirnice"].Visible = false;
            namirniceDataGridView.Columns["NazivNamirnice"].ReadOnly = true;
            namirniceDataGridView.Columns["KoličinaNamirnice"].ReadOnly = true;
            namirniceDataGridView.Columns["CijenaNamirnice"].ReadOnly = true;
            namirniceDataGridView.Columns["TrgovinaNamirnice"].ReadOnly = true;
            namirniceDataGridView.Columns["NazivNamirnice"].HeaderText = "Naziv";
            namirniceDataGridView.Columns["KoličinaNamirnice"].HeaderText = "Količina";
            namirniceDataGridView.Columns["CijenaNamirnice"].HeaderText = "Cijena";
            namirniceDataGridView.Columns["TrgovinaNamirnice"].HeaderText = "Trgovina";
        }

        private void preimenujButton_Click(object sender, EventArgs e)
        {
            NovaListaForm novaListaForm = new NovaListaForm(odabranaLista);
            novaListaForm.ShowDialog();
            nazivLabel.Text = odabranaLista.NazivListe;
        }

        private void ukloniButton_Click(object sender, EventArgs e)
        {
            NamirnicaNaListi ukloniNamirnicu = namirniceDataGridView.CurrentRow.DataBoundItem as NamirnicaNaListi;
            NamirnicaNaListiRepository.UkloniNamirnicu(ukloniNamirnicu);
            OsvjeziListu();
        }
    }
}
