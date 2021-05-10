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
    public partial class DodajArtiklNaListu : Form
    {
        public ListaZaKupovinu odabranaLista;

        public DodajArtiklNaListu(ListaZaKupovinu odabrana)
        {
            InitializeComponent();
            odabranaLista = odabrana;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            string nazivArtikla = nazivTextBox.Text;
            string cijena = cijenaTextBox.Text;
            string količina = kolicinaTextBox.Text;
            string trgovina = trgovinaTextBox.Text;
            NamirnicaNaListiRepository.DodajNamirnicu(new NamirnicaNaListi(0, odabranaLista.IdListe, nazivArtikla, cijena, količina, trgovina));
            Close();
        }
    }
}