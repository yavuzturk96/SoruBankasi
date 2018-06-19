namespace SoruBankası
{
    partial class Konu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.konuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soruBankasiDataSet = new SoruBankası.SoruBankasiDataSet();
            this.konuTableAdapter = new SoruBankası.SoruBankasiDataSetTableAdapters.KonuTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dersTableAdapter = new SoruBankası.SoruBankasiDataSetTableAdapters.DersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.konuIDDataGridViewTextBoxColumn,
            this.konuAdıDataGridViewTextBoxColumn,
            this.dersIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.konuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(465, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(341, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // konuIDDataGridViewTextBoxColumn
            // 
            this.konuIDDataGridViewTextBoxColumn.DataPropertyName = "KonuID";
            this.konuIDDataGridViewTextBoxColumn.HeaderText = "KonuID";
            this.konuIDDataGridViewTextBoxColumn.Name = "konuIDDataGridViewTextBoxColumn";
            // 
            // konuAdıDataGridViewTextBoxColumn
            // 
            this.konuAdıDataGridViewTextBoxColumn.DataPropertyName = "KonuAdı";
            this.konuAdıDataGridViewTextBoxColumn.HeaderText = "KonuAdı";
            this.konuAdıDataGridViewTextBoxColumn.Name = "konuAdıDataGridViewTextBoxColumn";
            // 
            // dersIDDataGridViewTextBoxColumn
            // 
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            // 
            // konuBindingSource
            // 
            this.konuBindingSource.DataMember = "Konu";
            this.konuBindingSource.DataSource = this.soruBankasiDataSet;
            // 
            // soruBankasiDataSet
            // 
            this.soruBankasiDataSet.DataSetName = "SoruBankasiDataSet";
            this.soruBankasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // konuTableAdapter
            // 
            this.konuTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konu ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu Adı";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dersBindingSource;
            this.comboBox1.DisplayMember = "DersID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "DersAdı";
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "Ders";
            this.dersBindingSource.DataSource = this.soruBankasiDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ders Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 6;
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(465, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 46);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(663, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 39);
            this.button4.TabIndex = 10;
            this.button4.Text = "Geri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bölüm Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dönem Adı";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(137, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(137, 63);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Konu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 374);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Konu";
            this.Text = "Konu";
            this.Load += new System.EventHandler(this.Konu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SoruBankasiDataSet soruBankasiDataSet;
        private System.Windows.Forms.BindingSource konuBindingSource;
        private SoruBankasiDataSetTableAdapters.KonuTableAdapter konuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private SoruBankasiDataSetTableAdapters.DersTableAdapter dersTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}