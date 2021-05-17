using DatabaseAccess;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHome.Models.Raspored;
using WareHome_Logic;

namespace WareHome
{
    public partial class GlavnaForm : Form
    {
        static Korisnik trenutniKorisnik;

        public GlavnaForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
        }

        private void GlavnaForm_Load(object sender, EventArgs e)
        {
            OsvjeziDomacinstvo();
            OsvjeziNamirnice();
        }

        private void OsvjeziNamirnice()
        {
            if (trenutniKorisnik.Domacinstvo != null)
            {
                Database.Instance.Connect();
                namirniceDGV.DataSource = NamirnicaRepository.DohvatiNamirnice(trenutniKorisnik.Domacinstvo);
                int brojNamirnica = namirniceDGV.Rows.Count;
                brojNamirnicaLabel2.Text = brojNamirnica.ToString();
                Database.Instance.Disconnect();
            }
        }

        private void OsvjeziDomacinstvo()
        {
            if (trenutniKorisnik.Ime.Length + trenutniKorisnik.Prezime.Length > 16 && trenutniKorisnik.Ime.Length <= 15)
            {
                korisnikLabel2.Text = trenutniKorisnik.Ime + " " + trenutniKorisnik.Prezime.Substring(0, 1) + ".";
            }
            else if (trenutniKorisnik.Ime.Length + trenutniKorisnik.Prezime.Length > 16 && trenutniKorisnik.Ime.Length > 15)
            {
                korisnikLabel2.Text = trenutniKorisnik.KorisnickoIme;
            }
            else
            {
                korisnikLabel2.Text = trenutniKorisnik.Ime + " " + trenutniKorisnik.Prezime;
            }

            if (trenutniKorisnik.Domacinstvo == null)
            {
                namirniceDGV.DataSource = null;
                trenutnoDomacinstvoLabel2.Text = "N/A";
                brojNamirnicaLabel2.Text = "N/A";

                MessageBox.Show("Niste član domaćinstva! Za korištenje svih funkcija aplikacije, izradite novo domaćinstvo ili se pridružite postojećem.", "Obavijest");
                nisteDioDomacinstvaLabel.Visible = true;
                izradiDomacinstvoButton.Visible = true;
                pridruziDomacinstvuButton.Visible = true;
                dodajNamirnicuButton.Enabled = false;
                promijeniNamirnicuButton.Enabled = false;
                obrisiNamirnicuButton.Enabled = false;
                listeButton.Enabled = false;
                pdfButton.Enabled = false;
                rasporedButton.Enabled = false;
                predviđanjeButton.Enabled = false;

                testiranjeButton.Visible = false; 
            }
            else
            {
                testiranjeButton.Visible = false; 
                if (trenutniKorisnik.KorisnickoIme == "admin") //user: admin | pass: admin\\
                {
                    testiranjeButton.Visible = true;
                } 

                nisteDioDomacinstvaLabel.Visible = false;
                izradiDomacinstvoButton.Visible = false;
                pridruziDomacinstvuButton.Visible = false;
                dodajNamirnicuButton.Enabled = true;
                promijeniNamirnicuButton.Enabled = true;
                obrisiNamirnicuButton.Enabled = true;
                listeButton.Enabled = true;
                pdfButton.Enabled = true;
                rasporedButton.Enabled = true;
                predviđanjeButton.Enabled = true;

                trenutnoDomacinstvoLabel2.Text = trenutniKorisnik.Domacinstvo.Naziv;
                OsvjeziNamirnice();
            }
        }

        private void rasporedButton_Click(object sender, EventArgs e)
        {
            RasporedForm rasporedForm = new RasporedForm(trenutniKorisnik);
            rasporedForm.ShowDialog();
        }

        private void odjavaButton_Click(object sender, EventArgs e)
        {
            trenutniKorisnik = null;
            Close();
        }

        private void listeButton_Click(object sender, EventArgs e)
        {
            ListeForm listeForm = new ListeForm(trenutniKorisnik);
            listeForm.ShowDialog();
        }

        private void exitAppButton_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dodajNamirnicuButton_Click(object sender, EventArgs e)
        {
            DodajNamirnicuForm dodajNamirnicuForm = new DodajNamirnicuForm(trenutniKorisnik);
            dodajNamirnicuForm.ShowDialog();
            OsvjeziNamirnice();
        }

        private void obrisiNamirnicuButton_Click(object sender, EventArgs e)
        {
            if (namirniceDGV.CurrentRow != null)
            {
                Database.Instance.Connect();
                NamirnicaRepository.Obrisi(namirniceDGV.CurrentRow.DataBoundItem as Namirnica);
                Database.Instance.Disconnect();
            }
            OsvjeziNamirnice();
        }

        private void promijeniNamirnicuButton_Click(object sender, EventArgs e)
        {
            if (namirniceDGV.CurrentRow != null)
            {
                PromijeniNamirnicuForm promijeniNamirnicuForm = new PromijeniNamirnicuForm(namirniceDGV.CurrentRow.DataBoundItem as Namirnica);
                promijeniNamirnicuForm.ShowDialog();
            }
            OsvjeziNamirnice();
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            string naziv = "WareHome stanje namirnica ("+DateTime.Today.Date.Day + "." + DateTime.Today.Date.Month + "." + DateTime.Today.Date.Year + ".)";
            if (namirniceDGV.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = naziv.ToString()
                };
                bool greska = false;
                if (sfd.ShowDialog() == DialogResult.Cancel)
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException)
                    {
                        greska = true;
                        MessageBox.Show("Dogodila se greška.");
                    }
                }
                if (!greska)
                {
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(namirniceDGV.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                        string[] headers = new string[]
                        {
                            "ID", "Naziv namirnice", "Dostupna količina", "Optimalna količina", "Mjerna jedinica", "Cijena", "Dućan", "Zadnja promjena", "Domaćinstvo"
                        };
                        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, false);
                        iTextSharp.text.Font titlefont = new iTextSharp.text.Font(bf, 13);
                        iTextSharp.text.Font infofont = new iTextSharp.text.Font(bf, 10);
                        pdfTable.SetWidths(GetHeaderWidths(titlefont, headers));
                        for (int i = 0; i < headers.Length; ++i)
                        {
                            pdfTable.AddCell(new PdfPCell(new Phrase(headers[i], titlefont)));
                        }
                        foreach (DataGridViewRow row in namirniceDGV.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell cell1 = new PdfPCell(new Phrase(cell.FormattedValue.ToString(), infofont));
                                pdfTable.AddCell(cell1);
                            }
                        }
                        PdfPTable tableStatistika = new PdfPTable(3);
                        tableStatistika.DefaultCell.Padding = 3;
                        tableStatistika.WidthPercentage = 100;
                        tableStatistika.HorizontalAlignment = Element.ALIGN_CENTER;
                        string[] headers2 = new string[]
                        {
                            "Naziv namirnice", "Potrošnja u zadnjih 7 dana", "Ukupna cijena"
                        };
                        string sql = $"SELECT n.naziv_namirnice as Namirnica, sum(d.promjena)*-1 as Suma, n.cijena*sum(d.promjena)*-1 as Cijena from Dogadaj d," +
                            $"Namirnica n where datum_dogadaja >= dateadd(day, -8, getdate()) " +
                            $"and id_namirnice = n.namirnica_id and n.domacinstvo_id = {trenutniKorisnik.Domacinstvo.Identifikator} " +
                            $"group by naziv_namirnice, cijena order by cijena desc";
                        List<Statistika> statistika = new List<Statistika>();
                        Statistika stat = new Statistika();
                        Database.Instance.Connect();
                        IDataReader dataReader = Database.Instance.GetDataReader(sql);
                        while (dataReader.Read())
                        {
                            stat = new Statistika
                            {
                                Namirnica = dataReader["Namirnica"].ToString(),
                                Suma = float.Parse(dataReader["Suma"].ToString()),
                                Cijena = float.Parse(dataReader["Cijena"].ToString())
                            };
                            statistika.Add(stat);
                        }
                        dataReader.Close();
                        Database.Instance.Disconnect();
                        tableStatistika.SetWidths(GetHeaderWidths(titlefont, headers2));
                        for (int i = 0; i < headers2.Length; i++)
                        {
                            tableStatistika.AddCell(new PdfPCell(new Phrase(headers2[i], titlefont)));
                        }
                        foreach (var item in statistika)
                        {
                            tableStatistika.AddCell(new PdfPCell(new Phrase(item.Namirnica, infofont)));
                            tableStatistika.AddCell(new PdfPCell(new Phrase(item.Suma.ToString(), infofont)));
                            tableStatistika.AddCell(new PdfPCell(new Phrase(item.Cijena.ToString(), infofont)));
                        }
                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Chunk c1 = new Chunk("Trenutno stanje namirnica: \n", FontFactory.GetFont("dax-black", 20, BaseColor.BLACK));
                            c1.SetUnderline(0.5f, -1.5f);
                            Chunk c2 = new Chunk("  \n");
                            Chunk c3 = new Chunk("  \n");
                            Paragraph p = new Paragraph();
                            Phrase p1 = new Phrase(c1);
                            Phrase p2 = new Phrase
                            {
                                c2,
                                c3
                            };
                            Chunk c4 = new Chunk("Statistika korištenja namirnica: \n", FontFactory.GetFont("helvetica", 20, BaseColor.BLACK));
                            c4.SetUnderline(0.5f, -1.5f);
                            Document pdfDoc = new Document(PageSize.A4.Rotate());
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            p.Add(p1);
                            p.Add(p2);
                            pdfDoc.Add(p);
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Add(p2);
                            pdfDoc.Add(c4);
                            pdfDoc.Add(p2);
                            pdfDoc.Add(tableStatistika);
                            pdfDoc.Close();
                            stream.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greška: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nema podataka u tablici koji bi se mogli spremiti u PDF!");
            }
        }

        private float[] GetHeaderWidths(iTextSharp.text.Font titlefont, params string[] headers)
        {
            var total = 0;
            var columns = headers.Length;
            var widths = new int[columns];
            for (var i = 0; i < columns; ++i)
            {
                var w = titlefont.GetCalculatedBaseFont(true).GetWidth(headers[i]);
                total += w;
                widths[i] = w;
            }
            var rezultat = new float[columns];
            for (var i = 0; i < columns; ++i)
            {
                rezultat[i] = (float)widths[i] / total * 100;
            }
            return rezultat;
        }

        private void TestiranjeButton_Click(object sender, EventArgs e)
        {
            TestiranjeForm testiranje = new TestiranjeForm(trenutniKorisnik);
            testiranje.ShowDialog();
            OsvjeziDomacinstvo();
            OsvjeziNamirnice();
        }

        private void warehomePictureBox_Click(object sender, EventArgs e)
        {
            OsvjeziNamirnice();
        }

        private void warehomePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void izradiDomacinstvoButton_Click(object sender, EventArgs e)
        {
            DomacinstvoRepository.PridruzivanjeUspješno = false;
            IzradaDomacinstvaForm form = new IzradaDomacinstvaForm(trenutniKorisnik);
            form.ShowDialog();
            if (DomacinstvoRepository.PridruzivanjeUspješno)
            {
                OsvjeziDomacinstvo();
            }
        }

        private void pridruziDomacinstvuButton_Click(object sender, EventArgs e)
        {
            DomacinstvoRepository.PridruzivanjeUspješno = false;
            PridruziDomacinstvuForm form = new PridruziDomacinstvuForm(trenutniKorisnik);
            form.ShowDialog();
            if (DomacinstvoRepository.PridruzivanjeUspješno)
            {
                OsvjeziDomacinstvo();
            }
        }

        private void btnPrijaviProblem_Click(object sender, EventArgs e)
        {
            PrijavaProblemaForm form = new PrijavaProblemaForm(trenutniKorisnik);
            form.ShowDialog();
        }

        private void predviđanjeButton_Click(object sender, EventArgs e)
        {
            PredviđanjeForm predviđanjeForm = new PredviđanjeForm(trenutniKorisnik);
            predviđanjeForm.ShowDialog();
        }
    }
}
