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
    public partial class frmKonukEkle : Form
    {
         OtelRezervasyonDBEntities _db = new  OtelRezervasyonDBEntities();
        public RezervasyonOzet rezervasyonOzet;
        Customer kisi;


        public frmKonukEkle(RezervasyonOzet rezervasyonOzet, Customer kisi, ClassUser kullanici) 
        {
            InitializeComponent();
            this.rezervasyonOzet = rezervasyonOzet;
            this.kisi = kisi;
            this.kullanici = kullanici;
        }

        private void frmKonukEkle_Load(object sender, EventArgs e)
        {
            lstOdaNo.DataSource = rezervasyonOzet.SecilenOdaNumaralari.ToList();



        }




        List<string> misafirAdlari = new List<string>();
        List<string> misafirSoyadlari = new List<string>();
        List<string> odaNumaralari = new List<string>();
        private ClassUser kullanici;

        private void btnMisafirleriKaydet_Click(object sender, EventArgs e)
        {
            int eklenecekMisafirSayisi = rezervasyonOzet.MisafirSayisi;
            if (misafirAdlari.Count==0 || misafirSoyadlari.Count==0)
            {
                MessageBox.Show("Hiç konuk Eklemediniz!");
                return;
            }
            if (misafirAdlari.Count<eklenecekMisafirSayisi || misafirSoyadlari.Count < eklenecekMisafirSayisi)
            {
                MessageBox.Show("Eksik konuk eklediniz");
                return;
            }

            frmRezervasyonTamamla frmRezervasyonTamamla = new frmRezervasyonTamamla(rezervasyonOzet, misafirAdlari, misafirSoyadlari, odaNumaralari, kisi, kullanici);
            frmRezervasyonTamamla.Show();

            this.Close();
        }





        private void lstOdaNo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int secilenOdaNo = int.Parse(lstOdaNo.SelectedItem.ToString());
            short secilenOdaninKapasitesi = (from r in _db.Rooms
                                             join rd in _db.RoomDetails on r.RoomDetailID equals rd.RoomDetailID
                                             where r.RoomNumber == secilenOdaNo
                                             select rd.RoomCapacity).First();
            #region Label ve TextBox Uret

            flpMisafir.Controls.Clear();


            for (int i = 0; i < secilenOdaninKapasitesi; i++)
            {
                int left = flpMisafir.Left + 20;

                for (int j = 0; j < 2; j++)
                {
                    Label lbl = new Label();
                    if (j % 2 == 0) { lbl.Text = "Misafir Adı: "; }
                    else { lbl.Text = "Soyadı: "; }


                    TextBox txt = new TextBox();
                    if (j % 2 == 0) { txt.Tag = "Misafir Adı"; txt.Name = "ad" + (i + 1).ToString(); }
                    else { txt.Tag = "Misafir Soyadı"; txt.Name = "soyad" + (i + 1).ToString(); }

                    txt.Height = 50;
                    txt.Width = 100;

                    flpMisafir.Controls.Add(lbl);
                    flpMisafir.Controls.Add(txt);
                }



            }

            #endregion
        }

        private void btnMisafirleriEkle_Click(object sender, EventArgs e)
        {
            foreach (var item in flpMisafir.Controls)
            {


                if (item is TextBox)
                {
                  
                        if (((TextBox)item).Tag.ToString() == "Misafir Adı" && ((TextBox)item).Text!="")
                        {

                            misafirAdlari.Add(((TextBox)item).Text);


                        }
                        if (((TextBox)item).Tag.ToString() == "Misafir Soyadı" && ((TextBox)item).Text != "")
                        {
                            misafirSoyadlari.Add(((TextBox)item).Text);


                        }
                    
                        
                    
                }

            }
            odaNumaralari.Add(lstOdaNo.SelectedItem.ToString());
            misafirAdlari.Add("-");
            misafirSoyadlari.Add("-");
        }
    }
}
