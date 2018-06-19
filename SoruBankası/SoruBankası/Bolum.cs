using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruBankası
{
    public partial class Bolum : Form
    {
        public Bolum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        //SqlCommand komut;
        SqlDataAdapter da;
        SqlCommand cmd;
        void BolumGetir()
        {

            baglanti = new SqlConnection(@"server=.\SQLEXPRESS;database=SoruBankasi;Trusted_Connection=yes");
            baglanti.Open(); da = new SqlDataAdapter("Select *From Bolum", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void Bolum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soruBankasiDataSet.Bolum' table. You can move, or remove it, as needed.
            this.bolumTableAdapter.Fill(this.soruBankasiDataSet.Bolum);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BolumGetir();
            string sql = "insert into Bolum(BolumID,BolumAdi) values (" + textBox1.Text + ",'" + textBox2.Text + "');";
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            cmd = new SqlCommand(sql, baglanti);
            int x = cmd.ExecuteNonQuery();
            baglanti.Close();
            //MessageBox.Show(x.ToString() + "belge kaydedildi.");
            BolumGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BolumGetir();
            cmd = new SqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "update Bolum set BolumAdi='" + textBox2.Text + "' where BolumID=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            BolumGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From Bolum Where BolumID=@Bolum";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@Bolum", Convert.ToInt32(textBox1.Text));
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            BolumGetir();
        }

    }
}
