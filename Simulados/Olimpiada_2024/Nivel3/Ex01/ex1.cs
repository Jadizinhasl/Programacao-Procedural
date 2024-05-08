using System;

class Ex01
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o total de dias:");
        int dia = int.Parse(Console.ReadLine());
        int anos = dia / 365;

        Console.WriteLine("\nEssa pessoa viveu {0:F0} ano(s)", anos);
    }
}