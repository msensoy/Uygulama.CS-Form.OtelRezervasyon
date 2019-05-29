using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelReservation
{
    public class RezervasyonOzet
    {
        public int MisafirSayisi { get; set; }
        public HashSet<int> SecilenOdaNumaralari { get; set; }
        public double ToplamUcret { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
    }
}
