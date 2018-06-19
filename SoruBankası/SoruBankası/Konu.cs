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
    public partial class Konu : Form
    {
        public Konu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        //SqlCommand komut;
        SqlDataAdapter da;
        SqlCommand cmd;
        void KonuGetir()
        {

            baglanti = new SqlConnection(@"server=.\SQLEXPRESS;database=SoruBankasi;Trusted_Connection=yes");
            baglanti.Open(); da = new SqlDataAdapter("Select *From Konu", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Konu_Load(object sender, EventArgs e)
        {
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
            
            // TODO: This line of code loads data into the 'soruBankasiDataSet.Ders' table. You can move, or remove it, as needed.
            this.dersTableAdapter.Fill(this.soruBankasiDataSet.Ders);
            // TODO: This line of code loads data into the 'soruBankasiDataSet.Konu' table. You can move, or remove it, as needed.
            this.konuTableAdapter.Fill(this.soruBankasiDataSet.Konu);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KonuGetir();
            string sql = "insert into Konu(konuID,KonuAdı,DersID) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + comboBox1.SelectedValue.ToString() + "');";
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            cmd = new SqlCommand(sql, baglanti);
            int x = cmd.ExecuteNonQuery();
            baglanti.Close();
            //MessageBox.Show(x.ToString() + "belge kaydedildi.");
            KonuGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KonuGetir();
            cmd = new SqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "update Konu set KonuAdı='" + textBox2.Text + "',DersID='" + comboBox1.SelectedValue.ToString() + "' where KonuID=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            KonuGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From Konu Where KonuID=@KonuID";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@KonuID", Convert.ToInt32(textBox1.Text));
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            KonuGetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
                comboBox1.ValueMember = "DersID";
                comboBox1.DisplayMember = "DersAdı";
                comboBox1.DataSource = dt;
            }
        }

 

       

    }
}
