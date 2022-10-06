namespace Kutuphane
{
    partial class Kullanıcı
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fantastikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edebiyatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSet = new Kutuphane.KutuphaneDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbdurum = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kitaplarTableAdapter = new Kutuphane.KutuphaneDataSetTableAdapters.kitaplarTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.kitaplarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kkategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kresimDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.kozetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksayfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fantastikToolStripMenuItem,
            this.edebiyatToolStripMenuItem,
            this.tarihToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItem1.Text = "Kategoriler";
            // 
            // fantastikToolStripMenuItem
            // 
            this.fantastikToolStripMenuItem.Name = "fantastikToolStripMenuItem";
            this.fantastikToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.fantastikToolStripMenuItem.Text = "Fantastik";
            this.fantastikToolStripMenuItem.Click += new System.EventHandler(this.fantastikToolStripMenuItem_Click);
            // 
            // edebiyatToolStripMenuItem
            // 
            this.edebiyatToolStripMenuItem.Name = "edebiyatToolStripMenuItem";
            this.edebiyatToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.edebiyatToolStripMenuItem.Text = "Roman";
            this.edebiyatToolStripMenuItem.Click += new System.EventHandler(this.edebiyatToolStripMenuItem_Click);
            // 
            // tarihToolStripMenuItem
            // 
            this.tarihToolStripMenuItem.Name = "tarihToolStripMenuItem";
            this.tarihToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.tarihToolStripMenuItem.Text = "Tarih";
            this.tarihToolStripMenuItem.Click += new System.EventHandler(this.tarihToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kidDataGridViewTextBoxColumn,
            this.kadDataGridViewTextBoxColumn,
            this.kkategoriDataGridViewTextBoxColumn,
            this.kyazarDataGridViewTextBoxColumn,
            this.kdurumDataGridViewTextBoxColumn,
            this.kresimDataGridViewImageColumn,
            this.kozetDataGridViewTextBoxColumn,
            this.ksayfaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitaplarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 168);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "kitaplar";
            this.kitaplarBindingSource.DataSource = this.kutuphaneDataSet;
            // 
            // kutuphaneDataSet
            // 
            this.kutuphaneDataSet.DataSetName = "KutuphaneDataSet";
            this.kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(616, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 71);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kitap Al";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(712, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(712, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(110, 155);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(121, 21);
            this.cmbkategori.TabIndex = 110;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(459, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // cmbdurum
            // 
            this.cmbdurum.FormattingEnabled = true;
            this.cmbdurum.Items.AddRange(new object[] {
            "Var",
            "Yok"});
            this.cmbdurum.Location = new System.Drawing.Point(110, 215);
            this.cmbdurum.Name = "cmbdurum";
            this.cmbdurum.Size = new System.Drawing.Size(121, 21);
            this.cmbdurum.TabIndex = 107;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(297, 139);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(110, 135);
            this.richTextBox1.TabIndex = 106;
            this.richTextBox1.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 105;
            this.label7.Text = "sayfa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 104;
            this.label6.Text = "özet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 103;
            this.label5.Text = "durum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 102;
            this.label4.Text = "yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "kategori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 100;
            this.label8.Text = "Ad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 16);
            this.label9.TabIndex = 99;
            this.label9.Text = "id";
            // 
            // txtsayfa
            // 
            this.txtsayfa.Location = new System.Drawing.Point(110, 245);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(100, 20);
            this.txtsayfa.TabIndex = 98;
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(110, 185);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(100, 20);
            this.txtyazar.TabIndex = 97;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(110, 125);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 96;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(110, 95);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(289, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 111;
            this.label10.Text = "Kitap adı";
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(557, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 31);
            this.button3.TabIndex = 112;
            this.button3.Text = "Tümünü Listele";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kitaplarBindingSource1
            // 
            this.kitaplarBindingSource1.DataMember = "kitaplar";
            this.kitaplarBindingSource1.DataSource = this.kutuphaneDataSet;
            // 
            // kidDataGridViewTextBoxColumn
            // 
            this.kidDataGridViewTextBoxColumn.DataPropertyName = "k_id";
            this.kidDataGridViewTextBoxColumn.HeaderText = "k_id";
            this.kidDataGridViewTextBoxColumn.Name = "kidDataGridViewTextBoxColumn";
            this.kidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kadDataGridViewTextBoxColumn
            // 
            this.kadDataGridViewTextBoxColumn.DataPropertyName = "k_ad";
            this.kadDataGridViewTextBoxColumn.HeaderText = "k_ad";
            this.kadDataGridViewTextBoxColumn.Name = "kadDataGridViewTextBoxColumn";
            // 
            // kkategoriDataGridViewTextBoxColumn
            // 
            this.kkategoriDataGridViewTextBoxColumn.DataPropertyName = "k_kategori";
            this.kkategoriDataGridViewTextBoxColumn.HeaderText = "k_kategori";
            this.kkategoriDataGridViewTextBoxColumn.Name = "kkategoriDataGridViewTextBoxColumn";
            // 
            // kyazarDataGridViewTextBoxColumn
            // 
            this.kyazarDataGridViewTextBoxColumn.DataPropertyName = "k_yazar";
            this.kyazarDataGridViewTextBoxColumn.HeaderText = "k_yazar";
            this.kyazarDataGridViewTextBoxColumn.Name = "kyazarDataGridViewTextBoxColumn";
            // 
            // kdurumDataGridViewTextBoxColumn
            // 
            this.kdurumDataGridViewTextBoxColumn.DataPropertyName = "k_durum";
            this.kdurumDataGridViewTextBoxColumn.HeaderText = "k_durum";
            this.kdurumDataGridViewTextBoxColumn.Name = "kdurumDataGridViewTextBoxColumn";
            // 
            // kresimDataGridViewImageColumn
            // 
            this.kresimDataGridViewImageColumn.DataPropertyName = "k_resim";
            this.kresimDataGridViewImageColumn.HeaderText = "k_resim";
            this.kresimDataGridViewImageColumn.Name = "kresimDataGridViewImageColumn";
            // 
            // kozetDataGridViewTextBoxColumn
            // 
            this.kozetDataGridViewTextBoxColumn.DataPropertyName = "k_ozet";
            this.kozetDataGridViewTextBoxColumn.HeaderText = "k_ozet";
            this.kozetDataGridViewTextBoxColumn.Name = "kozetDataGridViewTextBoxColumn";
            // 
            // ksayfaDataGridViewTextBoxColumn
            // 
            this.ksayfaDataGridViewTextBoxColumn.DataPropertyName = "k_sayfa";
            this.ksayfaDataGridViewTextBoxColumn.HeaderText = "k_sayfa";
            this.ksayfaDataGridViewTextBoxColumn.Name = "ksayfaDataGridViewTextBoxColumn";
            // 
            // Kullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(843, 473);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbdurum);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsayfa);
            this.Controls.Add(this.txtyazar);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Kullanıcı";
            this.Text = "Kullanıcı";
            this.Load += new System.EventHandler(this.Kullanıcı_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fantastikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edebiyatToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbdurum;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem tarihToolStripMenuItem;
        private KutuphaneDataSet kutuphaneDataSet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private KutuphaneDataSetTableAdapters.kitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kkategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn kresimDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kozetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksayfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kitaplarBindingSource1;
    }
}