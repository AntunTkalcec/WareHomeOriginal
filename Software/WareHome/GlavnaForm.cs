using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHome.Models.Raspored;

namespace WareHome
{
    public partial class GlavnaForm : Form
    {
        public GlavnaForm()
        {
            InitializeComponent();
        }

        Raspored glavniRaspored = new Raspored();

        private void GlavnaForm_Load(object sender, EventArgs e)
        {

        }

        private void rasporedButton_Click(object sender, EventArgs e)
        {
            RasporedForm rasporedForm = new RasporedForm(glavniRaspored);
            rasporedForm.ShowDialog();
        }

        private void odjavaButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listeButton_Click(object sender, EventArgs e)
        {
            ListeForm listeForm = new ListeForm();
            listeForm.Show();
        }
    }
}
