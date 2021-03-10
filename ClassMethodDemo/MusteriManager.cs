using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Ekleme Başarılı! : " + musteri.Adi + musteri.SoyAdi);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler Listelendi! : " + musteri.Adi + musteri.SoyAdi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi!:" + musteri.Adi + musteri.SoyAdi);
        }
    }
}
