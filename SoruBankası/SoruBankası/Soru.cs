using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruBankası
{
    public partial class Soru : Form
    {
        public Soru()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        //SqlCommand komut;
        SqlDataAdapter da;
        SqlCommand cmd;
        string dosyayolu = "";
        void SoruGetir()
        {
            baglanti = new SqlConnection(@"server=.\SQLEXPRESS;database=SoruBankasi;Trusted_Connection=yes");
            baglanti.Open(); da = new SqlDataAdapter("Select *From Soru", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Soru_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soruBankasiDataSet.Ders' table. You can move, or remove it, as needed.
            this.dersTableAdapter.Fill(this.soruBankasiDataSet.Ders);
            // TODO: This line of code loads data into the 'soruBankasiDataSet.Donem' table. You can move, or remove it, as needed.
            this.donemTableAdapter.Fill(this.soruBankasiDataSet.Donem);
            baglanti = new SqlConnection(@"server=.\SQLEXPRESS;database=SoruBankasi;Trusted_Connection=yes");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Bolum", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
            comboBox2.ValueMember = "BolumID";
            comboBox2.DisplayMember = "BolumAdi";
            comboBox2.DataSource = tablo;
            //dataGridView1.DataSource = tablo;
            baglanti.Close();



            // TODO: This line of code loads data into the 'soruBankasiDataSet.Konu' table. You can move, or remove it, as needed.
            this.konuTableAdapter.Fill(this.soruBankasiDataSet.Konu);
            // TODO: This line of code loads data into the 'soruBankasiDataSet.Soru' table. You can move, or remove it, as needed.
            this.soruTableAdapter.Fill(this.soruBankasiDataSet.Soru);
            // TODO: This line of code loads data into the 'soruBankasiDataSet.Bolum' table. You can move, or remove it, as needed.
            this.bolumTableAdapter.Fill(this.soruBankasiDataSet.Bolum);
            SoruGetir();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoruGetir();
            if (dosyayolu == "")
            {
                dosyayolu = null;
                string sql = "insert into Soru(soruID,konuID,soru,cevap,cevapA,cevapB,cevapC,cevapD,cevapE) values (" + textBox1.Text + ",'" + comboBox1.SelectedValue.ToString() + "','" + richTextBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "');";
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                cmd = new SqlCommand(sql, baglanti);
                int x = cmd.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                byte[] img = null;
                FileStream fs = new FileStream(dosyayolu, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "insert into Soru(soruID,konuID,soru,cevap,cevapA,cevapB,cevapC,cevapD,cevapE,soruResmi) values (" + textBox1.Text + ",'" + comboBox1.SelectedValue.ToString() + "','" + richTextBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "',@img);";
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();


                //string sql = "insert into Soru(soruID,konuID,soru,cevap,cevapA,cevapB,cevapC,cevapD,cevapE,soruResmi) values (" + textBox1.Text + ",'" + comboBox1.SelectedValue.ToString() + "','" + richTextBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "',@soruResmi)";
                //if (baglanti.State != ConnectionState.Open)
                //    baglanti.Open();
                //cmd = new SqlCommand(sql, baglanti);
                ////cmd.Parameters.AddWithValue("@soruResmi",textBox2.Text);
                //cmd.Parameters.Add(new SqlParameter("@soruResmi", dosyayolu));
                //cmd.ExecuteNonQuery();
                baglanti.Close();
            }
                
                //MessageBox.Show(x.ToString() + "belge kaydedildi.");
                //SoruGetir();
            //}
            //catch (Exception ex)
            //{
            //    baglanti.Close();
            //    MessageBox.Show(ex.Message);
                SoruGetir();
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            dosyayolu = dosya.FileName;
            textBox2.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
            if (dosyayolu == "")
            {
                dosyayolu = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From Soru Where soruID=@soruID";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@soruID", Convert.ToInt32(textBox1.Text));
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            SoruGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dosyayolu == "")
            {

                cmd = new SqlCommand();
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "update Soru set konuID='" + comboBox1.SelectedValue.ToString() + "',soruResmi=null,soru='" + richTextBox1.Text + "',cevap='" + textBox4.Text + "',cevapA='" + textBox5.Text + "',cevapB='" + textBox6.Text + "',cevapC='" + textBox7.Text + "',cevapD='" + textBox8.Text + "',cevapE='" + textBox9.Text + "' where SoruID=" + textBox1.Text + "";
                //cmd.Parameters.Add(new SqlParameter("@img", null));
                cmd.ExecuteNonQuery();
                baglanti.Close();
                SoruGetir();
            }
            else
            {
                byte[] img = null;
                FileStream fs = new FileStream(dosyayolu, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                cmd = new SqlCommand();
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "update Soru set konuID='" + comboBox1.SelectedValue.ToString() + "',soruResmi=@img,soru='" + richTextBox1.Text + "',cevap='" + textBox4.Text + "',cevapA='" + textBox5.Text + "',cevapB='" + textBox6.Text + "',cevapC='" + textBox7.Text + "',cevapD='" + textBox8.Text + "',cevapE='" + textBox9.Text + "' where SoruID=" + textBox1.Text + "";
                cmd.Parameters.Add(new SqlParameter("@img", img));
                cmd.ExecuteNonQuery();
                baglanti.Close();
                SoruGetir();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }


        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Donem where BolumID = " + comboBox2.SelectedValue, baglanti);
                da.Fill(dt);
                comboBox3.ValueMember = "DonemID";
                comboBox3.DisplayMember = "DonemAdı";
                comboBox3.DataSource = dt;
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Ders where DonemID = " + comboBox3.SelectedValue, baglanti);
                da.Fill(dt);
                comboBox4.ValueMember = "DersID";
                comboBox4.DisplayMember = "DersAdı";
                comboBox4.DataSource = dt;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Konu where DersID = " + comboBox4.SelectedValue, baglanti);
                da.Fill(dt);
                comboBox1.ValueMember = "KonuID";
                comboBox1.DisplayMember = "KonuAdı";
                comboBox1.DataSource = dt;
            }
        }

  


    }
}
