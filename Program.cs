using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Beyzanur";
            musteri1.MusteriSoyadi = "Çilekci";
            musteri1.Mail= "bc@gmail.com";


            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Zeynep";
            musteri2.MusteriSoyadi = "Çilekci";
            musteri2.Mail = "zc@gmail.com";

            Musteri[] musteriler = { musteri1, musteri2 };


            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Ekleme İşlemi Simülasyonu");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("-----------------");
            Console.WriteLine("Listeleme İşlemi Simülasyonu");
            musteriManager.Listele(musteriler);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Silme İşlemi Simülasyonu");
            musteriManager.Silme(musteri2);


            Console.ReadKey();
        }
    }
}
