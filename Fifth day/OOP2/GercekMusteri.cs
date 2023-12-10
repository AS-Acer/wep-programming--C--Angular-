using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //individual
    //inheritance-miras alma
    //musterideki özellikler artık miras alınan class da da var
    public class GercekMusteri : Musteri
    {
        public int Id { get; set; }
        public int MusteriNo { get; set; }
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
