using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelReservation
{
    public partial class frmRezervasyon : Form
    {       
        #region _Fields

         OtelRezervasyonDBEntities _db;
        DateTime _resGirisTarihi;
        DateTime _resCikisTarihi;
        short toplamKapasite;
        double toplamUcret;
        int odaNumarasi;
        int clickSayisi;

        #endregion


        public frmRezervasyon(ClassUser kullanici)
        {
            InitializeComponent();
            _db = new  OtelRezervasyonDBEntities();
            this.kullanici = kullanici;
        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
          
            #region Oda Türleri db den comboboxa basılıyor
            var odaTurleri = (from r in _db.RoomDetails select r.RoomType).ToList();
            cmbOdaTurleri.DataSource = odaTurleri;
            cmbOdaTurleri.Text = "Oda Türü Seçiniz";
            #endregion

            #region DateTime MinDate ayarları
            dtpGirisTarihi.MinDate = DateTime.Now;
            dtpCikisTarihi.MinDate = dtpGirisTarihi.Value.AddDays(1);
            #endregion

            #region Form Açıldığında olması gereken şartlar

            pnlOdaBilgileri.Visible = false;

            if (lblToplamKapasite.Text == "")
            {
                btnRezerv.Enabled = false;
            } 
            #endregion

        }

        private void cmbOdaTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpOdalar.Controls.Clear(); //Ekranı önce bi temizle
           
            #region Secilen Oda Türüne Ait Odaların Numaraları Liste halinde db den çekiliyor
            var secilenKategoridekiOdaNumaralari = (from r in _db.RoomDetails
                                                    join ro in _db.Rooms on r.RoomDetailID equals                                       ro.RoomDetailID
                                                    where r.RoomType == cmbOdaTurleri.Text
                                                    select ro.RoomNumber
                                                    ).ToList();
            #endregion      

            #region Dinamik Buton Oluşturuluyor Odalar için
            int dinamikOlusacakButonSayisi = secilenKategoridekiOdaNumaralari.Count;

            foreach (int item in secilenKategoridekiOdaNumaralari)
            {
                Button btn = new Button();

                btn.Text = item.ToString();
                btn.Height = 50;
                btn.Width = 50;
                btn.Tag = "";

                btn.Click += new EventHandler(btnOda_Click);
                flpOdalar.Controls.Add(btn); // FlowLayoutPanel'e ekleme işlemi yapıldı

            }
            #endregion

            OdalariGuncelle();

        }
    
        private void dtpTarih_ValueChanged(object sender, EventArgs e) 
        // bu event, tarih seçimi değiştiğinde çalışır (date picker ların her ikisi içinde geçerli)
        {
            OdalariGuncelle();
        }

        public void OdalariGuncelle()
        {
            #region Genel Tarih kısıtları , field atamaları
            dtpCikisTarihi.MinDate = dtpGirisTarihi.Value.AddDays(1);
            _resGirisTarihi = dtpGirisTarihi.Value;
            _resCikisTarihi = dtpCikisTarihi.Value;
            #endregion

            #region Tarih kısıtına göre, Musait Olmayan Odalarin Numaralari sorgu ile Listeye basılıyor
            var musaitOlmayanOdaNumaralari = (from ro in _db.Rooms
                                              join r in _db.ReservationDetails on
                                              ro.RoomID equals r.RoomID
                                              join re in _db.Reservations on
                                              r.ReservationID equals re.ReservationID
                                              where (
                                                  re.EntryDate != null
                                                  &&
                                                    (_resCikisTarihi >= re.EntryDate
                                                        &&
                                                     _resGirisTarihi <= re.ReleaseDate)
                                                    )
                                              select ro.RoomNumber).ToList();
            #endregion

            #region Tarihe kısıtına göre Odaların Müsait Olup, olmamalarına göre işlemler yapılıyor

            foreach (var odaNumarasi in musaitOlmayanOdaNumaralari)
            {
                foreach (Button btn in flpOdalar.Controls)
                {
                    if (odaNumarasi.ToString() == btn.Text)
                    {
                        btn.Tag = "MusaitDeğil";
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                    }
                }
            }

            foreach (Button btn in flpOdalar.Controls)
            {
                if (btn.Tag.ToString() != "MusaitDeğil")
                {
                    btn.BackColor = Color.Green;
                    btn.Enabled = true;
                }
                btn.Tag = "";// tekrar bütün btn ların tagı bir sonraki oluşabilecek sorgu için sıfırlanıyor
            }
            #endregion
        }

        private void btnOda_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor == Color.Yellow) { clickSayisi = 1; }

            toplamKapasite = 0;
            toplamUcret = 0;

            pnlOdaBilgileri.Visible = true;
            clickSayisi++;

            if (clickSayisi % 2 == 0)
            {
                ((Button)sender).BackColor = Color.Yellow;
                btn.BackColor = Color.Yellow;

            }
            if (clickSayisi % 2 == 1)
            {
                ((Button)sender).BackColor = Color.Green;
                lblOdaNo.Text = ((Button)sender).Text;
                int odaNo = Convert.ToInt32(((Button)sender).Text);

                string odaAdıYakala = (from r in _db.RoomDetails
                                       join ro in _db.Rooms on r.RoomDetailID equals ro.RoomDetailID
                                       where ro.RoomNumber == odaNo
                                       select r.RoomType).FirstOrDefault();

                lblOdaTuru.Text = odaAdıYakala;

                var odaKapasitesi = (from rd in _db.RoomDetails
                                     join ro in _db.Rooms on rd.RoomDetailID equals ro.RoomDetailID
                                     where ro.RoomNumber == odaNo
                                     select rd.RoomCapacity
                               ).FirstOrDefault();

                lblKapasite.Text = odaKapasitesi.ToString();

                var odaUcret = (from rd in _db.RoomDetails
                                join ro in _db.Rooms on rd.RoomDetailID equals ro.RoomDetailID
                                where ro.RoomNumber == odaNo
                                select rd.Price
                                ).FirstOrDefault();
                lblUcret.Text = odaUcret.ToString();

            }

            foreach (Button item in flpOdalar.Controls)
            {
                if (item.BackColor == Color.Yellow)
                {
                    btnRezerv.Enabled = true;

                    odaNumaralari.Add(Convert.ToInt32(item.Text));

                    toplamKapasite += Convert.ToInt16(lblKapasite.Text);
                    lblToplamKapasite.Text = toplamKapasite.ToString();

                    toplamUcret += Convert.ToDouble(lblUcret.Text);
                    lblToplamUcret.Text = toplamUcret.ToString();
                }
            }

        }

        HashSet<int> odaNumaralari = new HashSet<int>();
        private ClassUser kullanici;

        private void btnRezerv_Click(object sender, EventArgs e)
        {
            #region Kayıt yapılabilmesi için gereken şartlar
            if (nmKisiSayisi.Value <= 0)
            { MessageBox.Show("Kişi Sayısı Girmediniz!"); return; }

            if (nmKisiSayisi.Value > toplamKapasite)
            { MessageBox.Show("Kişi Sayısı Oda Kapasitesinden Büyük Olamaz"); return; }
            #endregion

            #region Rezervasyon bilgilerini "rezervasyonOzet" e kaydetme
            RezervasyonOzet rezervasyonOzet = new RezervasyonOzet();

            rezervasyonOzet.SecilenOdaNumaralari = odaNumaralari;
            rezervasyonOzet.MisafirSayisi = Convert.ToInt32(nmKisiSayisi.Value);
            rezervasyonOzet.ToplamUcret = toplamUcret;
            rezervasyonOzet.GirisTarihi = dtpGirisTarihi.Value;
            rezervasyonOzet.CikisTarihi = dtpCikisTarihi.Value;
            #endregion

            #region Yeni Kayıt Formunu Açma
            frmYeniKayit frmYeniKayit = new frmYeniKayit(rezervasyonOzet,kullanici);
            frmYeniKayit.ShowDialog();
           

            #region EkraniTemizle
            pnlOdaBilgileri.Controls.Clear();
            lblToplamKapasite.Text = "";
            lblToplamOdaSayisi.Text = "";
            lblToplamUcret.Text = "";
            OdalariGuncelle();
            #endregion

            #endregion
        }

        private void btnRezervasyonGoruntule_Click(object sender, EventArgs e)
        {
            frmRezervasyonBilgileri frmRezervasyonBilgileri = new frmRezervasyonBilgileri();
            frmRezervasyonBilgileri.ShowDialog();
        }

    }
}
