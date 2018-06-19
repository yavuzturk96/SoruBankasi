using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;
using System.Collections;
using iTextSharp.xtra;

namespace SoruBankası
{
    public partial class Cıktı : Form
    {
        public Cıktı()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        //SqlCommand komut;
        SqlDataReader dr;
        int a;


        //private void resimYükleme()
        //{
        //    baglanti = new SqlConnection(@"server=.\SQLEXPRESS;database=SoruBankasi;Trusted_Connection=yes");
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT soruResmi FROM Soru WHERE SoruID = 1", baglanti));
        //    DataSet dataSet = new DataSet();
        //    dataAdapter.Fill(dataSet);

        //    if (dataSet.Tables[0].Rows.Count == 1)
        //    {
        //        Byte[] data = new Byte[0];
        //        data = (Byte[])(dataSet.Tables[0].Rows[0]["soruResmi"]);
        //        MemoryStream mem = new MemoryStream(data);
        //        pictureBox1.Image = System.Drawing.Image.FromStream(mem);
                
        //    } 
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //resimYükleme();
            VeriCekme();

            Pdf frm2 = new Pdf();
            frm2.Show();
            //this.Hide();
            //stream.Close();

            //exportgridtopdf(dataGridView1, "Çıktı");
            //iTextSharp.text.Document cıktı = new iTextSharp.text.Document();
            //PdfWriter.GetInstance(cıktı, new FileStream("C:Çıktı.Pdf", FileMode.Create));
            //if (cıktı.IsOpen() == false) 
            //{
            //    cıktı.Open();
            //}
            //cıktı.Add(new Paragraph(textBox1.Text));
            //MessageBox.Show("Belge kaydedildi.");
            //cıktı.Close();
        }
        public void VeriCekme()
        {
            int kayitSayisi = -1;
            baglanti = new SqlConnection(@"server=.\SQLEXPRESS;database=SoruBankasi;Trusted_Connection=yes");
            a = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();
            SqlCommand cmd = new SqlCommand("select count(*) from Soru", baglanti);
            baglanti.Open();
            kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());
            baglanti.Close();
            int[] sayilar = new int[a];
            for (int i = 0; i < a; i++)
            {

                int x = rnd.Next(1, kayitSayisi + 1);
                if (!sayilar.Contains(x))
                {
                    sayilar[i] = x;
                }
                else
                {
                    while (true)
                    {
                        int yenix = rnd.Next(1, kayitSayisi + 1);
                        if (!sayilar.Contains(yenix))
                        {
                            sayilar[i] = yenix;
                            break;
                        }
                    }
                }

            }
            baglanti = new SqlConnection(@"server=.\SQLEXPRESS;database=SoruBankasi;Trusted_Connection=yes");
            baglanti.Open();
            cmd = new SqlCommand("Select *From Soru", baglanti);
            dr = cmd.ExecuteReader();
            baglanti.Close();
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Document list = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 10f, 0f);
            iTextSharp.text.Paragraph prag = new iTextSharp.text.Paragraph();
            iTextSharp.text.Document list1 = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 10f, 0f);
            iTextSharp.text.Chunk c = new iTextSharp.text.Chunk();

            PdfWriter.GetInstance(list, new FileStream("C:Çıktı.Pdf", FileMode.Create));
            PdfWriter.GetInstance(list1, new FileStream("C:CevapAnahtarı.Pdf", FileMode.Create));
            //Ekleyeceğimiz resmi Image nesnemize atıyoruz.
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("Koala.jpg");
            iTextSharp.text.Image img1 = iTextSharp.text.Image.GetInstance("Header.png");
            img1.SpacingBefore = 10f;
            img1.SpacingAfter = 1f;
            img1.ScaleToFit(300, 100);
            img1.Alignment = Element.ALIGN_CENTER;
            img.Alignment = Element.ALIGN_CENTER;
            prag.IndentationLeft = 15;
            //Boyutlandırma için ScaleToFit() methodunu ya da ScalePercent() methodunu kullanabiliriz.
            img.ScaleToFit(200, 100);
            prag.Add(c);


            PdfPTable pdfTableBlank = new PdfPTable(1);

            //Footer Section 
            PdfPTable pdfTableFooter = new PdfPTable(1);
            pdfTableFooter.DefaultCell.BorderWidth = 0;
            pdfTableFooter.WidthPercentage = 100;
            pdfTableFooter.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //Chunk cnkFooter = new Chunk("DEMO ENTERPRISE", FontFactory.GetFont("Times New Roman"));
            ////cnkFooter.Font.SetStyle(1); 
            //cnkFooter.Font.Size = 10;
            //pdfTableFooter.AddCell(new Phrase(cnkFooter));
            //End Of Footer Section 

            //pdfTableBlank.AddCell(new Phrase(" "));
            pdfTableBlank.DefaultCell.Border = 0;



            PdfPTable pdfTable1 = new PdfPTable(1);//Here 1 is Used For Count of Column 
            PdfPTable pdfTable2 = new PdfPTable(1);
            PdfPTable pdfTable3 = new PdfPTable(2);

            //Font Style 
            System.Drawing.Font fontH1 = new System.Drawing.Font("Currier", 16);

            //pdfTable1.DefaultCell.Padding = 5; 
            pdfTable1.WidthPercentage = 50;
            pdfTable1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable1.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
            //pdfTable1.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(64, 134, 170); 
            pdfTable1.DefaultCell.BorderWidth = 0;


            //pdfTable1.DefaultCell.Padding = 5; 
            pdfTable2.WidthPercentage = 80;
            pdfTable2.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable2.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
            //pdfTab2e1.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(64, 134, 170); 
            pdfTable2.DefaultCell.BorderWidth = 0;

            pdfTable3.DefaultCell.Padding = 1;
            pdfTable3.WidthPercentage = 50;
            pdfTable3.DefaultCell.BorderWidth = 0.0f;
            


            Chunk c1 = new Chunk("Sakarya Üniversitesi", FontFactory.GetFont("Times New Roman"));
            c1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
            c1.Font.SetStyle(0);
            c1.Font.Size = 14;
            Phrase p1 = new Phrase();
            p1.Add(c1);
            pdfTable1.AddCell(p1);
            Chunk c2 = new Chunk("Bilgisayar ve Bilişim Bilimleri Fakültesi", FontFactory.GetFont("Times New Roman"));
            c2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
            c2.Font.SetStyle(0);//0 For Normal Font 
            c2.Font.Size = 11;
            Phrase p2 = new Phrase();
            p2.Add(c2);
            pdfTable2.AddCell(p2);
            Chunk c3 = new Chunk(comboBox3.Text+" Dersi", FontFactory.GetFont("Times New Roman"));
            c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
            c3.Font.SetStyle(0);
            c3.Font.Size = 11;
            Phrase p3 = new Phrase();
            p3.Add(c3);
            pdfTable2.AddCell(p3);
            //pdfTable3.AddCell(new Phrase("Adı Soyadı: "));
            //pdfTable3.AddCell(new Phrase(""));
            //pdfTable3.AddCell(new Phrase("Numara: "));
            //pdfTable3.AddCell(new Phrase(""));

            //pdfTable3.AddCell(new Phrase("Grup :"));
            //pdfTable3.AddCell(new Phrase(""));
            //pdfTable3.AddCell(new Phrase(" Imza :"));
            //pdfTable3.AddCell(new Phrase("")); 

            list.Open();
            prag.Add(pdfTable1);
            prag.Add(pdfTable2);
            prag.Add(pdfTableBlank);
            prag.Add(pdfTable3);
            prag.Add(new Phrase("Adı Soyadı: \n"));
            prag.Add(new Phrase(""));
            prag.Add(new Phrase("Numara: \n"));
            prag.Add(new Phrase(""));

            prag.Add(new Phrase("Grup :\n"));
            prag.Add(new Phrase(""));
            prag.Add(new Phrase("Imza :\n"));
            prag.Add(new Phrase(""));
            prag.Add(pdfTableFooter);



     








            //Çerçeve vermek için aşağıdaki özelliklerini kullanabiliriz.
            //img.Border = iTextSharp.text.Rectangle.BOX;
            //img.BorderColor = iTextSharp.text.BaseColor.BLACK;
            //img.BorderWidth = 5f;
            //Sonrasında diğer nesnelerdeki gibi Document içine yada Paragraph içerisine ekleyebiliriz.

            //
            for (int i = 0; i < a; i++)
            {
                baglanti.Open();
                list.Open();
                list1.Open();
                list.Add(img1);

                cmd = new SqlCommand("SELECT Soru FROM Soru WHERE SoruID='" + sayilar[i] + "'");
                cmd.Connection = baglanti;
                string soru = cmd.ExecuteScalar().ToString();
                baglanti.Close();
                baglanti.Open();
                cmd = new SqlCommand("SELECT cevap FROM Soru WHERE SoruID='" + sayilar[i] + "'");
                cmd.Connection = baglanti;
                string cevap = cmd.ExecuteScalar().ToString();
                baglanti.Close();
                baglanti.Open();
                cmd = new SqlCommand("SELECT cevapA FROM Soru WHERE SoruID='" + sayilar[i] + "'");
                cmd.Connection = baglanti;
                string cevapA = cmd.ExecuteScalar().ToString();
                baglanti.Close(); baglanti.Open();
                cmd = new SqlCommand("SELECT cevapB FROM Soru WHERE SoruID='" + sayilar[i] + "'");
                cmd.Connection = baglanti;
                string cevapB = cmd.ExecuteScalar().ToString();
                baglanti.Close(); baglanti.Open();
                cmd = new SqlCommand("SELECT cevapC FROM Soru WHERE SoruID='" + sayilar[i] + "'");
                cmd.Connection = baglanti;
                string cevapC = cmd.ExecuteScalar().ToString();
                baglanti.Close();
                baglanti.Open();
                cmd = new SqlCommand("SELECT cevapD FROM Soru WHERE SoruID='" + sayilar[i] + "'");
                cmd.Connection = baglanti;
                string cevapD = cmd.ExecuteScalar().ToString();
                baglanti.Close(); baglanti.Open();
                cmd = new SqlCommand("SELECT cevapE FROM Soru WHERE SoruID='" + sayilar[i] + "'");
                cmd.Connection = baglanti;
                string cevapE = cmd.ExecuteScalar().ToString();
                baglanti.Close();
                  baglanti.Open();
               //cmd =new SqlCommand("select soruResmi from Soru where soruID='"+sayilar[i]+"'",baglanti);
               //string resimb = cmd.ExecuteScalar().ToString();             
               //byte[] resima = Convert.ToString(resimb);

               baglanti = new SqlConnection(@"server=.\SQLEXPRESS;database=SoruBankasi;Trusted_Connection=yes");
               SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT soruResmi FROM Soru WHERE SoruID ='" +sayilar[i]+"'", baglanti));
                   DataSet dataSet = new DataSet();
                   dataAdapter.Fill(dataSet);
                   if (dataSet.Tables[0].Rows.Count == 1)
                   {
                           //Byte[] data = new Byte[0];
                           byte[] Resim = (dataSet.Tables[0].Rows[0]["soruResmi"]) as byte[] ?? null;
                           if (Resim != null)
                           {
                               //data = (Byte[])(dataSet.Tables[0].Rows[0]["soruResmi"]);
                               MemoryStream mem = new MemoryStream(Resim);
                               pictureBox1.Image = System.Drawing.Image.FromStream(mem);
                               pictureBox1.Image.Save(@"C:'" + i + "'.jpeg", ImageFormat.Jpeg);
                               iTextSharp.text.Image soruresmi = iTextSharp.text.Image.GetInstance("'" + i + "'.jpeg");
                               soruresmi.ScaleToFit(300, 150);
                               soruresmi.Alignment = Element.ALIGN_CENTER;
                               prag.Add(soruresmi);
                           }
                           pictureBox1.Hide();
                   }
                  
               baglanti.Close();

                //list.Add(new Paragraph("Sakarya Üniversitesi"));
                //prag.Add(img);
                prag.Add(new Paragraph(i + 1 + ".Soru: " + soru));
                list1.Add(new Paragraph(i + 1 + ".Soru: " + soru));
                list1.Add(new Paragraph("Cevap:" + cevap));
                list1.Add(new Paragraph("\n"));
                if (cevapA != "")
                {
                    prag.Add(new Paragraph("A) " + cevapA));
                } if (cevapB != "")
                {
                    prag.Add(new Paragraph("B) " + cevapB));
                } if (cevapC != "")
                {
                    prag.Add(new Paragraph("C) " + cevapC));
                } if (cevapD != "")
                {
                    prag.Add(new Paragraph("D) " + cevapD));
                }
                if (cevapE != "")
                {
                    prag.Add(new Paragraph("E) " + cevapE));
                }
                prag.Add(new Paragraph("\n"));
                //if ((i+1)%5== 0)
                //{
                //    list.NewPage();
                //}


            }
            list.Add(prag);
            list.Close();
            list1.Close();
            baglanti.Close();



            //cmd.Parameters.AddWithValue("@soruID", Convert.ToInt32(textBox1.Text));



            //con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=sirket.accdb");
            //con.Open();
            //cmd = new OleDbCommand("Select * From personel", con);
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    ListViewItem item = new ListViewItem(dr["PId"].ToString());
            //    item.SubItems.Add(dr["PAd"].ToString());
            //    item.SubItems.Add(dr["PSoyad"].ToString());  //www.ahmetcansever.com
            //    item.SubItems.Add(dr["PTelefon"].ToString());
            //    listView1.Items.Add(item);
            //}
            //con.Close();

        }

        //private void exportgridtopdf(DataGridView dgw, string filename)
        //{
        //    BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
        //    PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
        //    pdftable.DefaultCell.Padding = 3;
        //    pdftable.WidthPercentage = 100;
        //    pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
        //    pdftable.DefaultCell.BorderWidth = 1;

        //    iTextSharp.text.Font text =new iTextSharp.text.Font(bf,10,iTextSharp.text.Font.NORMAL);
        //    //Add Header
        //    foreach(DataGridViewColumn column in dgw.Columns)
        //    {
        //        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
        //        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
        //        pdftable.AddCell(cell);
        //    }

        //    //Add datarow
        //    foreach (DataGridViewRow row in dgw.Rows)
        //    {
        //        foreach(DataGridViewCell cell in row.Cells)
        //        {
        //            pdftable.AddCell(new Phrase(cell.Value.ToString(),text));
        //        }
        //    }
        //    //var savefiledialoge = new SaveFileDialog();
        //    //savefiledialoge.FileName=filename;
        //    //savefiledialoge.DefaultExt=".pdf";
        //    //if(savefiledialoge.ShowDialog()==DialogResult.OK)
        //    {
        //        //using (FileStream stream = new FileStream("C:Çıktı.Pdf", FileMode.Create))
        //        {
        //            Document pdfdoc=new Document(PageSize.A4,10f,10f,10f,0f);
        //            PdfWriter.GetInstance(pdfdoc, new FileStream("C:Çıktı.Pdf", FileMode.Create));
        //            pdfdoc.Open();
        //            pdfdoc.Add(new Paragraph("Sakarya Üniversitesi"));
        //            pdfdoc.Add(pdftable);
        //            pdfdoc.Close();
        //            //stream.Close();
        //        }
        //    }
        //}
        private void Cıktı_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"server=.\SQLEXPRESS;database=SoruBankasi;Trusted_Connection=yes");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Bolum", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            comboBox1.ValueMember = "BolumID";
            comboBox1.DisplayMember = "BolumAdi";
            comboBox1.DataSource = tablo;
            //dataGridView1.DataSource = tablo;
            baglanti.Close();
            // TODO: This line of code loads data into the 'soruBankasiDataSet.Soru' table. You can move, or remove it, as needed.
            this.soruTableAdapter.Fill(this.soruBankasiDataSet.Soru);

        }

        public IElement item { get; set; }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CevapAnahtari frm2 = new CevapAnahtari();
            frm2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Donem where BolumID = " + comboBox1.SelectedValue, baglanti);
                da.Fill(dt);
                comboBox2.ValueMember = "DonemID";
                comboBox2.DisplayMember = "DonemAdı";
                comboBox2.DataSource = dt;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Ders where DonemID = " + comboBox2.SelectedValue, baglanti);
                da.Fill(dt);
                comboBox3.ValueMember = "DersID";
                comboBox3.DisplayMember = "DersAdı";
                comboBox3.DataSource = dt;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string sql = "Select * from Konu where DersID;";
            SqlDataAdapter da = new SqlDataAdapter("Select * from Konu where DersID = " + comboBox3.SelectedValue, baglanti);
            DataTable dt = new DataTable();
            //SqlDataAdapter adp = new SqlDataAdapter(sql, baglanti);
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            checkedListBox1.DataSource = dt;
            checkedListBox1.DisplayMember = "KonuAdı";
            checkedListBox1.ValueMember = "KonuID";


        }

    }
}
