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
    public partial class NovaListaForm : Form
    {
        public NovaListaForm()
        {
            InitializeComponent();
        }

        private void NovaListaForm_Load(object sender, EventArgs e)
        {

        }

        private void završiButton_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
