using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri() { MusteriAdi = "Ecem", MusteriSoyadi = "ünlü", MusteriID = 21796277 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteri);
            musteriManager.Ekle(musteri);
            musteriManager.Sil(musteri);
        }
    }
}
