namespace OtelReservation
{
    partial class frmKisiBilgileri
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
            this.dgvKisiListele = new System.Windows.Forms.DataGridView();
            this.btnKisiGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKisiListele
            // 
            this.dgvKisiListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKisiListele.Location = new System.Drawing.Point(23, 12);
            this.dgvKisiListele.Name = "dgvKisiListele";
            this.dgvKisiListele.Size = new System.Drawing.Size(687, 339);
            this.dgvKisiListele.TabIndex = 0;
            // 
            // btnKisiGuncelle
            // 
            this.btnKisiGuncelle.Location = new System.Drawing.Point(120, 390);
            this.btnKisiGuncelle.Name = "btnKisiGuncelle";
            this.btnKisiGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnKisiGuncelle.TabIndex = 1;
            this.btnKisiGuncelle.Text = "Guncelle";
            this.btnKisiGuncelle.UseVisualStyleBackColor = true;
            // 
            // frmKisiBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKisiGuncelle);
            this.Controls.Add(this.dgvKisiListele);
            this.Name = "frmKisiBilgileri";
            this.Text = "KisiBilgileri";
            this.Load += new System.EventHandler(this.KisiBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKisiListele;
        private System.Windows.Forms.Button btnKisiGuncelle;
    }
}