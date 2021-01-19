using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri adı soyadı :"+musteri.MusteriAdi+" "+musteri.MusteriSoyadi);
            Console.WriteLine("Müşteri numarası :"+musteri.MusteriID);
        }
        public void Ekle(Musteri musteri)
        {
            int x = 21796277;
            Console.WriteLine("Müşteri adı soyadı giriniz:");
            Console.ReadLine();
            x = x + 1;
            Console.WriteLine("Müşteri numarası :" + x);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteriyi Silmek istediğinize emin misiniz? (e / h)");
            if (Console.ReadLine() == "e")
            {
                Console.WriteLine("Müşteri sistemden silindi!");
            }
            else
            {
                Console.WriteLine("Müşteriyi sistemden silme işlemi iptal edildi!");
            }
        }
    }
}
