namespace SoruBankası
{
    partial class ListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.SoruID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoruResmi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cevap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CevapA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SoruID,
            this.Soru,
            this.SoruResmi,
            this.Cevap,
            this.CevapA});
            this.listView1.Location = new System.Drawing.Point(177, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(724, 485);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // SoruID
            // 
            this.SoruID.Text = "SoruID";
            // 
            // Soru
            // 
            this.Soru.Text = "Soru";
            // 
            // SoruResmi
            // 
            this.SoruResmi.Text = "SoruResmi";
            this.SoruResmi.Width = 94;
            // 
            // Cevap
            // 
            this.Cevap.Text = "Cevap";
            // 
            // CevapA
            // 
            this.CevapA.Text = "CevapA";
            this.CevapA.Width = 103;
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 581);
            this.Controls.Add(this.listView1);
            this.Name = "ListView";
            this.Text = "ListView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader SoruID;
        private System.Windows.Forms.ColumnHeader Soru;
        private System.Windows.Forms.ColumnHeader SoruResmi;
        private System.Windows.Forms.ColumnHeader Cevap;
        private System.Windows.Forms.ColumnHeader CevapA;
    }
}