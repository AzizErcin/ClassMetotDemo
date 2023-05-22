using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi  : " + musteri.MusteriName, ":" + musteri.MusteriLastName);
        }
        public void Sil()

        {
            
            Console.WriteLine("Müşteri Başarıyla Silindi");
        }

     
        
        
           
        
    }
}
