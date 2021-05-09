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
            namirniceNaListi = new List<NamirnicaNaListi>();
            namirniceDataGridView.DataSource = ObrišiMeNakonImplementacijeRepozitorija();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DodajArtiklNaListu dodajArtiklNaListu = new DodajArtiklNaListu();
            dodajArtiklNaListu.ShowDialog();
            OsvjeziListu();
        }

        private void OsvjeziListu()
        {
            namirniceNaListi = null;
            namirniceNaListi = ObrišiMeNakonImplementacijeRepozitorija();
            namirniceDataGridView.DataSource = null;
            namirniceDataGridView.DataSource = namirniceNaListi;
            namirniceDataGridView.Columns["NazivNamirnice"].ReadOnly = true;
            namirniceDataGridView.Columns["KoličinaNamirnice"].ReadOnly = true;
            namirniceDataGridView.Columns["CijenaNamirnice"].ReadOnly = true;
            namirniceDataGridView.Columns["TrgovinaNamirnice"].ReadOnly = true;
            namirniceDataGridView.Columns["NazivNamirnice"].HeaderText = "Naziv";
            namirniceDataGridView.Columns["KoličinaNamirnice"].HeaderText = "Količina";
            namirniceDataGridView.Columns["CijenaNamirnice"].HeaderText = "Cijena";
            namirniceDataGridView.Columns["TrgovinaNamirnice"].HeaderText = "Trgovina";
        }

        private List<NamirnicaNaListi> ObrišiMeNakonImplementacijeRepozitorija()
        {
            List<NamirnicaNaListi> namirnicaNaListi = new List<NamirnicaNaListi>();
            namirnicaNaListi.Add(new NamirnicaNaListi("Kruh", "1", "", "KTC"));
            namirnicaNaListi.Add(new NamirnicaNaListi("Mlijeko", "6", "7,99", ""));
            namirnicaNaListi.Add(new NamirnicaNaListi("Jack Daniels 10l", "1", "1499", "KTC"));
            namirnicaNaListi.Add(new NamirnicaNaListi("Kuhalo za vodu", "", "", ""));
            return namirnicaNaListi;
        }
    }
}
