namespace OtelReservation
{
    partial class frmYeniKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbKisiBilgileri = new System.Windows.Forms.GroupBox();
            this.btnKisiGuncelle = new System.Windows.Forms.Button();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.mstTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTcveyaPasaportNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUyruk = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUyruk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbKisiBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKisiBilgileri
            // 
            this.grbKisiBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.grbKisiBilgileri.Controls.Add(this.btnKisiGuncelle);
            this.grbKisiBilgileri.Controls.Add(this.btnDevamEt);
            this.grbKisiBilgileri.Controls.Add(this.mstTelefon);
            this.grbKisiBilgileri.Controls.Add(this.btnSil);
            this.grbKisiBilgileri.Controls.Add(this.btnKaydet);
            this.grbKisiBilgileri.Controls.Add(this.rbKadin);
            this.grbKisiBilgileri.Controls.Add(this.rbErkek);
            this.grbKisiBilgileri.Controls.Add(this.txtEPosta);
            this.grbKisiBilgileri.Controls.Add(this.txtSoyad);
            this.grbKisiBilgileri.Controls.Add(this.txtAd);
            this.grbKisiBilgileri.Controls.Add(this.txtTcveyaPasaportNo);
            this.grbKisiBilgileri.Controls.Add(this.label9);
            this.grbKisiBilgileri.Controls.Add(this.label8);
            this.grbKisiBilgileri.Controls.Add(this.label7);
            this.grbKisiBilgileri.Controls.Add(this.lblUyruk);
            this.grbKisiBilgileri.Controls.Add(this.label4);
            this.grbKisiBilgileri.Controls.Add(this.cmbUyruk);
            this.grbKisiBilgileri.Controls.Add(this.label3);
            this.grbKisiBilgileri.Controls.Add(this.label2);
            this.grbKisiBilgileri.Controls.Add(this.label1);
            this.grbKisiBilgileri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbKisiBilgileri.Location = new System.Drawing.Point(92, 38);
            this.grbKisiBilgileri.Name = "grbKisiBilgileri";
            this.grbKisiBilgileri.Size = new System.Drawing.Size(326, 355);
            this.grbKisiBilgileri.TabIndex = 2;
            this.grbKisiBilgileri.TabStop = false;
            this.grbKisiBilgileri.Text = "Kişi Bilgileri";
            // 
            // btnKisiGuncelle
            // 
            this.btnKisiGuncelle.BackColor = System.Drawing.Color.Azure;
            this.btnKisiGuncelle.Location = new System.Drawing.Point(44, 300);
            this.btnKisiGuncelle.Name = "btnKisiGuncelle";
            this.btnKisiGuncelle.Size = new System.Drawing.Size(93, 37);
            this.btnKisiGuncelle.TabIndex = 13;
            this.btnKisiGuncelle.Text = "Güncelle";
            this.btnKisiGuncelle.UseVisualStyleBackColor = false;
            this.btnKisiGuncelle.Click += new System.EventHandler(this.btnKisiGuncelle_Click);
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.BackColor = System.Drawing.Color.Azure;
            this.btnDevamEt.Location = new System.Drawing.Point(170, 300);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(94, 37);
            this.btnDevamEt.TabIndex = 3;
            this.btnDevamEt.Text = "Devam Et";
            this.btnDevamEt.UseVisualStyleBackColor = false;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // mstTelefon
            // 
            this.mstTelefon.Location = new System.Drawing.Point(151, 205);
            this.mstTelefon.Mask = "(999) 000-0000";
            this.mstTelefon.Name = "mstTelefon";
            this.mstTelefon.Size = new System.Drawing.Size(100, 20);
            this.mstTelefon.TabIndex = 7;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(176, 365);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(71, 365);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(225, 173);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 5;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(142, 173);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 4;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(151, 234);
            this.txtEPosta.MaxLength = 20;
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(100, 20);
            this.txtEPosta.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(151, 136);
            this.txtSoyad.MaxLength = 50;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 3;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(151, 98);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 2;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // txtTcveyaPasaportNo
            // 
            this.txtTcveyaPasaportNo.Location = new System.Drawing.Point(151, 57);
            this.txtTcveyaPasaportNo.MaxLength = 11;
            this.txtTcveyaPasaportNo.Name = "txtTcveyaPasaportNo";
            this.txtTcveyaPasaportNo.Size = new System.Drawing.Size(100, 20);
            this.txtTcveyaPasaportNo.TabIndex = 1;
            this.txtTcveyaPasaportNo.TextChanged += new System.EventHandler(this.txtTcveyaPasaportNo_TextChanged);
            this.txtTcveyaPasaportNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcveyaPasaportNo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "E-Posta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefon Numarası :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cinsiyet: ";
            // 
            // lblUyruk
            // 
            this.lblUyruk.AutoSize = true;
            this.lblUyruk.Location = new System.Drawing.Point(71, 60);
            this.lblUyruk.Name = "lblUyruk";
            this.lblUyruk.Size = new System.Drawing.Size(27, 13);
            this.lblUyruk.TabIndex = 5;
            this.lblUyruk.Text = "TC: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyadı:";
            // 
            // cmbUyruk
            // 
            this.cmbUyruk.FormattingEnabled = true;
            this.cmbUyruk.Location = new System.Drawing.Point(151, 19);
            this.cmbUyruk.Name = "cmbUyruk";
            this.cmbUyruk.Size = new System.Drawing.Size(100, 21);
            this.cmbUyruk.TabIndex = 0;
            this.cmbUyruk.SelectedIndexChanged += new System.EventHandler(this.cmbUyruk_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Uyruk:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // frmYeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::OtelReservation.Properties.Resources.gbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 447);
            this.Controls.Add(this.grbKisiBilgileri);
            this.Name = "frmYeniKayit";
            this.Text = "Müşteri Kayıt Formu";
            this.Load += new System.EventHandler(this.frmYeniKayit_Load);
            this.grbKisiBilgileri.ResumeLayout(false);
            this.grbKisiBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKisiBilgileri;
        private System.Windows.Forms.MaskedTextBox mstTelefon;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTcveyaPasaportNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUyruk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUyruk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDevamEt;
        private System.Windows.Forms.Button btnKisiGuncelle;
    }
}

