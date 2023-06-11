namespace Tasarım_Orn
{
    partial class SatisListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisListe));
            this.SatisDGV = new System.Windows.Forms.DataGridView();
            this.AnamenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SatisDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SatisDGV
            // 
            this.SatisDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.SatisDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SatisDGV.Location = new System.Drawing.Point(101, 70);
            this.SatisDGV.Name = "SatisDGV";
            this.SatisDGV.RowHeadersWidth = 51;
            this.SatisDGV.RowTemplate.Height = 24;
            this.SatisDGV.Size = new System.Drawing.Size(600, 328);
            this.SatisDGV.TabIndex = 0;
            // 
            // AnamenuBtn
            // 
            this.AnamenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnamenuBtn.Location = new System.Drawing.Point(12, 12);
            this.AnamenuBtn.Name = "AnamenuBtn";
            this.AnamenuBtn.Size = new System.Drawing.Size(123, 39);
            this.AnamenuBtn.TabIndex = 15;
            this.AnamenuBtn.Text = "ANA MENÜ";
            this.AnamenuBtn.UseVisualStyleBackColor = true;
            this.AnamenuBtn.Click += new System.EventHandler(this.AnamenuBtn_Click);
            // 
            // SatisListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnamenuBtn);
            this.Controls.Add(this.SatisDGV);
            this.Name = "SatisListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Listeleme Sayfası";
            this.Load += new System.EventHandler(this.SatisListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SatisDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SatisDGV;
        private System.Windows.Forms.Button AnamenuBtn;
    }
}