namespace Struct3
{
    using System;

    struct GPSLocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public GPSLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double DistanceTo(GPSLocation other)
        {
            const double R = 6371; // Dünya'nın yarıçapı (km)
            double latDiff = ToRadians(other.Latitude - Latitude);
            double lonDiff = ToRadians(other.Longitude - Longitude);

            double a = Math.Sin(latDiff / 2) * Math.Sin(latDiff / 2) +
                       Math.Cos(ToRadians(Latitude)) * Math.Cos(ToRadians(other.Latitude)) *
                       Math.Sin(lonDiff / 2) * Math.Sin(lonDiff / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c; // Mesafe kilometre cinsinden
        }

        private static double ToRadians(double angle)
        {
            return angle * Math.PI / 180;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}";
        }
    }

    class Program
    {
        static void Main()
        {
            GPSLocation loc1 = new GPSLocation(39.92077, 32.85411); // Ankara
            GPSLocation loc2 = new GPSLocation(41.00824, 28.97836); // İstanbul

            Console.WriteLine($"Konum 1: {loc1}");
            Console.WriteLine($"Konum 2: {loc2}");
            Console.WriteLine($"İki konum arasındaki mesafe: {loc1.DistanceTo(loc2):F2} km");
        }
    }

}
