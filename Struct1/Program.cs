namespace Struct1
{
    using System;

    struct Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Time(int hour, int minute)
        {
            Hour = (hour >= 0 && hour < 24) ? hour : 0;
            Minute = (minute >= 0 && minute < 60) ? minute : 0;
        }

        public int TotalMinutes()
        {
            return (Hour * 60) + Minute;
        }

        public static int DifferenceInMinutes(Time t1, Time t2)
        {
            return Math.Abs(t1.TotalMinutes() - t2.TotalMinutes());
        }

        public override string ToString()
        {
            return $"{Hour:D2}:{Minute:D2}";
        }
    }

    class Program
    {
        static void Main()
        {
            Time t1 = new Time(14, 30);
            Time t2 = new Time(16, 15);
            Console.WriteLine($"Zaman 1: {t1}");
            Console.WriteLine($"Zaman 2: {t2}");
            Console.WriteLine($"Toplam Dakika: {t1.TotalMinutes()}");
            Console.WriteLine($"İki zaman arasındaki fark: {Time.DifferenceInMinutes(t1, t2)} dakika");
        }
    }

}
