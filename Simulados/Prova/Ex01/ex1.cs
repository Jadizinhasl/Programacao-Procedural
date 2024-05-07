using System;

class ex1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Me informe sua altura:");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Agora, digite seu peso:");
        double peso = double.Parse(Console.ReadLine());

        double imc = peso / (altura*altura);
        Console.WriteLine("Seu imc é igual: {0}", Math.Round(imc, 2));
    }
}