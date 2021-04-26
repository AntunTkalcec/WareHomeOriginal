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
    public partial class PrijavaForm : Form
    {
        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void PrijavaForm_Load(object sender, EventArgs e)
        {

        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            Hide();
            GlavnaForm glavna = new GlavnaForm();
            glavna.ShowDialog();
            Show();
        }

        private void registracijaButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegistracijaForm registracija = new RegistracijaForm();
            registracija.ShowDialog();
            Show();
        }
    }
}
