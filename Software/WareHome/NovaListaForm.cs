using DatabaseAccess;
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
    public partial class NovaListaForm : Form
    {
        public NovaListaForm()
        {
            InitializeComponent();
            AcceptButton = završiButton;
            CancelButton = odustaniButton;
        }

        ListaZaKupovinu preimenujListu = null;
        
        public NovaListaForm(ListaZaKupovinu listaZaKupovinu)
        {
            InitializeComponent();
            preimenujListu = null;
            preimenujListu = listaZaKupovinu;
        }

        private void NovaListaForm_Load(object sender, EventArgs e)
        {
            privatnaCheckBox.Checked = false;
            lozinkaTextBox.Enabled = false;
            lozinkaTextBox.PasswordChar = '*';
            Text = "Nova lista";
            završiButton.Text = "Kreiraj";

            if (preimenujListu != null)
            {
                Text = "Preimenuj listu";
                završiButton.Text = "Završi";
                nazivTextBox.Text = preimenujListu.NazivListe;
                if (preimenujListu.PrivatnaLista)
                {
                    lozinkaTextBox.Enabled = true;
                    privatnaCheckBox.Checked = true;
                    lozinkaTextBox.Text = preimenujListu.LozinkaListe;
                }
            }
        }

        private void završiButton_Click(object sender, EventArgs e)
        {
            string naziv = nazivTextBox.Text;
            bool privatna;
            string lozinka;
            if (privatnaCheckBox.Checked)
            {
                privatna = true;
                lozinka = lozinkaTextBox.Text;
            }
            else
            {
                privatna = false;
                lozinka = null;
            }

            if (naziv != "" && naziv.Length <=30 && privatna == false)
            {
                if (preimenujListu != null)
                {
                    ListaZaKupovinuRepository.PreimenujListu(preimenujListu, naziv, privatna, lozinka);
                    Close();
                }
                else
                {
                    ListaZaKupovinuRepository.DodajListu(naziv, privatna, lozinka);
                    Close();
                }
            }
            else if (naziv != "" && naziv.Length <= 30 && privatna == true && lozinka.Length <= 30)
            {
                if (preimenujListu != null)
                {
                    ListaZaKupovinuRepository.PreimenujListu(preimenujListu, naziv, privatna, lozinka);
                    Close();
                }
                else
                {
                    ListaZaKupovinuRepository.DodajListu(naziv, privatna, lozinka);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Provjerite uneseni naziv liste (max. 30 znakova) i lozinku liste (max. 30 znakova)!", "Greška!");
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void privatnaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (privatnaCheckBox.Checked)
            {
                lozinkaTextBox.Enabled = true;
            }
            else
            {
                lozinkaTextBox.Enabled = false;
            }
        }
    }
}
