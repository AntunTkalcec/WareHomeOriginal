﻿using DatabaseAccess;
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
        }

        ListaZaKupovinu preimenujListu = null;
        
        public NovaListaForm(ListaZaKupovinu listaZaKupovinu)
        {
            InitializeComponent();
            preimenujListu = listaZaKupovinu;
        }

        private void NovaListaForm_Load(object sender, EventArgs e)
        {
            privatnaCheckBox.Checked = false;
            lozinkaTextBox.Enabled = false;
            lozinkaTextBox.PasswordChar = '*';

            if (preimenujListu != null)
            {
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

            if (preimenujListu != null)
            {
                ListaZaKupovinuRepository.PreimenujListu(preimenujListu, naziv, privatna, lozinka);
                Close();
            }
            else if (naziv != "" && naziv.Length <=30)
            {
                ListaZaKupovinuRepository.DodajListu(naziv, privatna, lozinka);
                Close();
            }
            else
            {
                MessageBox.Show("Unesite naziv liste (do 30 znakova)!");
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
