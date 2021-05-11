﻿using DatabaseAccess;
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
        Korisnik trenutniKorisnik = new Korisnik();
        public GlavnaForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
        }

        Raspored glavniRaspored = new Raspored();

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
            if (trenutniKorisnik.Domacinstvo == null)
            {
                MessageBox.Show("Ne pripadate nikakvom domaćinstvu. Molimo, izradite novo domaćinstvo ili se pridružite postojećem.");
                nisteDioDomacinstvaLabel.Visible = true;
                dodajNamirnicuButton.Enabled = false;
                promijeniNamirnicuButton.Enabled = false;
                obrisiNamirnicuButton.Enabled = false;
            }
            else
            {
                izradiDomacinstvoButton.Enabled = false;
                pridruziDomacinstvuButton.Enabled = false;
                trenutnoDomacinstvoLabel2.Text = trenutniKorisnik.Domacinstvo.Naziv;
                OsvjeziNamirnice();
            }
        }
        private void GlavnaForm_Load(object sender, EventArgs e)
        {
            OsvjeziDomacinstvo();
            OsvjeziNamirnice();
        }

        private void rasporedButton_Click(object sender, EventArgs e)
        {
            RasporedForm rasporedForm = new RasporedForm(glavniRaspored);
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
            listeForm.Show();
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
            Database.Instance.Connect();
            NamirnicaRepository.Obrisi(namirniceDGV.CurrentRow.DataBoundItem as Namirnica);
            Database.Instance.Disconnect();
            OsvjeziNamirnice();
        }

        private void promijeniNamirnicuButton_Click(object sender, EventArgs e)
        {
            PromijeniNamirnicuForm promijeniNamirnicuForm = new PromijeniNamirnicuForm(namirniceDGV.CurrentRow.DataBoundItem as Namirnica);
            promijeniNamirnicuForm.ShowDialog();
            OsvjeziNamirnice();
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            if (namirniceDGV.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Warehome stanje namirnica.pdf";
                bool greska = false;
                if (sfd.ShowDialog() == DialogResult.OK)
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
                        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, false);
                        iTextSharp.text.Font titlefont = new iTextSharp.text.Font(bf, 14);
                        iTextSharp.text.Font infofont = new iTextSharp.text.Font(bf, 10);
                        foreach (DataGridViewColumn column in namirniceDGV.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titlefont));
                            pdfTable.AddCell(cell);
                        }
                        foreach (DataGridViewRow row in namirniceDGV.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell cell1 = new PdfPCell(new Phrase(cell.FormattedValue.ToString(), infofont));
                                pdfTable.AddCell(cell1);
                            }
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
                            Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            p.Add(p1);
                            p.Add(p2);
                            pdfDoc.Add(p);
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Add(p2);
                            pdfDoc.Add(c4);
                            pdfDoc.Add(p2);
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
    }
}
