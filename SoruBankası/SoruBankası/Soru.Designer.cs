namespace SoruBankası
{
    partial class Soru
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
            this.soruIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soruResmiDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.soruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cevapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cevapADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cevapBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cevapCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cevapDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cevapEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soruBankasiDataSet = new SoruBankası.SoruBankasiDataSet();
            this.bolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumTableAdapter = new SoruBankası.SoruBankasiDataSetTableAdapters.BolumTableAdapter();
            this.soruTableAdapter = new SoruBankası.SoruBankasiDataSetTableAdapters.SoruTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.konuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.konuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.konuTableAdapter = new SoruBankası.SoruBankasiDataSetTableAdapters.KonuTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.donemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donemTableAdapter = new SoruBankası.SoruBankasiDataSetTableAdapters.DonemTableAdapter();
            this.dersTableAdapter = new SoruBankası.SoruBankasiDataSetTableAdapters.DersTableAdapter();
            this.fKSoruKonuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSoruKonuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soruIDDataGridViewTextBoxColumn,
            this.soruResmiDataGridViewImageColumn,
            this.soruDataGridViewTextBoxColumn,
            this.cevapDataGridViewTextBoxColumn,
            this.cevapADataGridViewTextBoxColumn,
            this.cevapBDataGridViewTextBoxColumn,
            this.cevapCDataGridViewTextBoxColumn,
            this.cevapDDataGridViewTextBoxColumn,
            this.cevapEDataGridViewTextBoxColumn,
            this.konuIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.soruBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // soruIDDataGridViewTextBoxColumn
            // 
            this.soruIDDataGridViewTextBoxColumn.DataPropertyName = "SoruID";
            this.soruIDDataGridViewTextBoxColumn.HeaderText = "SoruID";
            this.soruIDDataGridViewTextBoxColumn.Name = "soruIDDataGridViewTextBoxColumn";
            this.soruIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soruResmiDataGridViewImageColumn
            // 
            this.soruResmiDataGridViewImageColumn.DataPropertyName = "SoruResmi";
            this.soruResmiDataGridViewImageColumn.HeaderText = "SoruResmi";
            this.soruResmiDataGridViewImageColumn.Name = "soruResmiDataGridViewImageColumn";
            // 
            // soruDataGridViewTextBoxColumn
            // 
            this.soruDataGridViewTextBoxColumn.DataPropertyName = "Soru";
            this.soruDataGridViewTextBoxColumn.HeaderText = "Soru";
            this.soruDataGridViewTextBoxColumn.Name = "soruDataGridViewTextBoxColumn";
            // 
            // cevapDataGridViewTextBoxColumn
            // 
            this.cevapDataGridViewTextBoxColumn.DataPropertyName = "Cevap";
            this.cevapDataGridViewTextBoxColumn.HeaderText = "Cevap";
            this.cevapDataGridViewTextBoxColumn.Name = "cevapDataGridViewTextBoxColumn";
            // 
            // cevapADataGridViewTextBoxColumn
            // 
            this.cevapADataGridViewTextBoxColumn.DataPropertyName = "CevapA";
            this.cevapADataGridViewTextBoxColumn.HeaderText = "CevapA";
            this.cevapADataGridViewTextBoxColumn.Name = "cevapADataGridViewTextBoxColumn";
            // 
            // cevapBDataGridViewTextBoxColumn
            // 
            this.cevapBDataGridViewTextBoxColumn.DataPropertyName = "CevapB";
            this.cevapBDataGridViewTextBoxColumn.HeaderText = "CevapB";
            this.cevapBDataGridViewTextBoxColumn.Name = "cevapBDataGridViewTextBoxColumn";
            // 
            // cevapCDataGridViewTextBoxColumn
            // 
            this.cevapCDataGridViewTextBoxColumn.DataPropertyName = "CevapC";
            this.cevapCDataGridViewTextBoxColumn.HeaderText = "CevapC";
            this.cevapCDataGridViewTextBoxColumn.Name = "cevapCDataGridViewTextBoxColumn";
            // 
            // cevapDDataGridViewTextBoxColumn
            // 
            this.cevapDDataGridViewTextBoxColumn.DataPropertyName = "CevapD";
            this.cevapDDataGridViewTextBoxColumn.HeaderText = "CevapD";
            this.cevapDDataGridViewTextBoxColumn.Name = "cevapDDataGridViewTextBoxColumn";
            // 
            // cevapEDataGridViewTextBoxColumn
            // 
            this.cevapEDataGridViewTextBoxColumn.DataPropertyName = "CevapE";
            this.cevapEDataGridViewTextBoxColumn.HeaderText = "CevapE";
            this.cevapEDataGridViewTextBoxColumn.Name = "cevapEDataGridViewTextBoxColumn";
            // 
            // konuIDDataGridViewTextBoxColumn
            // 
            this.konuIDDataGridViewTextBoxColumn.DataPropertyName = "KonuID";
            this.konuIDDataGridViewTextBoxColumn.HeaderText = "KonuID";
            this.konuIDDataGridViewTextBoxColumn.Name = "konuIDDataGridViewTextBoxColumn";
            // 
            // soruBindingSource
            // 
            this.soruBindingSource.DataMember = "Soru";
            this.soruBindingSource.DataSource = this.soruBankasiDataSet;
            // 
            // soruBankasiDataSet
            // 
            this.soruBankasiDataSet.DataSetName = "SoruBankasiDataSet";
            this.soruBankasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumBindingSource
            // 
            this.bolumBindingSource.DataMember = "Bolum";
            this.bolumBindingSource.DataSource = this.soruBankasiDataSet;
            // 
            // bolumTableAdapter
            // 
            this.bolumTableAdapter.ClearBeforeFill = true;
            // 
            // soruTableAdapter
            // 
            this.soruTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soru ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soru Resmi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 417);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cevap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 647);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cevap A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 681);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cevap B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 712);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cevap C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 742);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cevap D";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 772);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cevap E";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Konu";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.konuBindingSource1, "KonuAdı", true));
            this.comboBox1.DataSource = this.konuBindingSource;
            this.comboBox1.DisplayMember = "KonuID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 321);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "KonuID";
            // 
            // konuBindingSource1
            // 
            this.konuBindingSource1.DataMember = "Konu";
            this.konuBindingSource1.DataSource = this.soruBankasiDataSet;
            // 
            // konuBindingSource
            // 
            this.konuBindingSource.DataMember = "Konu";
            this.konuBindingSource.DataSource = this.soruBankasiDataSet;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(195, 615);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(751, 22);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(195, 647);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(751, 22);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(195, 681);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(751, 22);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(195, 714);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(751, 22);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(195, 742);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(751, 22);
            this.textBox8.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(195, 772);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(751, 22);
            this.textBox9.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(997, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 60);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(997, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 62);
            this.button2.TabIndex = 22;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(997, 577);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 55);
            this.button3.TabIndex = 23;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(340, 416);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Seç";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(497, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 201);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // konuTableAdapter
            // 
            this.konuTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1016, 645);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 47);
            this.button5.TabIndex = 26;
            this.button5.Text = "Geri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Bölüm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Dönem";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Ders";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(195, 201);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(220, 24);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.donemBindingSource;
            this.comboBox3.DisplayMember = "DonemAdı";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(195, 241);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(220, 24);
            this.comboBox3.TabIndex = 31;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // donemBindingSource
            // 
            this.donemBindingSource.DataMember = "Donem";
            this.donemBindingSource.DataSource = this.soruBankasiDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.dersBindingSource;
            this.comboBox4.DisplayMember = "DersAdı";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(195, 277);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(220, 24);
            this.comboBox4.TabIndex = 32;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "Ders";
            this.dersBindingSource.DataSource = this.soruBankasiDataSet;
            // 
            // donemTableAdapter
            // 
            this.donemTableAdapter.ClearBeforeFill = true;
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // fKSoruKonuBindingSource
            // 
            this.fKSoruKonuBindingSource.DataMember = "FK_Soru_Konu";
            this.fKSoruKonuBindingSource.DataSource = this.konuBindingSource;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(195, 452);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(751, 147);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // Soru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 831);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Soru";
            this.Text = "Soru";
            this.Load += new System.EventHandler(this.Soru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSoruKonuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SoruBankasiDataSet soruBankasiDataSet;
        private System.Windows.Forms.BindingSource bolumBindingSource;
        private SoruBankasiDataSetTableAdapters.BolumTableAdapter bolumTableAdapter;
        private System.Windows.Forms.BindingSource soruBindingSource;
        private SoruBankasiDataSetTableAdapters.SoruTableAdapter soruTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn soruResmiDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cevapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cevapADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cevapBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cevapCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cevapDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cevapEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource konuBindingSource;
        private SoruBankasiDataSetTableAdapters.KonuTableAdapter konuTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource donemBindingSource;
        private SoruBankasiDataSetTableAdapters.DonemTableAdapter donemTableAdapter;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private SoruBankasiDataSetTableAdapters.DersTableAdapter dersTableAdapter;
        private System.Windows.Forms.BindingSource konuBindingSource1;
        private System.Windows.Forms.BindingSource fKSoruKonuBindingSource;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}