namespace Struct2
{
    using System;

    struct ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public ComplexNumber Add(ComplexNumber other)
        {
            return new ComplexNumber(Real + other.Real, Imaginary + other.Imaginary);
        }

        public ComplexNumber Subtract(ComplexNumber other)
        {
            return new ComplexNumber(Real - other.Real, Imaginary - other.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }

    class Program
    {
        static void Main()
        {
            ComplexNumber c1 = new ComplexNumber(3, 4);
            ComplexNumber c2 = new ComplexNumber(1, 2);

            Console.WriteLine($"Karmaşık Sayı 1: {c1}");
            Console.WriteLine($"Karmaşık Sayı 2: {c2}");
            Console.WriteLine($"Toplam: {c1.Add(c2)}");
            Console.WriteLine($"Fark: {c1.Subtract(c2)}");
        }
    }

}
