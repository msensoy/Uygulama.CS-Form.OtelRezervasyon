namespace OtelReservation
{
    partial class frmKonukEkle
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
            this.flpMisafir = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMisafirleriKaydet = new System.Windows.Forms.Button();
            this.lstOdaNo = new System.Windows.Forms.ListBox();
            this.btnMisafirleriEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpMisafir
            // 
            this.flpMisafir.Location = new System.Drawing.Point(212, 40);
            this.flpMisafir.Name = "flpMisafir";
            this.flpMisafir.Size = new System.Drawing.Size(428, 304);
            this.flpMisafir.TabIndex = 1;
            // 
            // btnMisafirleriKaydet
            // 
            this.btnMisafirleriKaydet.Location = new System.Drawing.Point(676, 387);
            this.btnMisafirleriKaydet.Name = "btnMisafirleriKaydet";
            this.btnMisafirleriKaydet.Size = new System.Drawing.Size(93, 39);
            this.btnMisafirleriKaydet.TabIndex = 12;
            this.btnMisafirleriKaydet.Text = "Tamamla";
            this.btnMisafirleriKaydet.UseVisualStyleBackColor = true;
            this.btnMisafirleriKaydet.Click += new System.EventHandler(this.btnMisafirleriKaydet_Click);
            // 
            // lstOdaNo
            // 
            this.lstOdaNo.FormattingEnabled = true;
            this.lstOdaNo.Location = new System.Drawing.Point(26, 40);
            this.lstOdaNo.Name = "lstOdaNo";
            this.lstOdaNo.Size = new System.Drawing.Size(138, 303);
            this.lstOdaNo.TabIndex = 14;
            this.lstOdaNo.SelectedIndexChanged += new System.EventHandler(this.lstOdaNo_SelectedIndexChanged_1);
            // 
            // btnMisafirleriEkle
            // 
            this.btnMisafirleriEkle.Location = new System.Drawing.Point(676, 52);
            this.btnMisafirleriEkle.Name = "btnMisafirleriEkle";
            this.btnMisafirleriEkle.Size = new System.Drawing.Size(93, 56);
            this.btnMisafirleriEkle.TabIndex = 15;
            this.btnMisafirleriEkle.Text = "Seçilen Odaya Ait Misafirleri Ekle";
            this.btnMisafirleriEkle.UseVisualStyleBackColor = true;
            this.btnMisafirleriEkle.Click += new System.EventHandler(this.btnMisafirleriEkle_Click);
            // 
            // frmKonukEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtelReservation.Properties.Resources.gbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMisafirleriEkle);
            this.Controls.Add(this.lstOdaNo);
            this.Controls.Add(this.btnMisafirleriKaydet);
            this.Controls.Add(this.flpMisafir);
            this.Name = "frmKonukEkle";
            this.Text = "KonukEkle";
            this.Load += new System.EventHandler(this.frmKonukEkle_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpMisafir;
        private System.Windows.Forms.Button btnMisafirleriKaydet;
        private System.Windows.Forms.ListBox lstOdaNo;
        private System.Windows.Forms.Button btnMisafirleriEkle;
    }
}