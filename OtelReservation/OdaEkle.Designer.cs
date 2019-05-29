namespace OtelReservation
{
    partial class frmOdaEkle
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
            this.btnOdaKaydet = new System.Windows.Forms.Button();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOdaKapasite = new System.Windows.Forms.Label();
            this.cmbOdaTurleri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdaKaydet
            // 
            this.btnOdaKaydet.Location = new System.Drawing.Point(115, 124);
            this.btnOdaKaydet.Name = "btnOdaKaydet";
            this.btnOdaKaydet.Size = new System.Drawing.Size(121, 23);
            this.btnOdaKaydet.TabIndex = 0;
            this.btnOdaKaydet.Text = "Kaydet";
            this.btnOdaKaydet.UseVisualStyleBackColor = true;
            this.btnOdaKaydet.Click += new System.EventHandler(this.btnOdaKaydet_Click);
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(115, 57);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(121, 20);
            this.txtOdaNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oda No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oda Kapasitesi :";
            // 
            // lblOdaKapasite
            // 
            this.lblOdaKapasite.AutoSize = true;
            this.lblOdaKapasite.Location = new System.Drawing.Point(112, 90);
            this.lblOdaKapasite.Name = "lblOdaKapasite";
            this.lblOdaKapasite.Size = new System.Drawing.Size(13, 13);
            this.lblOdaKapasite.TabIndex = 2;
            this.lblOdaKapasite.Text = "0";
            // 
            // cmbOdaTurleri
            // 
            this.cmbOdaTurleri.FormattingEnabled = true;
            this.cmbOdaTurleri.Location = new System.Drawing.Point(115, 30);
            this.cmbOdaTurleri.Name = "cmbOdaTurleri";
            this.cmbOdaTurleri.Size = new System.Drawing.Size(121, 21);
            this.cmbOdaTurleri.TabIndex = 3;
            this.cmbOdaTurleri.SelectedIndexChanged += new System.EventHandler(this.cmbOdaTurleri_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Oda Tipi :";
            // 
            // frmOdaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 179);
            this.Controls.Add(this.cmbOdaTurleri);
            this.Controls.Add(this.lblOdaKapasite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.btnOdaKaydet);
            this.Name = "frmOdaEkle";
            this.Text = "Oda Ekle";
            this.Load += new System.EventHandler(this.frmOdaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdaKaydet;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOdaKapasite;
        private System.Windows.Forms.ComboBox cmbOdaTurleri;
        private System.Windows.Forms.Label label4;
    }
}