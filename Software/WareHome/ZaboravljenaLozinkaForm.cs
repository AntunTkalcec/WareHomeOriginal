using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHome_Logic;

namespace WareHome
{
    public partial class ZaboravljenaLozinkaForm : Form
    {
        public ZaboravljenaLozinkaForm()
        {
            InitializeComponent();
        }

        private void PovratiLozinkuButton_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                
                Database.Instance.Connect();
                string sql = "SELECT * FROM Korisnik";
                IDataReader dataReader = Database.Instance.GetDataReader(sql);
                string email = "";
                string lozinka = "";
                bool pronadeno = false;
                while (dataReader.Read())
                {
                    if (dataReader["korisnicko_ime"].ToString() == korimeZaboravljenoTextBox.Text)
                    {
                        email = dataReader["e-mail"].ToString();
                        lozinka = dataReader["lozinka"].ToString();
                        pronadeno = true;
                    }
                }
                if (!pronadeno)
                {
                    MessageBox.Show("Ne postoji korisnik s tim korisničkim imenom.");
                    dataReader.Close();
                    Database.Instance.Disconnect();
                    return;
                }
                mail.From = new MailAddress("warehomeapp@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Povrat zaboravljene lozinke";
                mail.Body = $"Vaša zaboravljena lozinka za WareHome aplikaciju jest: {lozinka}";

                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("warehomeapp", "WarehomeApp246.");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Lozinka vam je poslana na mail na koji je registriran vaš korisnički račun.");
                dataReader.Close();
                Database.Instance.Disconnect();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Close();
            }
        }

        private void exitAppButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ZaboravljenaLozinkaForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string helpLocation = Path.Combine(executableLocation, "helpfile.chm");
            string helpfile = "File://" + helpLocation;
            Help.ShowHelp(this, helpfile, HelpNavigator.KeywordIndex, "2.3. Povrat zaboravljene lozinke");
        }
    }
}
