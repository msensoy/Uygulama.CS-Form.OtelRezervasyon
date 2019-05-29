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
    public partial class frmRezervasyonTamamla : Form
    {
        private Customer kisi;
        private RezervasyonOzet rezervasyonOzet;
       
        private ClassUser kullanici;
        private List<string> misafirAdlari;
        private List<string> misafirSoyadlari;
        List<string> odaNumaralari;

        public frmRezervasyonTamamla(Customer kisi, RezervasyonOzet rezervasyonOzet, ClassUser kullanici)
        {
            InitializeComponent();
            this.kisi = kisi;
            this.rezervasyonOzet = rezervasyonOzet;
            this.kullanici = kullanici;
        }


        public frmRezervasyonTamamla(RezervasyonOzet rezervasyonOzet, List<string> misafirAdlari, List<string> misafirSoyadlari, List<string> odaNumaralari, Customer kisi, ClassUser kullanici) 
        {
            InitializeComponent();
            this.rezervasyonOzet = rezervasyonOzet;
            this.misafirAdlari = misafirAdlari;
            this.misafirSoyadlari = misafirSoyadlari;
            this.odaNumaralari = odaNumaralari;
            this.kisi = kisi;
            this.kullanici = kullanici;
        }

        private void frmRezervasyonTamamla_Load(object sender, EventArgs e)
        {
            lblAdi.Text = kisi.FirstName;
            lblSoyadi.Text = kisi.Lastname;
            lblUyruk.Text = kisi.TcKimlik;
            lblEMail.Text = kisi.E_Mail;
            lblTelNo.Text = kisi.PhoneNumber;

            lstOdaNo.DataSource = rezervasyonOzet.SecilenOdaNumaralari.ToList();
            lblGirisTarihi.Text = rezervasyonOzet.GirisTarihi.ToShortDateString();
            lblCikisTarihi.Text = rezervasyonOzet.CikisTarihi.ToShortDateString();
            lblToplamKisiSayisi.Text = rezervasyonOzet.MisafirSayisi.ToString();
            lblToplamUcret.Text = rezervasyonOzet.ToplamUcret.ToString();
            lstOdaNo.SelectedIndex = -1;


        }



        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmRezervasyon frmRezervasyon = new frmRezervasyon(kullanici);
            frmRezervasyon.Show();
            this.Close();



        }

        private void btnRezervasyonBitir_Click(object sender, EventArgs e)
        {
            using (OtelRezervasyonDBEntities _db=new OtelRezervasyonDBEntities())
            {
                using (var transaction=_db.Database.BeginTransaction())
                {
                    try
                    {

                        #region Rezervasyon Ekleme
                        int kisiId = (from c in _db.Customers
                                      where c.FirstName == kisi.FirstName
                                      select c.CustomerID
                                    ).First();

                        Reservation reservation = new Reservation();

                        reservation.CustomerID = kisiId;
                        reservation.NumberOfAccomodation = lblToplamKisiSayisi.Text;
                        reservation.Price = Convert.ToDecimal(lblToplamUcret.Text);
                        reservation.ReleaseDate = Convert.ToDateTime(lblCikisTarihi.Text);
                        reservation.EntryDate = Convert.ToDateTime(lblGirisTarihi.Text);
                        reservation.IsActive = true;
                        reservation.CreatedByID = kullanici.KullaniciID;
                        reservation.CreatedDate = DateTime.Now;
                        _db.Reservations.Add(reservation);

                        _db.SaveChanges();
                        #endregion

                        #region Konuk ve Rezervasyon Detayları Ekleme

                        int odaNumaralariIndis = 0;

                        int rezervasyonID = (from r in _db.Reservations
                                             orderby r.ReservationID descending
                                             select r.ReservationID).First();
                        for (int j = 0; j < misafirAdlari.Count; j++)
                        {
                            if (misafirAdlari[j] == "-")
                            {

                                odaNumaralariIndis++;
                                continue;
                            }
                            Guest guest = new Guest();
                            guest.FirstName = misafirAdlari[j];
                            guest.LastName = misafirSoyadlari[j];
                            _db.Guests.Add(guest);
                            _db.SaveChanges();

                            ReservationDetail reservationDetail = new ReservationDetail();

                            reservationDetail.GuestID = (from g in _db.Guests
                                                         orderby g.GuestID descending
                                                         select g.GuestID).First();
                            reservationDetail.RoomID = int.Parse(odaNumaralari[odaNumaralariIndis]);
                            reservationDetail.ReservationID = rezervasyonID;
                            _db.ReservationDetails.Add(reservationDetail);
                            _db.SaveChanges();
                        }
                        
                        #endregion
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bir Hata oluştu!");
                        transaction.Rollback();
                    }
                    MessageBox.Show("Rezervasyon İşlemi Başarı ile Tamamlandı !");
                    transaction.Commit();
                }
            }
            


        }


        private void btnKonukEkle_Click(object sender, EventArgs e)
        {
            frmKonukEkle frmKonukEkle = new frmKonukEkle(rezervasyonOzet, kisi , kullanici);

            frmKonukEkle.Show();
            this.Close();

        }

    }
}
