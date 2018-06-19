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
    public partial class Pdf : Form
    {
        public Pdf()
        {
            InitializeComponent();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {
            OpenFileDialog pdfgoster = new OpenFileDialog();
            pdfgoster.Title = "Pdf Göster";
            pdfgoster.Filter = "PDF Dosyaları (*.Pdf) | *.Pdf";
            axAcroPDF1.LoadFile("C:Çıktı.Pdf");
        }

        private void Pdf_Load(object sender, EventArgs e)
        {
            
        }
    }
}
