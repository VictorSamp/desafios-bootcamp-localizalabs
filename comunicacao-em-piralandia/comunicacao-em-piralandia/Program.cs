using System;
using System.Linq;

namespace comunicacao_em_piralandia
{
    class Program
    {
        static void Main(string[] args)
        {

            string n = Console.ReadLine();

            string v = new string(n.Reverse().ToArray());

            Console.WriteLine(v);
        }
    }
}
