using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHome_Logic;

namespace WareHome
{
    public partial class IzradaDomacinstvaForm : Form
    {
        Korisnik trenutniKorisnik;
        public IzradaDomacinstvaForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
            AcceptButton = btnPotvrdi;
            CancelButton = exitAppButton;
            ActiveControl = domacinstvoNazivTextBox;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (ProvjeriPostojanje())
            {
                MessageBox.Show("Već postoji domaćinstvo s tim nazivom!", "Greška!");
            }
            else
            {
                if (domacinstvoNazivTextBox.Text.Length > 1)
                {
                    Domacinstvo novoDomacinstvo = new Domacinstvo();
                    novoDomacinstvo.Naziv = domacinstvoNazivTextBox.Text;
                    novoDomacinstvo.DatumKreiranja = DateTime.Today;

                    Database.Instance.Connect();
                    DomacinstvoRepository.Spremi(novoDomacinstvo);
                    Database.Instance.Disconnect();
                    StaviKorisnikaUDomacinstvo(novoDomacinstvo);
                    DomacinstvoRepository.PridruzivanjeUspješno = true;
                    MessageBox.Show($"Domaćinstvo {novoDomacinstvo.Naziv} izrađeno!", "Obavijest");
                    Close();
                }
                else
                {
                    MessageBox.Show("Unesite naziv domaćinstva!", "Greška!");
                }
            }
        }

        private void StaviKorisnikaUDomacinstvo(Domacinstvo domacinstvo)
        {
            string sql = $"SELECT * FROM Domacinstvo";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                if (dataReader["naziv"].ToString() == domacinstvo.Naziv)
                {
                    domacinstvo.Identifikator = int.Parse(dataReader["domacinstvo_id"].ToString());
                    break;
                }
            }
            dataReader.Close();
            trenutniKorisnik.Domacinstvo = domacinstvo;
            sql = $"UPDATE Korisnik SET domacinstvo = {domacinstvo.Identifikator} where Korisnik.korisnik_id = {trenutniKorisnik.Identifikator}";
            Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
        }

        private bool ProvjeriPostojanje()
        {
            string sql = $"SELECT * FROM Domacinstvo";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                if (dataReader["naziv"].ToString() == domacinstvoNazivTextBox.Text)
                {
                    dataReader.Close();
                    Database.Instance.Disconnect();
                    return true;
                }
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void IzradaDomacinstvaForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string helpLocation = Path.Combine(executableLocation, "helpfile.chm");
            string helpfile = "File://" + helpLocation;
            Help.ShowHelp(this, helpfile, HelpNavigator.KeywordIndex, "3.2. Izrada novog domacinstva");
        }
    }
}
