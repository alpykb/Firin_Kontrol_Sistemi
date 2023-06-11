namespace Tasarım_Orn
{
    partial class Kasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasa));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SatisListeleDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SatisBtn = new System.Windows.Forms.Button();
            this.GenelToplamLBL = new System.Windows.Forms.Label();
            this.AnamenuBtn = new System.Windows.Forms.Button();
            this.UrunBilgigroupBox1 = new System.Windows.Forms.GroupBox();
            this.iPtalBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.MiktarTBox = new System.Windows.Forms.TextBox();
            this.ToplamFTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FiyatTBox = new System.Windows.Forms.TextBox();
            this.UrunKoduTBox = new System.Windows.Forms.TextBox();
            this.UrunAdiTBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatisListeleDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.UrunBilgigroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(468, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 0;
            // 
            // SatisListeleDGV
            // 
            this.SatisListeleDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.SatisListeleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SatisListeleDGV.Location = new System.Drawing.Point(296, 124);
            this.SatisListeleDGV.Name = "SatisListeleDGV";
            this.SatisListeleDGV.RowHeadersWidth = 51;
            this.SatisListeleDGV.RowTemplate.Height = 24;
            this.SatisListeleDGV.Size = new System.Drawing.Size(598, 295);
            this.SatisListeleDGV.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SatisBtn);
            this.panel1.Controls.Add(this.GenelToplamLBL);
            this.panel1.Controls.Add(this.AnamenuBtn);
            this.panel1.Controls.Add(this.UrunBilgigroupBox1);
            this.panel1.Controls.Add(this.SatisListeleDGV);
            this.panel1.Location = new System.Drawing.Point(40, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 479);
            this.panel1.TabIndex = 2;
            // 
            // SatisBtn
            // 
            this.SatisBtn.Location = new System.Drawing.Point(592, 424);
            this.SatisBtn.Name = "SatisBtn";
            this.SatisBtn.Size = new System.Drawing.Size(88, 42);
            this.SatisBtn.TabIndex = 16;
            this.SatisBtn.Text = "Satış Yap";
            this.SatisBtn.UseVisualStyleBackColor = true;
            this.SatisBtn.Click += new System.EventHandler(this.SatisBtn_Click);
            // 
            // GenelToplamLBL
            // 
            this.GenelToplamLBL.AutoSize = true;
            this.GenelToplamLBL.Location = new System.Drawing.Point(411, 440);
            this.GenelToplamLBL.Name = "GenelToplamLBL";
            this.GenelToplamLBL.Size = new System.Drawing.Size(93, 16);
            this.GenelToplamLBL.TabIndex = 15;
            this.GenelToplamLBL.Text = "Genel Toplam";
            // 
            // AnamenuBtn
            // 
            this.AnamenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnamenuBtn.Location = new System.Drawing.Point(3, 3);
            this.AnamenuBtn.Name = "AnamenuBtn";
            this.AnamenuBtn.Size = new System.Drawing.Size(123, 39);
            this.AnamenuBtn.TabIndex = 14;
            this.AnamenuBtn.Text = "ANA MENÜ";
            this.AnamenuBtn.UseVisualStyleBackColor = true;
            this.AnamenuBtn.Click += new System.EventHandler(this.AnamenuBtn_Click);
            // 
            // UrunBilgigroupBox1
            // 
            this.UrunBilgigroupBox1.Controls.Add(this.iPtalBtn);
            this.UrunBilgigroupBox1.Controls.Add(this.SilBtn);
            this.UrunBilgigroupBox1.Controls.Add(this.MiktarTBox);
            this.UrunBilgigroupBox1.Controls.Add(this.ToplamFTBox);
            this.UrunBilgigroupBox1.Controls.Add(this.label1);
            this.UrunBilgigroupBox1.Controls.Add(this.label5);
            this.UrunBilgigroupBox1.Controls.Add(this.label2);
            this.UrunBilgigroupBox1.Controls.Add(this.EkleBtn);
            this.UrunBilgigroupBox1.Controls.Add(this.label3);
            this.UrunBilgigroupBox1.Controls.Add(this.label4);
            this.UrunBilgigroupBox1.Controls.Add(this.FiyatTBox);
            this.UrunBilgigroupBox1.Controls.Add(this.UrunKoduTBox);
            this.UrunBilgigroupBox1.Controls.Add(this.UrunAdiTBox);
            this.UrunBilgigroupBox1.Location = new System.Drawing.Point(10, 67);
            this.UrunBilgigroupBox1.Name = "UrunBilgigroupBox1";
            this.UrunBilgigroupBox1.Size = new System.Drawing.Size(280, 389);
            this.UrunBilgigroupBox1.TabIndex = 13;
            this.UrunBilgigroupBox1.TabStop = false;
            this.UrunBilgigroupBox1.Text = "Ürün Bilgileri";
            // 
            // iPtalBtn
            // 
            this.iPtalBtn.Location = new System.Drawing.Point(196, 333);
            this.iPtalBtn.Name = "iPtalBtn";
            this.iPtalBtn.Size = new System.Drawing.Size(78, 42);
            this.iPtalBtn.TabIndex = 14;
            this.iPtalBtn.Text = "İptal";
            this.iPtalBtn.UseVisualStyleBackColor = true;
            this.iPtalBtn.Click += new System.EventHandler(this.iPtalBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Location = new System.Drawing.Point(100, 333);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(90, 42);
            this.SilBtn.TabIndex = 13;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = true;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // MiktarTBox
            // 
            this.MiktarTBox.Location = new System.Drawing.Point(125, 205);
            this.MiktarTBox.Name = "MiktarTBox";
            this.MiktarTBox.Size = new System.Drawing.Size(100, 22);
            this.MiktarTBox.TabIndex = 9;
            this.MiktarTBox.Text = "1";
            this.MiktarTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MiktarTBox.TextChanged += new System.EventHandler(this.MiktarTBox_TextChanged);
            // 
            // ToplamFTBox
            // 
            this.ToplamFTBox.Location = new System.Drawing.Point(125, 269);
            this.ToplamFTBox.Name = "ToplamFTBox";
            this.ToplamFTBox.Size = new System.Drawing.Size(100, 22);
            this.ToplamFTBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Kodu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Toplam Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Adı";
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(6, 333);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(88, 42);
            this.EkleBtn.TabIndex = 10;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Miktar";
            // 
            // FiyatTBox
            // 
            this.FiyatTBox.Location = new System.Drawing.Point(125, 153);
            this.FiyatTBox.Name = "FiyatTBox";
            this.FiyatTBox.Size = new System.Drawing.Size(100, 22);
            this.FiyatTBox.TabIndex = 8;
            this.FiyatTBox.TextChanged += new System.EventHandler(this.FiyatTBox_TextChanged);
            // 
            // UrunKoduTBox
            // 
            this.UrunKoduTBox.Location = new System.Drawing.Point(125, 57);
            this.UrunKoduTBox.Name = "UrunKoduTBox";
            this.UrunKoduTBox.Size = new System.Drawing.Size(100, 22);
            this.UrunKoduTBox.TabIndex = 6;
            this.UrunKoduTBox.TextChanged += new System.EventHandler(this.UrunKoduTBox_TextChanged);
            // 
            // UrunAdiTBox
            // 
            this.UrunAdiTBox.Location = new System.Drawing.Point(125, 108);
            this.UrunAdiTBox.Name = "UrunAdiTBox";
            this.UrunAdiTBox.Size = new System.Drawing.Size(100, 22);
            this.UrunAdiTBox.TabIndex = 7;
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "Kasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kasa_FormClosing);
            this.Load += new System.EventHandler(this.Kasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatisListeleDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UrunBilgigroupBox1.ResumeLayout(false);
            this.UrunBilgigroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView SatisListeleDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ToplamFTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.TextBox MiktarTBox;
        private System.Windows.Forms.TextBox FiyatTBox;
        private System.Windows.Forms.TextBox UrunAdiTBox;
        private System.Windows.Forms.TextBox UrunKoduTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox UrunBilgigroupBox1;
        private System.Windows.Forms.Button AnamenuBtn;
        private System.Windows.Forms.Button iPtalBtn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Label GenelToplamLBL;
        private System.Windows.Forms.Button SatisBtn;
    }
}