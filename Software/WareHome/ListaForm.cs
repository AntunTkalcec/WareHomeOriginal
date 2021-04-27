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
        public ListaForm()
        {
            InitializeComponent();
        }

        private List<NamirniceNaListi> namirniceNaListi;

        private void povratakButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListaForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
