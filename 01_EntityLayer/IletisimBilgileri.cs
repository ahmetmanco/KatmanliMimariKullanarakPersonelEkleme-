using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EntityLayer
{
    public class IletisimBilgileri
    {
        public int PersonelId { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }


        public Personel Personel { get; set; }


    }
}
