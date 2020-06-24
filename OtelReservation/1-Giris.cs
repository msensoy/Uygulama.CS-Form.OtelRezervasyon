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
    public partial class frmGiris : Form
    {
         OtelRezervasyonDBEntities _db = new  OtelRezervasyonDBEntities();
        
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var X = _db;

                var sorgu = _db.Users.Where(x => x.Username == txtKullaniciAdi.Text && x.Password == txtSifre.Text).FirstOrDefault();
                if (sorgu != null)
                {
                    ClassUser kullanici = new ClassUser();
                    kullanici.KullaniciID = sorgu.ReceptionistID;
                    kullanici.KullaniciAdi = sorgu.Username;

                    frmAnasayfa frmAnasayfa = new frmAnasayfa(kullanici);
                   // frmRezervasyon frmRezervasyon = new frmRezervasyon(kullanici);

                    frmAnasayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı / Şifre");
                }


            }
            catch (Exception EX)
            {

                MessageBox.Show("Bağlantı Hatası");;
            }
           

        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnGiris_Click(sender, e);
            }
        }
    }
}
