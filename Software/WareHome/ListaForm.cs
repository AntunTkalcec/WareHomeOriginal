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
        public ListaForm(string nazivListe)
        {
            InitializeComponent();
            nazivLabel.Text = nazivListe;
        }

        private List<NamirniceNaListi> namirniceNaListi;

        private void povratakButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListaForm_Load(object sender, EventArgs e)
        {
            namirniceNaListi = new List<NamirniceNaListi>();
            namirniceNaListi.Add(new NamirniceNaListi("Kruh", "1", "", "KTC"));
            namirniceNaListi.Add(new NamirniceNaListi("Mlijeko", "6", "7,99", ""));
            namirniceNaListi.Add(new NamirniceNaListi("Jack Daniels 10l", "1", "1499", "KTC"));
            namirniceNaListi.Add(new NamirniceNaListi("Kuhalo za vodu", "", "", ""));
            namirniceDataGridView.DataSource = namirniceNaListi;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DodajArtiklNaListu dodajArtiklNaListu = new DodajArtiklNaListu();
            dodajArtiklNaListu.ShowDialog();
            OsvjeziListu();
        }

        private void OsvjeziListu()
        {
            throw new NotImplementedException();
        }
    }
}
