namespace OtelReservation
{
    partial class frmRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyon));
            this.lblGiris = new System.Windows.Forms.Label();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.imgOdaIconu = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbOdaTurleri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlOdaBilgileri = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOdaTuru = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRezerv = new System.Windows.Forms.Button();
            this.labelt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblToplamKapasite = new System.Windows.Forms.Label();
            this.lblToplamUcret = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nmKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnRezervasyonGoruntule = new System.Windows.Forms.Button();
            this.flpOdalar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOdaBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmKisiSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.BackColor = System.Drawing.Color.Transparent;
            this.lblGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.SystemColors.Window;
            this.lblGiris.Location = new System.Drawing.Point(26, 58);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(103, 22);
            this.lblGiris.TabIndex = 1;
            this.lblGiris.Text = "Giriş Tarihi:";
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Location = new System.Drawing.Point(144, 58);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(152, 20);
            this.dtpGirisTarihi.TabIndex = 2;
            this.dtpGirisTarihi.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // imgOdaIconu
            // 
            this.imgOdaIconu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgOdaIconu.ImageStream")));
            this.imgOdaIconu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgOdaIconu.Images.SetKeyName(0, "images.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Çıkış Tarihi:";
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(144, 95);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(152, 20);
            this.dtpCikisTarihi.TabIndex = 2;
            this.dtpCikisTarihi.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // cmbOdaTurleri
            // 
            this.cmbOdaTurleri.FormattingEnabled = true;
            this.cmbOdaTurleri.Location = new System.Drawing.Point(144, 26);
            this.cmbOdaTurleri.Name = "cmbOdaTurleri";
            this.cmbOdaTurleri.Size = new System.Drawing.Size(152, 21);
            this.cmbOdaTurleri.TabIndex = 7;
            this.cmbOdaTurleri.SelectedIndexChanged += new System.EventHandler(this.cmbOdaTurleri_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oda Sınıfı:";
            // 
            // pnlOdaBilgileri
            // 
            this.pnlOdaBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.pnlOdaBilgileri.Controls.Add(this.pictureBox1);
            this.pnlOdaBilgileri.Controls.Add(this.lblOdaNo);
            this.pnlOdaBilgileri.Controls.Add(this.label8);
            this.pnlOdaBilgileri.Controls.Add(this.lblKapasite);
            this.pnlOdaBilgileri.Controls.Add(this.lblUcret);
            this.pnlOdaBilgileri.Controls.Add(this.label7);
            this.pnlOdaBilgileri.Controls.Add(this.label5);
            this.pnlOdaBilgileri.Controls.Add(this.lblOdaTuru);
            this.pnlOdaBilgileri.Controls.Add(this.label6);
            this.pnlOdaBilgileri.Controls.Add(this.label4);
            this.pnlOdaBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlOdaBilgileri.Location = new System.Drawing.Point(393, 121);
            this.pnlOdaBilgileri.Name = "pnlOdaBilgileri";
            this.pnlOdaBilgileri.Size = new System.Drawing.Size(201, 326);
            this.pnlOdaBilgileri.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OtelReservation.Properties.Resources.uckisilik;
            this.pictureBox1.Location = new System.Drawing.Point(24, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOdaNo.Location = new System.Drawing.Point(116, 17);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(23, 25);
            this.lblOdaNo.TabIndex = 1;
            this.lblOdaNo.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(146, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kişi";
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKapasite.Location = new System.Drawing.Point(124, 98);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(16, 17);
            this.lblKapasite.TabIndex = 0;
            this.lblKapasite.Text = "0";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUcret.Location = new System.Drawing.Point(96, 132);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(16, 17);
            this.lblUcret.TabIndex = 0;
            this.lblUcret.Text = "₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Oda Kapasitesi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(21, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ücret :";
            // 
            // lblOdaTuru
            // 
            this.lblOdaTuru.AutoSize = true;
            this.lblOdaTuru.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOdaTuru.Location = new System.Drawing.Point(93, 65);
            this.lblOdaTuru.Name = "lblOdaTuru";
            this.lblOdaTuru.Size = new System.Drawing.Size(69, 17);
            this.lblOdaTuru.TabIndex = 0;
            this.lblOdaTuru.Text = "Oda Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(26, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Oda No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oda Türü :";
            // 
            // btnRezerv
            // 
            this.btnRezerv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezerv.Location = new System.Drawing.Point(426, 511);
            this.btnRezerv.Name = "btnRezerv";
            this.btnRezerv.Size = new System.Drawing.Size(168, 39);
            this.btnRezerv.TabIndex = 10;
            this.btnRezerv.Text = "Rezervasyon Yap";
            this.btnRezerv.UseVisualStyleBackColor = true;
            this.btnRezerv.Click += new System.EventHandler(this.btnRezerv_Click);
            // 
            // labelt
            // 
            this.labelt.AutoSize = true;
            this.labelt.BackColor = System.Drawing.Color.Transparent;
            this.labelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelt.ForeColor = System.Drawing.SystemColors.Window;
            this.labelt.Location = new System.Drawing.Point(23, 502);
            this.labelt.Name = "labelt";
            this.labelt.Size = new System.Drawing.Size(150, 22);
            this.labelt.TabIndex = 11;
            this.labelt.Text = "Toplam Kapasite:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(23, 540);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Toplam Oda Ücreti: ";
            // 
            // lblToplamKapasite
            // 
            this.lblToplamKapasite.AutoSize = true;
            this.lblToplamKapasite.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKapasite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToplamKapasite.Location = new System.Drawing.Point(211, 502);
            this.lblToplamKapasite.Name = "lblToplamKapasite";
            this.lblToplamKapasite.Size = new System.Drawing.Size(20, 22);
            this.lblToplamKapasite.TabIndex = 13;
            this.lblToplamKapasite.Text = "0";
            // 
            // lblToplamUcret
            // 
            this.lblToplamUcret.AutoSize = true;
            this.lblToplamUcret.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUcret.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToplamUcret.Location = new System.Drawing.Point(211, 540);
            this.lblToplamUcret.Name = "lblToplamUcret";
            this.lblToplamUcret.Size = new System.Drawing.Size(20, 22);
            this.lblToplamUcret.TabIndex = 13;
            this.lblToplamUcret.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(413, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Kişi Sayısı:";
            // 
            // nmKisiSayisi
            // 
            this.nmKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmKisiSayisi.Location = new System.Drawing.Point(518, 22);
            this.nmKisiSayisi.Name = "nmKisiSayisi";
            this.nmKisiSayisi.Size = new System.Drawing.Size(51, 27);
            this.nmKisiSayisi.TabIndex = 15;
            // 
            // btnRezervasyonGoruntule
            // 
            this.btnRezervasyonGoruntule.BackColor = System.Drawing.Color.Transparent;
            this.btnRezervasyonGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonGoruntule.Location = new System.Drawing.Point(313, 511);
            this.btnRezervasyonGoruntule.Name = "btnRezervasyonGoruntule";
            this.btnRezervasyonGoruntule.Size = new System.Drawing.Size(107, 39);
            this.btnRezervasyonGoruntule.TabIndex = 16;
            this.btnRezervasyonGoruntule.Text = "Rezervasyonları Görüntüle";
            this.btnRezervasyonGoruntule.UseVisualStyleBackColor = false;
            this.btnRezervasyonGoruntule.Click += new System.EventHandler(this.btnRezervasyonGoruntule_Click);
            // 
            // flpOdalar
            // 
            this.flpOdalar.BackColor = System.Drawing.Color.Transparent;
            this.flpOdalar.Location = new System.Drawing.Point(15, 121);
            this.flpOdalar.Name = "flpOdalar";
            this.flpOdalar.Size = new System.Drawing.Size(375, 326);
            this.flpOdalar.TabIndex = 17;
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::OtelReservation.Properties.Resources.gbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 571);
            this.Controls.Add(this.flpOdalar);
            this.Controls.Add(this.btnRezervasyonGoruntule);
            this.Controls.Add(this.nmKisiSayisi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblToplamUcret);
            this.Controls.Add(this.lblToplamKapasite);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelt);
            this.Controls.Add(this.btnRezerv);
            this.Controls.Add(this.pnlOdaBilgileri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOdaTurleri);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.dtpGirisTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGiris);
            this.Name = "frmRezervasyon";
            this.Text = "Otel Uygulaması";
            this.Load += new System.EventHandler(this.Rezervasyon_Load);
            this.pnlOdaBilgileri.ResumeLayout(false);
            this.pnlOdaBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmKisiSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.ImageList imgOdaIconu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.ComboBox cmbOdaTurleri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlOdaBilgileri;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOdaTuru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRezerv;
        private System.Windows.Forms.Label labelt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblToplamKapasite;
        private System.Windows.Forms.Label lblToplamUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmKisiSayisi;
        private System.Windows.Forms.Button btnRezervasyonGoruntule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpOdalar;
    }
}