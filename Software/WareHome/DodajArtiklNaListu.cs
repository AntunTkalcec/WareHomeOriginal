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
            string nazivListe = odabranaLista.NazivListe;
            string nazivArtikla = nazivTextBox.Text;
            string cijena = cijenaTextBox.Text;
            string količina = kolicinaTextBox.Text;
            string trgovina = trgovinaTextBox.Text;
            NamirnicaNaListi novaNamirnica = new NamirnicaNaListi(nazivListe, nazivArtikla, cijena, količina, trgovina);
            NamirnicaNaListiRepository.DodajNamirnicu(novaNamirnica);
            Close();
        }
    }
}
