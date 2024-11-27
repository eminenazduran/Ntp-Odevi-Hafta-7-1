namespace Overloading3
{
    using System;

    class TarihFarki
    {
        // Gün cinsinden farkı hesaplar
        public int GunFarkiHesapla(DateTime tarih1, DateTime tarih2)
        {
            return (tarih2 - tarih1).Days;
        }

        // Saat cinsinden farkı hesaplar
        public double SaatFarkiHesapla(DateTime tarih1, DateTime tarih2)
        {
            return (tarih2 - tarih1).TotalHours;
        }

        // Yıl, ay ve gün cinsinden farkı hesaplar
        public (int Yillar, int Aylar, int Gunler) DetayliFarkHesapla(DateTime tarih1, DateTime tarih2)
        {
            int yillar = tarih2.Year - tarih1.Year;
            int aylar = tarih2.Month - tarih1.Month;
            int gunler = tarih2.Day - tarih1.Day;

            if (gunler < 0)
            {
                aylar--;
                gunler += DateTime.DaysInMonth(tarih1.Year, tarih1.Month);
            }
            if (aylar < 0)
            {
                yillar--;
                aylar += 12;
            }

            return (yillar, aylar, gunler);
        }
    }

    class Program
    {
        static void Main()
        {
            TarihFarki tarihFark = new TarihFarki();
            DateTime baslangicTarihi = new DateTime(2023, 1, 1);
            DateTime bitisTarihi = new DateTime(2024, 11, 27);

            Console.WriteLine("Gün farkı: " + tarihFark.GunFarkiHesapla(baslangicTarihi, bitisTarihi)); // Çıktı: 696 (örnek)
            Console.WriteLine("Saat farkı: " + tarihFark.SaatFarkiHesapla(baslangicTarihi, bitisTarihi)); // Çıktı: 16704 (örnek)

            var detayliFark = tarihFark.DetayliFarkHesapla(baslangicTarihi, bitisTarihi);
            Console.WriteLine($"Yıl: {detayliFark.Yillar}, Ay: {detayliFark.Aylar}, Gün: {detayliFark.Gunler}");
            // Çıktı: Yıl: 1, Ay: 10, Gün: 26 (örnek)
        }
    }

}
