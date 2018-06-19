namespace SoruBankası
{
    partial class Ders
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
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soruBankasiDataSet = new SoruBankası.SoruBankasiDataSet();
            this.dersTableAdapter = new SoruBankası.SoruBankasiDataSetTableAdapters.DersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.donemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.donemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donemTableAdapter = new SoruBankası.SoruBankasiDataSetTableAdapters.DonemTableAdapter();
            this.dersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(461, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(576, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 38);
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
            this.dersIDDataGridViewTextBoxColumn,
            this.dersAdıDataGridViewTextBoxColumn,
            this.donemIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(400, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(346, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // dersIDDataGridViewTextBoxColumn
            // 
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            // 
            // dersAdıDataGridViewTextBoxColumn
            // 
            this.dersAdıDataGridViewTextBoxColumn.DataPropertyName = "DersAdı";
            this.dersAdıDataGridViewTextBoxColumn.HeaderText = "DersAdı";
            this.dersAdıDataGridViewTextBoxColumn.Name = "dersAdıDataGridViewTextBoxColumn";
            // 
            // donemIDDataGridViewTextBoxColumn
            // 
            this.donemIDDataGridViewTextBoxColumn.DataPropertyName = "DonemID";
            this.donemIDDataGridViewTextBoxColumn.HeaderText = "DonemID";
            this.donemIDDataGridViewTextBoxColumn.Name = "donemIDDataGridViewTextBoxColumn";
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "Ders";
            this.dersBindingSource.DataSource = this.soruBankasiDataSet;
            // 
            // soruBankasiDataSet
            // 
            this.soruBankasiDataSet.DataSetName = "SoruBankasiDataSet";
            this.soruBankasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ders ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ders Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dönem Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 22);
            this.textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.donemBindingSource1, "DonemAdı", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // donemBindingSource1
            // 
            this.donemBindingSource1.DataMember = "Donem";
            this.donemBindingSource1.DataSource = this.soruBankasiDataSet;
            // 
            // donemBindingSource
            // 
            this.donemBindingSource.DataMember = "Donem";
            this.donemBindingSource.DataSource = this.soruBankasiDataSet;
            // 
            // donemTableAdapter
            // 
            this.donemTableAdapter.ClearBeforeFill = true;
            // 
            // dersBindingSource1
            // 
            this.dersBindingSource1.DataMember = "Ders";
            this.dersBindingSource1.DataSource = this.soruBankasiDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(194, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bölüm Adı :";
            // 
            // Ders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Ders";
            this.Text = "Ders";
            this.Load += new System.EventHandler(this.Ders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource dersBindingSource;
        private SoruBankasiDataSetTableAdapters.DersTableAdapter dersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource donemBindingSource;
        private SoruBankasiDataSetTableAdapters.DonemTableAdapter donemTableAdapter;
        private System.Windows.Forms.BindingSource donemBindingSource1;
        private System.Windows.Forms.BindingSource dersBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
    }
}