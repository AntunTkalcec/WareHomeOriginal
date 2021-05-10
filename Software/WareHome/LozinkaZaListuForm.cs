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
    public partial class LozinkaZaListuForm : Form
    {
        ListaZaKupovinu odabranaLista;
        int pokusaji = 3;

        public LozinkaZaListuForm(ListaZaKupovinu odabrana)
        {
            InitializeComponent();
            odabranaLista = odabrana;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LozinkaZaListuForm_Load(object sender, EventArgs e)
        {
            lozinkaTextBox.PasswordChar = '*';
            label1.Text = odabranaLista.NazivListe;
        }

        private void prikažiButton_Click(object sender, EventArgs e)
        {
            if (odabranaLista.LozinkaListe == lozinkaTextBox.Text)
            {
                ListaForm listaForm = new ListaForm(odabranaLista);
                listaForm.Show();
                Close();
            }
            else
            {
                if (pokusaji == 0)
                {
                    Close();
                }
                MessageBox.Show("Pogrešna lozinka! Preostalo pokušaja: " + pokusaji);
                pokusaji--;
            }
        }
    }
}
