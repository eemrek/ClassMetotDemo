using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        public static MusteriManager MusteriManager { get; private set; }

        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Emre";
            musteri1.MusteriId = 1;
            musteri1.MusteriDogumyeri = "Malatya";
            musteri1.MusteriYas = 19;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Enes";
            musteri2.MusteriId = 2;
            musteri2.MusteriDogumyeri = "Kayseri";
            musteri2.MusteriYas = 17;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Halil";
            musteri3.MusteriId = 3;
            musteri3.MusteriDogumyeri = "Mersin";
            musteri3.MusteriYas = 20;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriAdi = "Mahmut";
            musteri4.MusteriId = 4;
            musteri4.MusteriDogumyeri = "Istanbul";
            musteri4.MusteriYas = 19;

            List<Musteri> Musteriler = new List<Musteri> { musteri1, musteri2, musteri3, musteri4 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle();
            musteriManager.Sil();
            musteriManager.Listele(Musteriler);


        }
    }
}
