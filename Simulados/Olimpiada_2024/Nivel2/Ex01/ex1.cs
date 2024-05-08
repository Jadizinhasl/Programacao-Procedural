using System;

class Ex01
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a quilometragem da expedição:");
        double quilometragem = double.Parse(Console.ReadLine());
        double preco = quilometragem*25;

        Console.WriteLine("O preço final da sua expedição é: {0} pratas", Math.Round(preco, 1));
    }
}