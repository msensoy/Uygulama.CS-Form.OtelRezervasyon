namespace OtelReservation
{
    partial class frmAnasayfa
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
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.BtnOdaEkle = new System.Windows.Forms.Button();
            this.btnRezervasyonGoruntule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.Location = new System.Drawing.Point(53, 91);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(104, 72);
            this.btnRezervasyonYap.TabIndex = 0;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = true;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // BtnOdaEkle
            // 
            this.BtnOdaEkle.Location = new System.Drawing.Point(375, 91);
            this.BtnOdaEkle.Name = "BtnOdaEkle";
            this.BtnOdaEkle.Size = new System.Drawing.Size(104, 72);
            this.BtnOdaEkle.TabIndex = 0;
            this.BtnOdaEkle.Text = "Oda Ekle";
            this.BtnOdaEkle.UseVisualStyleBackColor = true;
            this.BtnOdaEkle.Click += new System.EventHandler(this.BtnOdaEkle_Click);
            // 
            // btnRezervasyonGoruntule
            // 
            this.btnRezervasyonGoruntule.Location = new System.Drawing.Point(213, 91);
            this.btnRezervasyonGoruntule.Name = "btnRezervasyonGoruntule";
            this.btnRezervasyonGoruntule.Size = new System.Drawing.Size(110, 72);
            this.btnRezervasyonGoruntule.TabIndex = 0;
            this.btnRezervasyonGoruntule.Text = "Rezervasyon Görüntüle";
            this.btnRezervasyonGoruntule.UseVisualStyleBackColor = true;
            this.btnRezervasyonGoruntule.Click += new System.EventHandler(this.btnRezervasyonGoruntule_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(567, 264);
            this.Controls.Add(this.btnRezervasyonGoruntule);
            this.Controls.Add(this.BtnOdaEkle);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Name = "frmAnasayfa";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Button BtnOdaEkle;
        private System.Windows.Forms.Button btnRezervasyonGoruntule;
    }
}