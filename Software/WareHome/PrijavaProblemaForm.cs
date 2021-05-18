using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHome_Logic;

namespace WareHome
{
    public partial class PrijavaProblemaForm : Form
    {
        Korisnik trenutniKorisnik;
        public PrijavaProblemaForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
            CancelButton = exitAppButton;
            ActiveControl = problemTextBox;
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            string opis = problemTextBox.Text;
            DateTime datum = DateTime.Today;
            string korisnickoIme = trenutniKorisnik.KorisnickoIme;
            string email = "Pošiljatelj prijave: " + korisnickoIme + "\n" 
                + "Email pošiljatelja: " + trenutniKorisnik.Mail + "\n"  
                + "Datum slanja: " + datum.ToShortDateString() + "\n" 
                + opis;
            PosaljiMail(email);
        }

        private void PosaljiMail(string email)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("warehomeapp@gmail.com");
                mail.To.Add("warehomeapp@gmail.com");
                mail.Subject = "WareHome prijava problema";
                mail.Body = email;

                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("warehomeapp", "WarehomeApp246.");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Problem uspješno prijavljen. Hvala Vam!", "Prijava problema");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Close();
            }
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
