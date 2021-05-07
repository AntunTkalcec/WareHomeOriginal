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
        List<ListeZaKupovinu> listeZaKupovinu = new List<ListeZaKupovinu>();

        public ListeForm()
        {
            InitializeComponent();
        }

        private void povratakButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void prikažiButton_Click(object sender, EventArgs e)
        {
            ListaForm listaForm = new ListaForm("KTC");
            listaForm.Show();
        }

        private void ListeForm_Load(object sender, EventArgs e)
        {
            listeZaKupovinu.Add(new ListeZaKupovinu("KTC", false, null));
            listeZaKupovinu.Add(new ListeZaKupovinu("Zabava u petak", true, "123"));

            List<PrikazLista> prikazLista = new List<PrikazLista>();
            foreach (var item in listeZaKupovinu)
            {
                prikazLista.Add(new PrikazLista(item.NazivListe, item.PrivatnaLista));
            }

            listeDataGridView.DataSource = prikazLista;
        }

        private void kreirajButton_Click(object sender, EventArgs e)
        {
            NovaListaForm novaListaForm = new NovaListaForm();
            novaListaForm.ShowDialog();
            OsvjeziListu();
        }

        private void OsvjeziListu()
        {
            throw new NotImplementedException();
        }
    }
}
