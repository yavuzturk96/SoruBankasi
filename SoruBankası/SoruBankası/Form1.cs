using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruBankası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();// Form 2ye ulaşmak için yeni nesne oluşturuyoruz 
            frm2.Show();//Form 2'yi ekrana çıkartıyoruz.
            this.Hide();//Bulunduğumuz formu gizliyoruz.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cıktı frm2 = new Cıktı();
            frm2.Show();
            this.Hide();
        }

    }
}
