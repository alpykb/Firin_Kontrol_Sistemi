namespace Tasarım_Orn
{
    partial class Stok_Takibi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok_Takibi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MiktarTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AnamenuBtn = new System.Windows.Forms.Button();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.KategoriTBox = new System.Windows.Forms.TextBox();
            this.UrunFiyatTBox = new System.Windows.Forms.TextBox();
            this.UrunAdiTBox = new System.Windows.Forms.TextBox();
            this.UrunKoduTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UrunListeleDGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.UrunAraTbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrunListeleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.UrunAraTbox);
            this.panel1.Controls.Add(this.MiktarTBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AnamenuBtn);
            this.panel1.Controls.Add(this.GuncelleBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.KaydetBtn);
            this.panel1.Controls.Add(this.KategoriTBox);
            this.panel1.Controls.Add(this.UrunFiyatTBox);
            this.panel1.Controls.Add(this.UrunAdiTBox);
            this.panel1.Controls.Add(this.UrunKoduTBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.UrunListeleDGV);
            this.panel1.Location = new System.Drawing.Point(88, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 432);
            this.panel1.TabIndex = 0;
            // 
            // MiktarTBox
            // 
            this.MiktarTBox.Location = new System.Drawing.Point(96, 232);
            this.MiktarTBox.Name = "MiktarTBox";
            this.MiktarTBox.Size = new System.Drawing.Size(113, 22);
            this.MiktarTBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Miktar:";
            // 
            // AnamenuBtn
            // 
            this.AnamenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnamenuBtn.Location = new System.Drawing.Point(3, 3);
            this.AnamenuBtn.Name = "AnamenuBtn";
            this.AnamenuBtn.Size = new System.Drawing.Size(123, 39);
            this.AnamenuBtn.TabIndex = 12;
            this.AnamenuBtn.Text = "ANA MENÜ";
            this.AnamenuBtn.UseVisualStyleBackColor = true;
            this.AnamenuBtn.Click += new System.EventHandler(this.AnamenuBtn_Click);
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuncelleBtn.Location = new System.Drawing.Point(63, 332);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(98, 36);
            this.GuncelleBtn.TabIndex = 11;
            this.GuncelleBtn.Text = "GÜNCLLE";
            this.GuncelleBtn.UseVisualStyleBackColor = true;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(223, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Kaydı Oluşturma Ekranı";
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaydetBtn.Location = new System.Drawing.Point(63, 279);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(98, 36);
            this.KaydetBtn.TabIndex = 9;
            this.KaydetBtn.Text = "KAYDET";
            this.KaydetBtn.UseVisualStyleBackColor = true;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // KategoriTBox
            // 
            this.KategoriTBox.Location = new System.Drawing.Point(96, 191);
            this.KategoriTBox.Name = "KategoriTBox";
            this.KategoriTBox.Size = new System.Drawing.Size(113, 22);
            this.KategoriTBox.TabIndex = 8;
            // 
            // UrunFiyatTBox
            // 
            this.UrunFiyatTBox.Location = new System.Drawing.Point(96, 154);
            this.UrunFiyatTBox.Name = "UrunFiyatTBox";
            this.UrunFiyatTBox.Size = new System.Drawing.Size(113, 22);
            this.UrunFiyatTBox.TabIndex = 7;
            // 
            // UrunAdiTBox
            // 
            this.UrunAdiTBox.Location = new System.Drawing.Point(96, 115);
            this.UrunAdiTBox.Name = "UrunAdiTBox";
            this.UrunAdiTBox.Size = new System.Drawing.Size(113, 22);
            this.UrunAdiTBox.TabIndex = 6;
            // 
            // UrunKoduTBox
            // 
            this.UrunKoduTBox.Location = new System.Drawing.Point(96, 76);
            this.UrunKoduTBox.Name = "UrunKoduTBox";
            this.UrunKoduTBox.Size = new System.Drawing.Size(113, 22);
            this.UrunKoduTBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Kodu:";
            // 
            // UrunListeleDGV
            // 
            this.UrunListeleDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UrunListeleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrunListeleDGV.Location = new System.Drawing.Point(228, 93);
            this.UrunListeleDGV.Name = "UrunListeleDGV";
            this.UrunListeleDGV.RowHeadersWidth = 51;
            this.UrunListeleDGV.RowTemplate.Height = 24;
            this.UrunListeleDGV.Size = new System.Drawing.Size(551, 256);
            this.UrunListeleDGV.TabIndex = 0;
            this.UrunListeleDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UrunListeleDGV_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ürün Kodu Ara";
            // 
            // UrunAraTbox
            // 
            this.UrunAraTbox.Location = new System.Drawing.Point(466, 374);
            this.UrunAraTbox.Name = "UrunAraTbox";
            this.UrunAraTbox.Size = new System.Drawing.Size(100, 22);
            this.UrunAraTbox.TabIndex = 27;
            this.UrunAraTbox.TextChanged += new System.EventHandler(this.UrunAraTbox_TextChanged);
            // 
            // Stok_Takibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(928, 518);
            this.Controls.Add(this.panel1);
            this.Name = "Stok_Takibi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekleme";
            this.Load += new System.EventHandler(this.Stok_Takibi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrunListeleDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.TextBox KategoriTBox;
        private System.Windows.Forms.TextBox UrunFiyatTBox;
        private System.Windows.Forms.TextBox UrunAdiTBox;
        private System.Windows.Forms.TextBox UrunKoduTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UrunListeleDGV;
        private System.Windows.Forms.Button GuncelleBtn;
        private System.Windows.Forms.Button AnamenuBtn;
        private System.Windows.Forms.TextBox MiktarTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UrunAraTbox;
    }
}