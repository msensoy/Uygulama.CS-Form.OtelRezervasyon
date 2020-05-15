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
    public partial class frmAnasayfa : Form
    {
        ClassUser kullanici;
        public frmAnasayfa(ClassUser kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            frmRezervasyon frmRezervasyon = new frmRezervasyon(kullanici);
            frmRezervasyon.Show();
            this.Hide();
        }

        private void btnRezervasyonGoruntule_Click(object sender, EventArgs e)
        {
            frmRezervasyonBilgileri frmRezervasyonBilgileri = new frmRezervasyonBilgileri();
            frmRezervasyonBilgileri.ShowDialog();
           
        }

        private void BtnOdaEkle_Click(object sender, EventArgs e)
        {
            frmOdaEkle frmOdaEkle = new frmOdaEkle();
            frmOdaEkle.ShowDialog();
          
        }
    }
}
