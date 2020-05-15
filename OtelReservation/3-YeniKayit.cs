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
    public partial class frmYeniKayit : Form
    {


        public frmYeniKayit(RezervasyonOzet rezervasyonOzet, ClassUser kullanici)
        {

            InitializeComponent();
            this.rezervasyonOzet = rezervasyonOzet;
            this.kullanici = kullanici;
            cmbUyruk.Items.Add("TR");
            cmbUyruk.Items.Add("DİĞER");
            cmbUyruk.Text = "TR";
        }

        OtelRezervasyonDBEntities _db = new OtelRezervasyonDBEntities();

        public RezervasyonOzet rezervasyonOzet;
        private ClassUser kullanici;

        private void cmbUyruk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUyruk.Text == "TR")
            {
                lblUyruk.Text = "TC";

            }
            else { lblUyruk.Text = "PASAPORT NO"; }
        }

        private void txtTcveyaPasaportNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            Customer kisi = new Customer();

            #region sartlar

            if (txtAd.Text == "" || txtSoyad.Text == "") { MessageBox.Show("Ad ve Soyad Alanı Boş Geçilemez"); return; }
            if (mstTelefon.Text == "") { MessageBox.Show("Telefon Alanı Boş Bırakılamaz"); return; }


            #endregion

            #region uyruk secimi
            if (cmbUyruk.Text == "TR")
            {
                if (txtTcveyaPasaportNo.TextLength != 11)
                { MessageBox.Show("TC No Hatalı"); return; }
                kisi.TcKimlik = txtTcveyaPasaportNo.Text;
            }

            else
            {
                if (txtTcveyaPasaportNo.TextLength != 9)
                { MessageBox.Show("Pasaport No Hatalı ! \nEksik yada Fazla Rakam Girdiniz"); return; }
                kisi.PasaportNo = txtTcveyaPasaportNo.Text;
            }
            #endregion

            #region cinsiyet secimi 

            if (rbKadin.Checked)
            {
                kisi.Gender = (int)Helpers.Gender.kadin;
            }
            else if (rbErkek.Checked)
            {
                kisi.Gender = (int)Helpers.Gender.erkek;
            }
            else
            {
                kisi.Gender = (int)Helpers.Gender.diger;
            }
            #endregion

            #region atamalar

            kisi.FirstName = txtAd.Text;
            kisi.Lastname = txtSoyad.Text;
            kisi.PhoneNumber = mstTelefon.Text;

            if (Helpers.IsValidEmail(txtEPosta.Text))
            {
                kisi.E_Mail = txtEPosta.Text;
            }
            else
            {
                MessageBox.Show("Hatalı email!!");
                return;
            }

            #endregion

            #region KullaniciAdiKontrolü

            #endregion

            #region son asama try-catch
            try
            {
                _db.Customers.Add(kisi);
                _db.SaveChanges();
                frmRezervasyonTamamla frmRezervasyonTamamla1 = new frmRezervasyonTamamla(kisi, rezervasyonOzet, kullanici);
                this.Hide();

                frmRezervasyonTamamla1.ShowDialog();

                //ekranı temizle()
                Helpers.ContainerClear(grbKisiBilgileri);
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Hata , Kayıt Yapılamadı!"); ;
            }
            #endregion



        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Helpers.ContainerClear(grbKisiBilgileri);
        }


        private void txtTcveyaPasaportNo_TextChanged(object sender, EventArgs e)
        {
            if (lblUyruk.Text == "TC")
            {
                if (txtTcveyaPasaportNo.TextLength == 11)
                {
                    var sorgu = (from c in _db.Customers
                                 where c.TcKimlik == txtTcveyaPasaportNo.Text
                                 select c).FirstOrDefault();
                    if (sorgu != null)
                    {
                        MessageBox.Show("Bu kişi zaten kayıtlı!");
                        txtAd.Text = sorgu.FirstName;
                        txtSoyad.Text = sorgu.Lastname;
                        txtEPosta.Text = sorgu.E_Mail;
                        if (sorgu.Gender == 1) { rbErkek.Checked = true; }
                        else if (sorgu.Gender == 2) { rbKadin.Checked = true; }
                        mstTelefon.Text = sorgu.PhoneNumber;
                        btnKisiGuncelle.Visible = true;

                    }
                }
            }

        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {


            string yeniAd = txtAd.Text;
            string yeniSoyad = txtSoyad.Text;
            string yeniTelefonNo = mstTelefon.Text;
            string yeniEposta = txtEPosta.Text;
            var sorgu = (from c in _db.Customers
                         where c.TcKimlik == txtTcveyaPasaportNo.Text
                         select c).FirstOrDefault();
            int gender;
            if (rbErkek.Checked) gender = 1;
            else if (rbKadin.Checked) gender = 0;
            else { gender = 2; }

            try
            {
                sorgu.FirstName = yeniAd;
                sorgu.Lastname = yeniSoyad;
                sorgu.PhoneNumber = yeniTelefonNo;
                sorgu.E_Mail = yeniEposta;
                sorgu.Gender = gender;
                _db.SaveChanges();
                MessageBox.Show("Güncellendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!! Güncellenemedi");
            }
        }

        private void frmYeniKayit_Load(object sender, EventArgs e)
        {
            btnKisiGuncelle.Visible = false;
        }
    }
}

