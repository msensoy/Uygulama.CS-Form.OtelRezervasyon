using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OtelReservation
{
    public partial class frmRezervasyon : Form
    {
        #region _Fields
        OtelRezervasyonDBEntities _db;
        DateTime _resGirisTarihi;
        DateTime _resCikisTarihi;
        short _toplamKapasite;
        double _toplamUcret;
        private ClassUser _kullanici;
        HashSet<int> _odaNumaralari;
        #endregion


        public frmRezervasyon(ClassUser kullanici)
        {
            InitializeComponent();
            _db = new OtelRezervasyonDBEntities();
            this._kullanici = kullanici;
            _odaNumaralari = new HashSet<int>();
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
            flpOdalar.Controls.Clear(); // Ekran temizleniyor

            #region Secilen Oda Türüne Ait Odaların Numaraları Liste halinde db den çekiliyor
            var secilenKategoridekiOdaNumaralari = (from r in _db.RoomDetails
                                                    join ro in _db.Rooms on r.RoomDetailID equals ro.RoomDetailID
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
                btn.Tag = " ";

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
                                                  re.IsActive == true &&
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

            _toplamKapasite = 0;
            _toplamUcret = 0;

            pnlOdaBilgileri.Visible = true;
            int odaNo = Convert.ToInt32((btn.Text));
            lblOdaNo.Text = odaNo.ToString();
            var btnTag = btn.Tag.ToString();

            if (!btnTag.Contains("Clicked"))
            {
                btn.BackColor = Color.Yellow;
                btn.Tag = "Clicked";
            }
            else
            {
                btn.BackColor = Color.Green;
                btn.Tag = "";
            }
    
            string odaCinsi = (from r in _db.RoomDetails
                               join ro in _db.Rooms on r.RoomDetailID equals ro.RoomDetailID
                               where ro.RoomNumber == odaNo
                               select r.RoomType).FirstOrDefault();

            lblOdaTuru.Text = odaCinsi;

            var odaKapasitesi = (from rd in _db.RoomDetails
                                 join ro in _db.Rooms on rd.RoomDetailID equals ro.RoomDetailID
                                 where ro.RoomNumber == odaNo
                                 select rd.RoomCapacity).FirstOrDefault();

            lblKapasite.Text = odaKapasitesi.ToString();

            var odaUcret = (from rd in _db.RoomDetails
                            join ro in _db.Rooms on rd.RoomDetailID equals ro.RoomDetailID
                            where ro.RoomNumber == odaNo
                            select rd.Price).FirstOrDefault();

            lblUcret.Text = odaUcret.ToString("N2");
            lblToplamUcret.Text = "";
            lblToplamKapasite.Text = "";
            _odaNumaralari = new HashSet<int>();
            foreach (Button item in flpOdalar.Controls)
            {
                if (item.BackColor == Color.Yellow)
                {
                    btnRezerv.Enabled = true;

                    _odaNumaralari.Add(Convert.ToInt32(item.Text));

                    _toplamKapasite += Convert.ToInt16(lblKapasite.Text);
                    lblToplamKapasite.Text = _toplamKapasite.ToString();

                    _toplamUcret += Convert.ToDouble(lblUcret.Text);
                    lblToplamUcret.Text = _toplamUcret.ToString();
                }
            }

        }


        private void btnRezerv_Click(object sender, EventArgs e)
        {
            #region Kayıt yapılabilmesi için gereken şartlar
            if (nmKisiSayisi.Value <= 0)
            { MessageBox.Show("Kişi Sayısı Girmediniz!"); return; }

            if (nmKisiSayisi.Value > _toplamKapasite)
            { MessageBox.Show("Kişi Sayısı Oda Kapasitesinden Büyük Olamaz"); return; }
            #endregion

            #region Rezervasyon bilgilerini "rezervasyonOzet" e kaydetme
            RezervasyonOzet rezervasyonOzet = new RezervasyonOzet();

            rezervasyonOzet.SecilenOdaNumaralari = _odaNumaralari;
            rezervasyonOzet.MisafirSayisi = Convert.ToInt32(nmKisiSayisi.Value);
            rezervasyonOzet.ToplamUcret = _toplamUcret;
            rezervasyonOzet.GirisTarihi = dtpGirisTarihi.Value;
            rezervasyonOzet.CikisTarihi = dtpCikisTarihi.Value;
            #endregion

            #region Yeni Kayıt Formunu Açma
            frmYeniKayit frmYeniKayit = new frmYeniKayit(rezervasyonOzet, _kullanici);
            frmYeniKayit.ShowDialog();


            #region EkraniTemizle
            pnlOdaBilgileri.Controls.Clear();
            lblToplamKapasite.Text = "";
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
