using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriName = "Mayıncı";
            musteri1.MusteriLastName = "Ömer";
            musteri1.MusteriPhoneNumber = "+900548474";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriName = "Aziz";
            musteri2.MusteriLastName = "Erçin";
            musteri2.MusteriPhoneNumber = "5556598747";

           

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            Console.WriteLine("------------Müşteri Listeleri Aşağıdaki Gibidir----------------" );

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var item in musteriler)
            {
                Console.WriteLine(item.MusteriName + " "+ item.MusteriLastName + ", " + item.MusteriPhoneNumber);
            }
            Console.WriteLine("------------------------");
            musterimanager.Sil();

        }



    }
}
