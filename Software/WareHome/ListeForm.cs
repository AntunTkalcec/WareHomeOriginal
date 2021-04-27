using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHome
{
    public partial class ListeForm : Form
    {
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
            ListaForm listaForm = new ListaForm();
            listaForm.Show();
        }
    }
}
