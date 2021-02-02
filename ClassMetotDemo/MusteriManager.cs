using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       
       
       

         internal void Ekle()
        {
            Console.WriteLine("Yeni müşteri başarıyla eklendi.");
        }

        internal void Sil()
        {
            Console.WriteLine("Müşteri silindi.");
        }

        internal void Listele(List<Musteri> Musteriler)
        {
            foreach (var musteri in Musteriler)
            {
                Console.Write(musteri.MusteriId + "--"); Console.Write(musteri.MusteriAdi + "--"); 
                Console.Write(musteri.MusteriDogumyeri + "--"); Console.Write(musteri.MusteriYas + "--" );
                Console.WriteLine("---------------------------");
            }
        }
    }
}
