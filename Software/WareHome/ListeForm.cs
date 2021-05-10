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
    public partial class ListeForm : Form
    {
        List<ListaZaKupovinu> listeZaKupovinu;

        public ListeForm()
        {
            InitializeComponent();
        }

        private void ListeForm_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
        }

        private void povratakButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void prikažiButton_Click(object sender, EventArgs e)
        {
            ListaZaKupovinu odabrana = listeDataGridView.CurrentRow.DataBoundItem as ListaZaKupovinu;
            if (odabrana.PrivatnaLista)
            {
                LozinkaZaListuForm lozinkaZaListuForm = new LozinkaZaListuForm(odabrana);
                lozinkaZaListuForm.ShowDialog();
            }
            else
            {
                ListaForm listaForm = new ListaForm(odabrana);
                listaForm.Show();
            }
            OsvjeziListu();
        }

        private void kreirajButton_Click(object sender, EventArgs e)
        {
            NovaListaForm novaListaForm = new NovaListaForm();
            novaListaForm.ShowDialog();
            OsvjeziListu();
        }

        private void OsvjeziListu()
        {
            listeZaKupovinu = null;
            listeZaKupovinu = ListaZaKupovinuRepository.DohvatiPopisLista();
            listeDataGridView.DataSource = null;
            listeDataGridView.DataSource = listeZaKupovinu;
            listeDataGridView.Columns["LozinkaListe"].Visible = false;
            listeDataGridView.Columns["PrivatnaLista"].ReadOnly = true;
            listeDataGridView.Columns["NazivListe"].ReadOnly = true;
            listeDataGridView.Columns["PrivatnaLista"].HeaderText = "Privatna lista";
            listeDataGridView.Columns["NazivListe"].HeaderText = "Naziv liste";
        }

        private void obrišiButton_Click(object sender, EventArgs e)
        {
            ListaZaKupovinu obriši = listeDataGridView.CurrentRow.DataBoundItem as ListaZaKupovinu;
            ListaZaKupovinuRepository.UkloniListu(obriši);

            OsvjeziListu();
        }
    }
}
