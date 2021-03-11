using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Ekleme Başarılı! : " + musteri.Adi +" "+ musteri.SoyAdi);
            Console.WriteLine("------------------------------");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.SoyAdi);
                Console.WriteLine(musteri.TcNo);
                Console.WriteLine(musteri.CepTelefonu);
                Console.WriteLine(musteri.DogumTarihi);
                Console.WriteLine("Müşteri Listelendi!");
                Console.WriteLine("------------------------------");
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi!:" + musteri.Adi +" "+ musteri.SoyAdi);
        }
    }
}
