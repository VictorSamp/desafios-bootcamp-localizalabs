using System;
using System.Globalization;

namespace media_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double media;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media = (A * 3.5 + B * 7.5) / 11;
            Console.WriteLine("MEDIA = {0}", media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
