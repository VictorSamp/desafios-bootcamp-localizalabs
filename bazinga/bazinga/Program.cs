using System;

namespace bazinga
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDeTestes;
            string[] valorEscolhido;
            string escolhaSheldon, escolhaRaj;

            quantidadeDeTestes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeDeTestes; i++)
            {
                valorEscolhido = Console.ReadLine().Split(' ');

                escolhaSheldon = valorEscolhido[0];
                escolhaRaj = valorEscolhido[1];

                if (escolhaSheldon == escolhaRaj)
                {
                    Console.WriteLine($"Caso #{i}: De novo!");
                }
                else
                {
                    if (escolhaSheldon == "tesoura" && (escolhaRaj == "papel" || escolhaRaj == "lagarto"))
                    {
                        Console.WriteLine($"Caso #{i}: Bazinga!");
                    }
                    if (escolhaSheldon == "papel" && (escolhaRaj == "pedra" || escolhaRaj == "Spock"))
                    {
                        Console.WriteLine($"Caso #{i}: Bazinga!");
                    }
                    if (escolhaSheldon == "pedra" && (escolhaRaj == "lagarto" || escolhaRaj == "tesoura"))
                    {
                        Console.WriteLine($"Caso #{i}: Bazinga!");
                    }
                    if (escolhaSheldon == "lagarto" && (escolhaRaj == "Spock" || escolhaRaj == "papel"))
                    {
                        Console.WriteLine($"Caso #{i}: Bazinga!");
                    }
                    if (escolhaSheldon == "Spock" && (escolhaRaj == "tesoura" || escolhaRaj == "pedra"))
                    {
                        Console.WriteLine($"Caso #{i}: Bazinga!");
                    }

                    if (escolhaRaj == "tesoura" && (escolhaSheldon == "papel" || escolhaSheldon == "lagarto"))
                    {
                        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
                    }
                    if (escolhaRaj == "papel" && (escolhaSheldon == "pedra" || escolhaSheldon == "Spock"))
                    {
                        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
                    }
                    if (escolhaRaj == "pedra" && (escolhaSheldon == "lagarto" || escolhaSheldon == "tesoura"))
                    {
                        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
                    }
                    if (escolhaRaj == "lagarto" && (escolhaSheldon == "Spock" || escolhaSheldon == "papel"))
                    {
                        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
                    }
                    if (escolhaRaj == "Spock" && (escolhaSheldon == "tesoura" || escolhaSheldon == "pedra"))
                    {
                        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
                    }
                }
            }
        }
    }
}
