using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EntityLayer
{
    public class Personel
    {
        public Personel()
        {
            
        }
        public int PersonelId { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TCKimlikNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public int Birim { get; set; }
        //isiim ve soyismi görmek için oluşturuyoruz. Sadecevbilgiler getirilecek, o yüzden set metodunu kaldırdık. Db'de olmayacak.
        public string IsimSoyisim { get { return Isim + " " + Soyisim; } }

        // Navigation property
        public IletisimBilgileri IletisimBilgisi { get; set; }


    }
}
