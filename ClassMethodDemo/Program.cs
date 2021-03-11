using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ahmet";
            musteri1.SoyAdi = "Batman";
            musteri1.TcNo = "12345678910";
            musteri1.CepTelefonu = 544123456;
            musteri1.DogumTarihi = 1960;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Hayati";
            musteri2.SoyAdi = "İnanç";
            musteri2.TcNo = "98765432101";
            musteri2.CepTelefonu = 544654321;
            musteri2.DogumTarihi = 1950;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Halit";
            musteri3.SoyAdi = "Ertuğrul";
            musteri3.TcNo = "56789012341";
            musteri3.CepTelefonu = 544231456;
            musteri3.DogumTarihi = 1955;            

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri1);
            Console.WriteLine("-------------------------*");




            //for (int i = 0; i < musteriler.Length; i++)
            //{
            //  musteriManager.Listele(musteriler[i]);
            //}


            //foreach (Musteri musteri in musteriler)
            //{
            //Console.WriteLine(musteri.Id);
            //Console.WriteLine(musteri.Adi);
            //Console.WriteLine(musteri.SoyAdi);
            //Console.WriteLine(musteri.TcNo);
            //Console.WriteLine(musteri.CepTelefonu);
            //Console.WriteLine(musteri.DogumTarihi);
            //Console.WriteLine("--------------------");
            //}
        }
    }
}
