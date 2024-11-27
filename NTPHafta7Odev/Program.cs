namespace Overloading1
{
    using System;

    class MatematikIslemleri
    {
        // İki tam sayıyı toplar
        public int Topla(int a, int b)
        {
            return a + b;
        }

        // Üç tam sayıyı toplar
        public int Topla(int a, int b, int c)
        {
            return a + b + c;
        }

        // Bir dizi (array) tam sayıyı toplar
        public int Topla(int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }
    }

    class Program
    {
        static void Main()
        {
            MatematikIslemleri matematik = new MatematikIslemleri();

            Console.WriteLine(matematik.Topla(3, 5)); // Çıktı: 8
            Console.WriteLine(matematik.Topla(1, 2, 3)); // Çıktı: 6
            Console.WriteLine(matematik.Topla(new int[] { 1, 2, 3, 4 })); // Çıktı: 10
        }
    }

}
