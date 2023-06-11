namespace Tasarım_Orn
{
    partial class UrunListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunListele));
            this.UrunListeleDGV = new System.Windows.Forms.DataGridView();
            this.AnamenuBtn = new System.Windows.Forms.Button();
            this.MiktarTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KategoriTBox = new System.Windows.Forms.TextBox();
            this.UrunFiyatTBox = new System.Windows.Forms.TextBox();
            this.UrunAdiTBox = new System.Windows.Forms.TextBox();
            this.UrunKoduTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.UrunAraTbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UrunListeleDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UrunListeleDGV
            // 
            this.UrunListeleDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UrunListeleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrunListeleDGV.Location = new System.Drawing.Point(218, 54);
            this.UrunListeleDGV.Name = "UrunListeleDGV";
            this.UrunListeleDGV.RowHeadersWidth = 51;
            this.UrunListeleDGV.RowTemplate.Height = 24;
            this.UrunListeleDGV.Size = new System.Drawing.Size(527, 219);
            this.UrunListeleDGV.TabIndex = 1;
            this.UrunListeleDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UrunListeleDGV_CellDoubleClick);
            // 
            // AnamenuBtn
            // 
            this.AnamenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnamenuBtn.Location = new System.Drawing.Point(12, 12);
            this.AnamenuBtn.Name = "AnamenuBtn";
            this.AnamenuBtn.Size = new System.Drawing.Size(123, 39);
            this.AnamenuBtn.TabIndex = 13;
            this.AnamenuBtn.Text = "ANA MENÜ";
            this.AnamenuBtn.UseVisualStyleBackColor = true;
            this.AnamenuBtn.Click += new System.EventHandler(this.AnamenuBtn_Click);
            // 
            // MiktarTBox
            // 
            this.MiktarTBox.Location = new System.Drawing.Point(89, 222);
            this.MiktarTBox.Name = "MiktarTBox";
            this.MiktarTBox.Size = new System.Drawing.Size(113, 22);
            this.MiktarTBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Miktar:";
            // 
            // KategoriTBox
            // 
            this.KategoriTBox.Location = new System.Drawing.Point(89, 181);
            this.KategoriTBox.Name = "KategoriTBox";
            this.KategoriTBox.Size = new System.Drawing.Size(113, 22);
            this.KategoriTBox.TabIndex = 22;
            // 
            // UrunFiyatTBox
            // 
            this.UrunFiyatTBox.Location = new System.Drawing.Point(89, 144);
            this.UrunFiyatTBox.Name = "UrunFiyatTBox";
            this.UrunFiyatTBox.Size = new System.Drawing.Size(113, 22);
            this.UrunFiyatTBox.TabIndex = 21;
            // 
            // UrunAdiTBox
            // 
            this.UrunAdiTBox.Location = new System.Drawing.Point(89, 105);
            this.UrunAdiTBox.Name = "UrunAdiTBox";
            this.UrunAdiTBox.Size = new System.Drawing.Size(113, 22);
            this.UrunAdiTBox.TabIndex = 20;
            // 
            // UrunKoduTBox
            // 
            this.UrunKoduTBox.Location = new System.Drawing.Point(89, 66);
            this.UrunKoduTBox.Name = "UrunKoduTBox";
            this.UrunKoduTBox.Size = new System.Drawing.Size(113, 22);
            this.UrunKoduTBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ürün Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ürün Kodu:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UrunAraTbox);
            this.panel1.Controls.Add(this.UrunFiyatTBox);
            this.panel1.Controls.Add(this.MiktarTBox);
            this.panel1.Controls.Add(this.UrunListeleDGV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.KategoriTBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.UrunAdiTBox);
            this.panel1.Controls.Add(this.UrunKoduTBox);
            this.panel1.Location = new System.Drawing.Point(23, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 352);
            this.panel1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ürün Kodu Ara";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // UrunAraTbox
            // 
            this.UrunAraTbox.Location = new System.Drawing.Point(445, 290);
            this.UrunAraTbox.Name = "UrunAraTbox";
            this.UrunAraTbox.Size = new System.Drawing.Size(100, 22);
            this.UrunAraTbox.TabIndex = 25;
            this.UrunAraTbox.TextChanged += new System.EventHandler(this.tcAraTBox_TextChanged);
            // 
            // UrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnamenuBtn);
            this.Name = "UrunListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Listele";
            this.Load += new System.EventHandler(this.UrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UrunListeleDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UrunListeleDGV;
        private System.Windows.Forms.Button AnamenuBtn;
        private System.Windows.Forms.TextBox MiktarTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KategoriTBox;
        private System.Windows.Forms.TextBox UrunFiyatTBox;
        private System.Windows.Forms.TextBox UrunAdiTBox;
        private System.Windows.Forms.TextBox UrunKoduTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UrunAraTbox;
    }
}