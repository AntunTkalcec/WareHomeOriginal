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
using WareHome_Logic;

namespace WareHome
{
    public partial class PridruziDomacinstvuForm : Form
    {
        Korisnik trenutniKorisnik;
        private Domacinstvo zeljenoDomacinstvo = new Domacinstvo();
        public PridruziDomacinstvuForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
            AcceptButton = btnPotvrdi;
            CancelButton = exitAppButton;
            ActiveControl = domacinstvoNazivTextBox;
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (ProvjeriPostojanje())
            {
                StaviKorisnikaUDomacinstvo();
                DomacinstvoRepository.PridruzivanjeUspješno = true;
                MessageBox.Show($"Pridruženi ste domaćinstvu {trenutniKorisnik.Domacinstvo.Naziv}!", "Obavijest");
                Close();
                GlavnaForm form = new GlavnaForm(trenutniKorisnik);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ne postoji domaćinstvo s unesenim nazivom.", "Greška!");
            }
        }

        private void StaviKorisnikaUDomacinstvo()
        {
            string sql = $"UPDATE Korisnik SET domacinstvo = {zeljenoDomacinstvo.Identifikator} where Korisnik.korisnik_id = {trenutniKorisnik.Identifikator}";
            Database.Instance.Connect();
            Database.Instance.ExecuteCommand(sql);
            trenutniKorisnik.Domacinstvo = zeljenoDomacinstvo;
            Database.Instance.Disconnect();
        }

        private bool ProvjeriPostojanje()
        {
            string sql = "SELECT * FROM Domacinstvo";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                if (dataReader["naziv"].ToString() == domacinstvoNazivTextBox.Text)
                {
                    zeljenoDomacinstvo.Identifikator = int.Parse(dataReader["domacinstvo_id"].ToString());
                    zeljenoDomacinstvo.Naziv = dataReader["naziv"].ToString();
                    zeljenoDomacinstvo.DatumKreiranja = DateTime.Parse(dataReader["datum_kreiranja"].ToString());
                    dataReader.Close();
                    Database.Instance.Disconnect();
                    return true;
                }
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return false;
        }
    }
}
