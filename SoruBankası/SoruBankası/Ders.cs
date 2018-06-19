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
    public partial class Ders : Form
    {
        public Ders()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        //SqlCommand komut;
        SqlDataAdapter da;
        SqlCommand cmd;
        void DersGetir()
        {

            baglanti = new SqlConnection(@"server=.\SQLEXPRESS;database=SoruBankasi;Trusted_Connection=yes");
            baglanti.Open(); da = new SqlDataAdapter("Select *From Ders", baglanti);
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

        private void Ders_Load(object sender, EventArgs e)
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

            // TODO: This line of code loads data into the 'soruBankasiDataSet.Donem' table. You can move, or remove it, as needed.
            this.donemTableAdapter.Fill(this.soruBankasiDataSet.Donem);
            // TODO: This line of code loads data into the 'soruBankasiDataSet.Ders' table. You can move, or remove it, as needed.
            this.dersTableAdapter.Fill(this.soruBankasiDataSet.Ders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DersGetir();
            string sql = "insert into Ders(DersID,DersAdı,DonemID) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + comboBox1.SelectedValue.ToString() + "');";
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            cmd = new SqlCommand(sql, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            //MessageBox.Show(x.ToString() + "belge kaydedildi.");
            DersGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DersGetir();
            cmd = new SqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "update Ders set DersAdı='" + textBox2.Text + "',DonemID='" + comboBox1.SelectedValue.ToString() + "' where DersID=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            DersGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From Ders Where DersID=@DersID";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@DersID", Convert.ToInt32(textBox1.Text));
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            DersGetir();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Donem where BolumID = " + comboBox2.SelectedValue, baglanti);
                da.Fill(dt);
                comboBox1.ValueMember = "DonemID";
                comboBox1.DisplayMember = "DonemAdı";
                comboBox1.DataSource = dt;
            }
        }


  




    }
}
