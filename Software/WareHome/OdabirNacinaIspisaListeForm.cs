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
using WareHome.Models.ListaZaKupovinu;
using WareHome_Logic;

namespace WareHome
{
    public partial class OdabirNacinaIspisaListeForm : Form
    {
        ListaZaKupovinu odabranaLista;
        List<NamirnicaNaListi> namirnice;
        Korisnik trenutniKorisnik;
        public OdabirNacinaIspisaListeForm(ListaZaKupovinu lista, List<NamirnicaNaListi> namirnice, Korisnik korisnik)
        {
            InitializeComponent();
            odabranaLista = lista;
            this.namirnice = namirnice;
            trenutniKorisnik = korisnik;
            uzlaznoCheckBox.Checked = true;
            premaCijeniCheckBox.Checked = true;
            AcceptButton = ispisiButton;
            CancelButton = povratakButton;
        }

        private void ispisiButton_Click(object sender, EventArgs e)
        {
            if (premaTrgoviniCheckBox.Checked && uzlaznoCheckBox.Checked)
            {
                IspisiPremaTrgoviniUzlazno();
            }
            else if (premaTrgoviniCheckBox.Checked && silaznoCheckBox.Checked)
            {
                IspisiPremaTrgoviniSilazno();
            }
            else if (premaCijeniCheckBox.Checked && uzlaznoCheckBox.Checked)
            {
                IspisiPremaCijeniUzlazno();
            }
            else if (premaCijeniCheckBox.Checked && silaznoCheckBox.Checked)
            {
                IspisiPremaCijeniSilazno();
            }
            else if (premaKoliciniCheckBox.Checked && uzlaznoCheckBox.Checked)
            {
                IspisiPremaKoliciniUzlazno();
            }
            else if (premaKoliciniCheckBox.Checked && silaznoCheckBox.Checked)
            {
                IspisiPremaKoliciniSilazno();
            }
            else
            {
                MessageBox.Show("Provjerite odabir!", "Greška!");
            }
        }

        private void IspisiPremaKoliciniSilazno()
        {
            namirniceDataGridView.DataSource = null;
            List<NamirnicaNaListi> lista = new List<NamirnicaNaListi>();
            if (odabranaLista.NazivListe == "[WH] Potrošene namirnice")
            {
                List<NamirnicaNaListi> neoptimalno = DohvatiPotroseneNamirnice();
                lista = neoptimalno;
                lista.Sort(delegate (NamirnicaNaListi x, NamirnicaNaListi y)
                {
                    float kol1 = float.Parse(y.KoličinaNamirnice);
                    float kol2 = float.Parse(x.KoličinaNamirnice);
                    return kol1.CompareTo(kol2);
                });
            }
            else
            {
                string sql = $"SELECT *" +
                    $"FROM Namirnica_na_listi WHERE Namirnica_na_listi.lista_id = {odabranaLista.IdListe} " +
                    $"ORDER BY Try_convert(float, kolicina_namirniceNaListi) DESC";
                Database.Instance.Connect();
                IDataReader dataReader = Database.Instance.GetDataReader(sql);
                while (dataReader.Read())
                {
                    if (dataReader != null)
                    {
                        int id = int.Parse(dataReader["namirnicaNaListi_id"].ToString());
                        string naziv = dataReader["naziv_namirniceNaListi"].ToString();
                        string kolicina = dataReader["kolicina_namirniceNaListi"].ToString();
                        string cijena = dataReader["cijena_namirniceNaListi"].ToString();
                        string trgovina = dataReader["trgovina_namirniceNaListi"].ToString();

                        NamirnicaNaListi namirnica = new NamirnicaNaListi(id, odabranaLista.IdListe, naziv, kolicina, cijena, trgovina);
                        lista.Add(namirnica);
                    }
                }
                dataReader.Close();
                Database.Instance.Disconnect();
            }
            namirniceDataGridView.DataSource = lista;
            SpremiUPDF();
            Close();
        }

        private List<NamirnicaNaListi> DohvatiPotroseneNamirnice()
        {
            List<Namirnica> namirnice = null;
            Database.Instance.Connect();
            namirnice = NamirnicaRepository.DohvatiNamirnice(trenutniKorisnik.Domacinstvo);
            Database.Instance.Disconnect();
            List<NamirnicaNaListi> neoptimalno = null;
            neoptimalno = new List<NamirnicaNaListi>();
            foreach (var item in namirnice)
            {
                if (item.DostupnaKolicina < item.OptimalnaKolicina)
                {
                    float kolicina = item.OptimalnaKolicina - item.DostupnaKolicina;
                    NamirnicaNaListi potrošena = new NamirnicaNaListi(0, odabranaLista.IdListe, item.NazivNamirnice, kolicina.ToString(), item.Cijena, item.Ducan);
                    neoptimalno.Add(potrošena);
                }
            }
            return neoptimalno;
        }

        private void SpremiUPDF()
        {
            string naziv = "WareHome lista za kupovinu";
            if (namirniceDataGridView.Rows.Count > 0)
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
                        PdfPTable pdfTable = new PdfPTable(namirniceDataGridView.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                        string[] headers = new string[]
                        {
                            "Id", "Lista", "Naziv", "Količina", "Cijena", "Trgovina"
                        };
                        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, false);
                        iTextSharp.text.Font titlefont = new iTextSharp.text.Font(bf, 13);
                        iTextSharp.text.Font infofont = new iTextSharp.text.Font(bf, 10);
                        pdfTable.SetWidths(GetHeaderWidths(titlefont, headers));

                        for (int i = 0; i < headers.Length; ++i)
                        {
                            pdfTable.AddCell(new PdfPCell(new Phrase(headers[i], titlefont)));
                        }
                        foreach (DataGridViewRow row in namirniceDataGridView.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell cell1 = new PdfPCell(new Phrase(cell.FormattedValue.ToString(), infofont));
                                pdfTable.AddCell(cell1);
                            }
                        }
                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Chunk c1 = new Chunk($"Lista : {odabranaLista.NazivListe} \n", FontFactory.GetFont("dax-black", 20, BaseColor.BLACK));
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

        private void IspisiPremaKoliciniUzlazno()
        {
            namirniceDataGridView.DataSource = null;
            List<NamirnicaNaListi> lista = new List<NamirnicaNaListi>();
            if (odabranaLista.NazivListe == "[WH] Potrošene namirnice")
            {
                List<NamirnicaNaListi> neoptimalno = DohvatiPotroseneNamirnice();
                lista = neoptimalno;
                lista.Sort(delegate (NamirnicaNaListi x, NamirnicaNaListi y)
                {
                    float kol1 = float.Parse(x.KoličinaNamirnice);
                    float kol2 = float.Parse(y.KoličinaNamirnice);
                    return kol1.CompareTo(kol2);
                });
            }
            else
            {
                string sql = $"SELECT *" +
                    $"FROM Namirnica_na_listi WHERE Namirnica_na_listi.lista_id = {odabranaLista.IdListe} " +
                    $"ORDER BY Try_convert(float, kolicina_namirniceNaListi) ASC";
                Database.Instance.Connect();
                IDataReader dataReader = Database.Instance.GetDataReader(sql);
                while (dataReader.Read())
                {
                    if (dataReader != null)
                    {
                        int id = int.Parse(dataReader["namirnicaNaListi_id"].ToString());
                        string naziv = dataReader["naziv_namirniceNaListi"].ToString();
                        string kolicina = dataReader["kolicina_namirniceNaListi"].ToString();
                        string cijena = dataReader["cijena_namirniceNaListi"].ToString();
                        string trgovina = dataReader["trgovina_namirniceNaListi"].ToString();

                        NamirnicaNaListi namirnica = new NamirnicaNaListi(id, odabranaLista.IdListe, naziv, kolicina, cijena, trgovina);
                        lista.Add(namirnica);
                    }
                }
                dataReader.Close();
                Database.Instance.Disconnect();
            }
            namirniceDataGridView.DataSource = lista;
            SpremiUPDF();
            Close();
        }

        private void IspisiPremaCijeniSilazno()
        {
            namirniceDataGridView.DataSource = null;
            List<NamirnicaNaListi> lista = new List<NamirnicaNaListi>();
            if (odabranaLista.NazivListe == "[WH] Potrošene namirnice")
            {
                List<NamirnicaNaListi> neoptimalno = DohvatiPotroseneNamirnice();
                lista = neoptimalno;
                lista.Sort(delegate (NamirnicaNaListi x, NamirnicaNaListi y)
                {
                    float cijena1 = float.Parse(y.CijenaNamirnice);
                    float cijena2 = float.Parse(x.CijenaNamirnice);
                    return cijena1.CompareTo(cijena2);
                });
            }
            else
            {
                string sql = $"SELECT *" +
                    $"FROM Namirnica_na_listi WHERE Namirnica_na_listi.lista_id = {odabranaLista.IdListe} " +
                    $"ORDER BY Try_convert(float, cijena_namirniceNaListi) DESC";
                Database.Instance.Connect();
                IDataReader dataReader = Database.Instance.GetDataReader(sql);
                while (dataReader.Read())
                {
                    if (dataReader != null)
                    {
                        int id = int.Parse(dataReader["namirnicaNaListi_id"].ToString());
                        string naziv = dataReader["naziv_namirniceNaListi"].ToString();
                        string kolicina = dataReader["kolicina_namirniceNaListi"].ToString();
                        string cijena = dataReader["cijena_namirniceNaListi"].ToString();
                        string trgovina = dataReader["trgovina_namirniceNaListi"].ToString();

                        NamirnicaNaListi namirnica = new NamirnicaNaListi(id, odabranaLista.IdListe, naziv, kolicina, cijena, trgovina);
                        lista.Add(namirnica);
                    }
                }
                dataReader.Close();
                Database.Instance.Disconnect();
            }
            namirniceDataGridView.DataSource = lista;
            SpremiUPDF();
            Close();
        }

        private void IspisiPremaCijeniUzlazno()
        {
            namirniceDataGridView.DataSource = null;
            List<NamirnicaNaListi> lista = new List<NamirnicaNaListi>();
            if (odabranaLista.NazivListe == "[WH] Potrošene namirnice")
            {
                List<NamirnicaNaListi> neoptimalno = DohvatiPotroseneNamirnice();
                lista = neoptimalno;
                lista.Sort(delegate (NamirnicaNaListi x, NamirnicaNaListi y)
                {
                    float cijena1 = float.Parse(x.CijenaNamirnice);
                    float cijena2 = float.Parse(y.CijenaNamirnice);
                    return cijena1.CompareTo(cijena2);
                });
            }
            else
            {
                string sql = $"SELECT *" +
                    $"FROM Namirnica_na_listi WHERE Namirnica_na_listi.lista_id = {odabranaLista.IdListe} " +
                    $"ORDER BY Try_convert(float, cijena_namirniceNaListi) ASC";
                Database.Instance.Connect();
                IDataReader dataReader = Database.Instance.GetDataReader(sql);
                while (dataReader.Read())
                {
                    if (dataReader != null)
                    {
                        int id = int.Parse(dataReader["namirnicaNaListi_id"].ToString());
                        string naziv = dataReader["naziv_namirniceNaListi"].ToString();
                        string kolicina = dataReader["kolicina_namirniceNaListi"].ToString();
                        string cijena = dataReader["cijena_namirniceNaListi"].ToString();
                        string trgovina = dataReader["trgovina_namirniceNaListi"].ToString();

                        NamirnicaNaListi namirnica = new NamirnicaNaListi(id, odabranaLista.IdListe, naziv, kolicina, cijena, trgovina);
                        lista.Add(namirnica);
                    }
                }
                dataReader.Close();
                Database.Instance.Disconnect();
            }
            namirniceDataGridView.DataSource = lista;
            SpremiUPDF();
            Close();
        }

        private void IspisiPremaTrgoviniSilazno()
        {
            namirniceDataGridView.DataSource = null;
            List<NamirnicaNaListi> lista = new List<NamirnicaNaListi>();
            if (odabranaLista.NazivListe == "[WH] Potrošene namirnice")
            {
                List<NamirnicaNaListi> neoptimalno = DohvatiPotroseneNamirnice();
                lista = neoptimalno;
                lista.Sort(delegate (NamirnicaNaListi x, NamirnicaNaListi y)
                {
                    return y.TrgovinaNamirnice.CompareTo(x.TrgovinaNamirnice);
                });
            }
            else
            {
                string sql = $"SELECT *" +
                    $"FROM Namirnica_na_listi WHERE Namirnica_na_listi.lista_id = {odabranaLista.IdListe} " +
                    $"ORDER BY trgovina_namirniceNaListi DESC";
                Database.Instance.Connect();
                IDataReader dataReader = Database.Instance.GetDataReader(sql);
                while (dataReader.Read())
                {
                    if (dataReader != null)
                    {
                        int id = int.Parse(dataReader["namirnicaNaListi_id"].ToString());
                        string naziv = dataReader["naziv_namirniceNaListi"].ToString();
                        string kolicina = dataReader["kolicina_namirniceNaListi"].ToString();
                        string cijena = dataReader["cijena_namirniceNaListi"].ToString();
                        string trgovina = dataReader["trgovina_namirniceNaListi"].ToString();

                        NamirnicaNaListi namirnica = new NamirnicaNaListi(id, odabranaLista.IdListe, naziv, kolicina, cijena, trgovina);
                        lista.Add(namirnica);
                    }
                }
                dataReader.Close();
                Database.Instance.Disconnect();
            }
            namirniceDataGridView.DataSource = lista;
            SpremiUPDF();
            Close();
        }

        private void IspisiPremaTrgoviniUzlazno()
        {
            namirniceDataGridView.DataSource = null;
            List<NamirnicaNaListi> lista = new List<NamirnicaNaListi>();
            if (odabranaLista.NazivListe == "[WH] Potrošene namirnice")
            {
                List<NamirnicaNaListi> neoptimalno = DohvatiPotroseneNamirnice();
                lista = neoptimalno;
                lista.Sort(delegate (NamirnicaNaListi x, NamirnicaNaListi y)
                {
                    return x.TrgovinaNamirnice.CompareTo(y.TrgovinaNamirnice);
                });
            }
            else
            {
                string sql = $"SELECT *" +
                    $"FROM Namirnica_na_listi WHERE Namirnica_na_listi.lista_id = {odabranaLista.IdListe} " +
                    $"ORDER BY trgovina_namirniceNaListi ASC";
                Database.Instance.Connect();
                IDataReader dataReader = Database.Instance.GetDataReader(sql);
                while (dataReader.Read())
                {
                    if (dataReader != null)
                    {
                        int id = int.Parse(dataReader["namirnicaNaListi_id"].ToString());
                        string naziv = dataReader["naziv_namirniceNaListi"].ToString();
                        string kolicina = dataReader["kolicina_namirniceNaListi"].ToString();
                        string cijena = dataReader["cijena_namirniceNaListi"].ToString();
                        string trgovina = dataReader["trgovina_namirniceNaListi"].ToString();

                        NamirnicaNaListi namirnica = new NamirnicaNaListi(id, odabranaLista.IdListe, naziv, kolicina, cijena, trgovina);
                        lista.Add(namirnica);
                    }
                }
                dataReader.Close();
                Database.Instance.Disconnect();
            }
            namirniceDataGridView.DataSource = lista;
            SpremiUPDF();
            Close();
        }

        private void uzlaznoCheckBox_Click(object sender, EventArgs e)
        {
            uzlaznoCheckBox.Checked = true;
            silaznoCheckBox.Checked = false;
        }

        private void silaznoCheckBox_Click(object sender, EventArgs e)
        {
            silaznoCheckBox.Checked = true;
            uzlaznoCheckBox.Checked = false;
        }

        private void premaTrgoviniCheckBox_Click(object sender, EventArgs e)
        {
            premaTrgoviniCheckBox.Checked = true;
            premaCijeniCheckBox.Checked = false;
            premaKoliciniCheckBox.Checked = false;
        }

        private void premaCijeniCheckBox_Click(object sender, EventArgs e)
        {
            premaCijeniCheckBox.Checked = true;
            premaTrgoviniCheckBox.Checked = false;
            premaKoliciniCheckBox.Checked = false;
        }

        private void premaKoliciniCheckBox_Click(object sender, EventArgs e)
        {
            premaKoliciniCheckBox.Checked = true;
            premaTrgoviniCheckBox.Checked = false;
            premaCijeniCheckBox.Checked = false;
        }

        private void OdabirNacinaIspisaListeForm_Load(object sender, EventArgs e)
        {
            namirniceDataGridView.DataSource = namirnice;
        }

        private void povratakButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
