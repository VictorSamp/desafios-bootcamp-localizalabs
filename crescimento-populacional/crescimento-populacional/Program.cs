using System;
using System.Globalization;

namespace crescimento_populacional
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int pa, pb;
                int anos = 0;
                double cpa, cpb;

                string[] valores = Console.ReadLine().Split(' ');
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);
                cpa = double.Parse(valores[2], CultureInfo.InvariantCulture);
                cpb = double.Parse(valores[3], CultureInfo.InvariantCulture);

                while (pa <= pb)
                {
                    pa += (int)Math.Floor(pa * (cpa / 100));
                    pb += (int)Math.Floor(pb * (cpb / 100));
                    anos++;

                    if (anos > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }
                }

                if (anos <= 100)
                {
                    Console.WriteLine($"{anos} anos.");
                }
            }
        }
    }
}
