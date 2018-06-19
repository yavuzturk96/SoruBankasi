namespace SoruBankası
{
    partial class Bolum
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soruBankasiDataSet = new SoruBankası.SoruBankasiDataSet();
            this.bolumTableAdapter = new SoruBankası.SoruBankasiDataSetTableAdapters.BolumTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(471, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(582, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Geri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIDDataGridViewTextBoxColumn,
            this.bolumAdiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(446, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(246, 182);
            this.dataGridView1.TabIndex = 4;
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            // 
            // bolumAdiDataGridViewTextBoxColumn
            // 
            this.bolumAdiDataGridViewTextBoxColumn.DataPropertyName = "BolumAdi";
            this.bolumAdiDataGridViewTextBoxColumn.HeaderText = "BolumAdi";
            this.bolumAdiDataGridViewTextBoxColumn.Name = "bolumAdiDataGridViewTextBoxColumn";
            // 
            // bolumBindingSource
            // 
            this.bolumBindingSource.DataMember = "Bolum";
            this.bolumBindingSource.DataSource = this.soruBankasiDataSet;
            // 
            // soruBankasiDataSet
            // 
            this.soruBankasiDataSet.DataSetName = "SoruBankasiDataSet";
            this.soruBankasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumTableAdapter
            // 
            this.bolumTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bölüm ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bölüm Adı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // Bolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 448);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Bolum";
            this.Text = "Bölüm";
            this.Load += new System.EventHandler(this.Bolum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SoruBankasiDataSet soruBankasiDataSet;
        private System.Windows.Forms.BindingSource bolumBindingSource;
        private SoruBankasiDataSetTableAdapters.BolumTableAdapter bolumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}