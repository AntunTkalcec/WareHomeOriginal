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
using WareHome.Models.ListaZaKupovinu;
using WareHome.Models.PredviđanjePotrošnje;
using WareHome_Logic;

namespace WareHome
{
    public partial class PredviđanjeForm : Form
    {
        Korisnik trenutniKorisnik;
        List<PredviđenaPotrošnja> predviđenaPotrošnja;

        public PredviđanjeForm(Korisnik korisnik)
        {
            InitializeComponent();
            UpišiKorisnika(korisnik);
            AcceptButton = ispisiButton;
            CancelButton = povratakButton;
        }

        private void UpišiKorisnika(Korisnik korisnik)
        {
            trenutniKorisnik = null;
            trenutniKorisnik = korisnik;
        }

        private void PredviđanjeForm_Load(object sender, EventArgs e)
        {
            predviđenaPotrošnja = null;
            predviđenaPotrošnja = PredviđanjePotrošnjeRepository.PredvidiPotrošnju(trenutniKorisnik);
            predvidanjeDataGridView.DataSource = predviđenaPotrošnja;

            predvidanjeDataGridView.Columns["NamirnicaId"].ReadOnly = true;
            predvidanjeDataGridView.Columns["NamirnicaId"].HeaderText = "ID";
            predvidanjeDataGridView.Columns["NamirnicaId"].Width = 35;

            predvidanjeDataGridView.Columns["NamirnicaNaziv"].ReadOnly = true;
            predvidanjeDataGridView.Columns["NamirnicaNaziv"].HeaderText = "Naziv";
            predvidanjeDataGridView.Columns["NamirnicaNaziv"].Width = 211;

            predvidanjeDataGridView.Columns["DostupnaKoličina"].ReadOnly = true;
            predvidanjeDataGridView.Columns["DostupnaKoličina"].HeaderText = "Dostupna količina";
            predvidanjeDataGridView.Columns["DostupnaKoličina"].Width = 150;

            predvidanjeDataGridView.Columns["MjernaJedinica"].ReadOnly = true;
            predvidanjeDataGridView.Columns["MjernaJedinica"].HeaderText = "Mjerna jedinica";
            predvidanjeDataGridView.Columns["MjernaJedinica"].Width = 150;

            predvidanjeDataGridView.Columns["PredviđenoTrajanje"].ReadOnly = true;
            predvidanjeDataGridView.Columns["PredviđenoTrajanje"].HeaderText = "Predviđeno trajanje (u danima)";
            predvidanjeDataGridView.Columns["PredviđenoTrajanje"].Width = 175;
        }

        private void povratakButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ispisiButton_Click(object sender, EventArgs e)
        {
            SpremiUPDF();
        }

        private void SpremiUPDF()
        {
            string naziv = "WareHome predviđanje potrošnje";
            if (predvidanjeDataGridView.Rows.Count > 0)
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
                        MessageBox.Show("Dogodila se greška!", "Greška!");
                    }
                }
                if (!greska)
                {
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(predvidanjeDataGridView.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                        string[] headers = new string[]
                        {
                            "ID", "Naziv", "Dostupno", "Mjerna jedinica", "Predviđeno trajanje"
                        };
                        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, false);
                        iTextSharp.text.Font titlefont = new iTextSharp.text.Font(bf, 13);
                        iTextSharp.text.Font infofont = new iTextSharp.text.Font(bf, 10);
                        pdfTable.SetWidths(GetHeaderWidths(titlefont, headers));

                        for (int i = 0; i < headers.Length; ++i)
                        {
                            pdfTable.AddCell(new PdfPCell(new Phrase(headers[i], titlefont)));
                        }
                        foreach (DataGridViewRow row in predvidanjeDataGridView.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell cell1 = new PdfPCell(new Phrase(cell.FormattedValue.ToString(), infofont));
                                pdfTable.AddCell(cell1);
                            }
                        }
                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Chunk c1 = new Chunk($"Predviđanje potrošnje namirnica: \n", FontFactory.GetFont("dax-black", 20, BaseColor.BLACK));
                            Chunk c2 = new Chunk("  \n");
                            Chunk c3 = new Chunk("  \n");
                            Paragraph p = new Paragraph();
                            Phrase p1 = new Phrase(c1);
                            Phrase p2 = new Phrase
                            {
                                c2,
                                c3
                            };
                            p.Add(p1);
                            p.Add(p2);
                            c1.SetUnderline(0.5f, -1.5f);
                            Document pdfDoc = new Document(PageSize.A4.Rotate());
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(p);
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greška: " + ex.Message, "Greška!");
                    }
                }
            }
            else
            {
                MessageBox.Show($"Nema podataka u tablici koji bi se mogli spremiti u PDF! \n", "Greška!");
            }
        }

        private float[] GetHeaderWidths(iTextSharp.text.Font titlefont, string[] headers)
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
    }
}
