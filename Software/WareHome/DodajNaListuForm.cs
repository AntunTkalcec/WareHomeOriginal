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
    public partial class DodajNaListuForm : Form
    {
        public ListaZaKupovinu odabranaLista;

        public DodajNaListuForm(ListaZaKupovinu odabrana)
        {
            InitializeComponent();
            odabranaLista = odabrana;
            AcceptButton = dodajButton;
            CancelButton = odustaniButton;
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
            if (nazivArtikla.Length <= 30 && nazivArtikla.Length >= 1 && cijena.Length <= 10 && količina.Length <= 10 && trgovina.Length <= 30)
            {
                NamirnicaNaListiRepository.DodajNamirnicu(new NamirnicaNaListi(0, odabranaLista.IdListe, nazivArtikla, cijena, količina, trgovina));
                Close();
            }
            else
            {
                MessageBox.Show("Neispravan unos!\nProvjerite naziv (max. 30 znakova), količina (max. 10 znakova), cijena (max. 10 znakova) i trgovina (max. 30 znakova).", "Greška!");
            }
        }
    }
}