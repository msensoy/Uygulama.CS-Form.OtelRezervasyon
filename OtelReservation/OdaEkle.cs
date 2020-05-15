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
    public partial class frmOdaEkle : Form
    {
        public frmOdaEkle()
        {
            InitializeComponent();
        }
        OtelRezervasyonDBEntities _db = new OtelRezervasyonDBEntities();
        private void frmOdaEkle_Load(object sender, EventArgs e)
        {
            #region Oda Türleri db den comboboxa basılıyor
            var odaTurleri = (from r in _db.RoomDetails select r.RoomType).ToList();
            cmbOdaTurleri.DataSource = odaTurleri;
            cmbOdaTurleri.Text = "Oda Türü Seçiniz";
            #endregion
        }

        string _secilenKategoori;

        private void btnOdaKaydet_Click(object sender, EventArgs e)
        {
            Room oda = new Room();
            oda.RoomNumber = Convert.ToInt32(txtOdaNo.Text);
            if(_db.Rooms.Any(x=>x.RoomNumber == oda.RoomNumber))
            {
                MessageBox.Show("Bu oda numarası zaten eklenmişti!");
                return;
            }
            var roomDetailID = (from rd in _db.RoomDetails where rd.RoomType == cmbOdaTurleri.SelectedItem.ToString() select rd.RoomDetailID).First();
            oda.RoomDetailID = roomDetailID;

            _db.Rooms.Add(oda);

            try
            {
                _db.SaveChanges();
                MessageBox.Show("Oda başarılı bir şekilde eklendi.");
            }
            catch (Exception)
            {

                MessageBox.Show("Oda bilgisi eklenemedi!");
            }
        }

        private void cmbOdaTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            _secilenKategoori = cmbOdaTurleri.SelectedItem.ToString();
            lblOdaKapasite.Text = "";
            var odaKapasitesi = (from rd in _db.RoomDetails
                                 join ro in _db.Rooms on rd.RoomDetailID equals ro.RoomDetailID
                                 where rd.RoomType == cmbOdaTurleri.SelectedItem.ToString()
                                 select rd.RoomCapacity
                              ).FirstOrDefault();

            lblOdaKapasite.Text = odaKapasitesi.ToString();
        }
    }
}
