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
  
    public partial class frmRezervasyonBilgileri : Form
    {
        public void DGVYukle()
        {

            var sorgu = (from rd in _db.ReservationDetails
                         join r in _db.Reservations on rd.ReservationID equals r.ReservationID
                         join c in _db.Customers on r.CustomerID equals c.CustomerID
                         join ro in _db.Rooms on rd.RoomID equals ro.RoomID
                         where r.IsActive == true
                         select new
                         {
                             rd.ReservationID,
                             ro.RoomNumber,
                             r.Price,
                             c.FirstName,
                             c.Lastname,
                             r.NumberOfAccomodation
                         }
                        );
            dgvReservations.DataSource = sorgu.ToList();
            dgvReservations.Columns[0].HeaderText = "Rezervasyon Numarası";
            dgvReservations.Columns[1].HeaderText = "Oda Numarası";
            dgvReservations.Columns[2].HeaderText = "Fiyatı";
            dgvReservations.Columns[3].HeaderText = "Adı";
            dgvReservations.Columns[4].HeaderText = "Soyadı";
            dgvReservations.Columns[5].HeaderText = "Kalacak Kişi Sayısı";
        }
        OtelRezervasyonDBEntities _db = new  OtelRezervasyonDBEntities();

        public frmRezervasyonBilgileri()
        {
            
            InitializeComponent();
          
        }

        public void frmRezervasyonBilgileri_Load(object sender, EventArgs e)
        {
            DGVYukle();

        }

        int dgvRezervasyonID = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvReservations.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dgvRezervasyonID = int.Parse(dgvReservations.SelectedCells[0].Value.ToString());

                var rezervasyon = (from r in _db.Reservations
                                   where r.ReservationID == dgvRezervasyonID
                                   select r).First();
              
                _db.Reservations.Where(x => x.ReservationID == dgvRezervasyonID).First().IsActive = false;
            }
            try
            {
                _db.SaveChanges();
                DGVYukle();
                MessageBox.Show("Silme işleminiz başarı ile gerçekleşti.");

            }
            catch (Exception ex)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _db.SaveChanges();

            }
            catch (Exception)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu");
            }
        }
    }
}
