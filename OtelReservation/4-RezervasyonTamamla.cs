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
            using (OtelRezervasyonDBEntities _db = new OtelRezervasyonDBEntities())
            {
                using (var transaction = _db.Database.BeginTransaction())
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

                        ReservationDetail reservationDetail = new ReservationDetail();
                        Guest guest = new Guest();

                        guest.FirstName = "null";
                        guest.LastName = "null";
                        _db.Guests.Add(guest);
                        _db.SaveChanges();


                        int guestID = (from r in _db.Guests
                                       orderby r.GuestID descending
                                       select r.GuestID).FirstOrDefault();

                        for (int i = 0; i < rezervasyonOzet.SecilenOdaNumaralari.Count; i++)
                        {
                            int odaNumara = rezervasyonOzet.SecilenOdaNumaralari.ToList()[i];
                            int roomID = (from r in _db.Rooms
                                          where r.RoomNumber == odaNumara
                                          select r.RoomID).First();
                            reservationDetail.GuestID = guestID;
                            reservationDetail.RoomID = roomID;
                            reservationDetail.ReservationID = rezervasyonID;
                            _db.ReservationDetails.Add(reservationDetail);
                            _db.SaveChanges();
                        }

                        #endregion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir Hata oluştu!");
                        transaction.Rollback();
                    }
                    transaction.Commit();
                    MessageBox.Show("Rezervasyon İşlemi Başarı ile Tamamlandı !");
                    this.Close();
                }
            }



        }


        private void btnKonukEkle_Click(object sender, EventArgs e)
        {
            frmKonukEkle frmKonukEkle = new frmKonukEkle(rezervasyonOzet, kisi, kullanici);

            frmKonukEkle.Show();
            this.Close();

        }

    }
}
