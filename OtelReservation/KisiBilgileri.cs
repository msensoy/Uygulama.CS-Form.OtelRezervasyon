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
    public partial class frmKisiBilgileri : Form
    {
        OtelRezervasyonDBEntities _db = new OtelRezervasyonDBEntities();
        public frmKisiBilgileri()
        {
            InitializeComponent();
        }

        private void KisiBilgileri_Load(object sender, EventArgs e)
        {
            dgvKisiListele.DataSource = _db.Customers.ToList();
        }
    }
}
