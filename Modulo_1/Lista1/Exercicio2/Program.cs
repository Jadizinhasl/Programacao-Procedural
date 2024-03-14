using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe à altura do triangulo.");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe à base do triangulo.");
        double fundamento = double.Parse(Console.ReadLine());

        double area = (fundamento * altura) / 2;

        bool expressao = area > 20;

        Console.WriteLine("A área do triangulo é maior que 20?" + expressao);
    }
}