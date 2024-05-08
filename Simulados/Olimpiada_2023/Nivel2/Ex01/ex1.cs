using System;

class Ex01
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a área do imóvel que deseja comprar:");
        double area = double.Parse(Console.ReadLine());

        double IPTU = 12*26.5;
        Console.WriteLine("O valor do IPTU fica em: {0} pratas", Math.Round(IPTU, 2));
    }
}