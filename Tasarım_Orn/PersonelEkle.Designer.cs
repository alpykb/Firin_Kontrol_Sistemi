namespace Tasarım_Orn
{
    partial class PersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnaMenBtn = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.EmailTBox = new System.Windows.Forms.TextBox();
            this.AdresTBox = new System.Windows.Forms.TextBox();
            this.TelefonTBox = new System.Windows.Forms.TextBox();
            this.AdSoyadTBox = new System.Windows.Forms.TextBox();
            this.TCTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AnaMenBtn);
            this.panel1.Controls.Add(this.EkleBtn);
            this.panel1.Controls.Add(this.EmailTBox);
            this.panel1.Controls.Add(this.AdresTBox);
            this.panel1.Controls.Add(this.TelefonTBox);
            this.panel1.Controls.Add(this.AdSoyadTBox);
            this.panel1.Controls.Add(this.TCTBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(47, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 374);
            this.panel1.TabIndex = 0;
            // 
            // AnaMenBtn
            // 
            this.AnaMenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaMenBtn.Location = new System.Drawing.Point(3, 3);
            this.AnaMenBtn.Name = "AnaMenBtn";
            this.AnaMenBtn.Size = new System.Drawing.Size(118, 30);
            this.AnaMenBtn.TabIndex = 13;
            this.AnaMenBtn.Text = "ANA MENÜ";
            this.AnaMenBtn.UseVisualStyleBackColor = true;
            this.AnaMenBtn.Click += new System.EventHandler(this.AnaMenBtn_Click);
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(157, 298);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(116, 30);
            this.EkleBtn.TabIndex = 10;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // EmailTBox
            // 
            this.EmailTBox.Location = new System.Drawing.Point(157, 248);
            this.EmailTBox.Name = "EmailTBox";
            this.EmailTBox.Size = new System.Drawing.Size(100, 22);
            this.EmailTBox.TabIndex = 9;
            // 
            // AdresTBox
            // 
            this.AdresTBox.Location = new System.Drawing.Point(157, 194);
            this.AdresTBox.Name = "AdresTBox";
            this.AdresTBox.Size = new System.Drawing.Size(100, 22);
            this.AdresTBox.TabIndex = 8;
            // 
            // TelefonTBox
            // 
            this.TelefonTBox.Location = new System.Drawing.Point(157, 145);
            this.TelefonTBox.Name = "TelefonTBox";
            this.TelefonTBox.Size = new System.Drawing.Size(100, 22);
            this.TelefonTBox.TabIndex = 7;
            // 
            // AdSoyadTBox
            // 
            this.AdSoyadTBox.Location = new System.Drawing.Point(157, 93);
            this.AdSoyadTBox.Name = "AdSoyadTBox";
            this.AdSoyadTBox.Size = new System.Drawing.Size(100, 22);
            this.AdSoyadTBox.TabIndex = 6;
            // 
            // TCTBox
            // 
            this.TCTBox.Location = new System.Drawing.Point(157, 52);
            this.TCTBox.Name = "TCTBox";
            this.TCTBox.Size = new System.Drawing.Size(100, 22);
            this.TCTBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(493, 449);
            this.Controls.Add(this.panel1);
            this.Name = "PersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.TextBox EmailTBox;
        private System.Windows.Forms.TextBox AdresTBox;
        private System.Windows.Forms.TextBox TelefonTBox;
        private System.Windows.Forms.TextBox AdSoyadTBox;
        private System.Windows.Forms.TextBox TCTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnaMenBtn;
    }
}