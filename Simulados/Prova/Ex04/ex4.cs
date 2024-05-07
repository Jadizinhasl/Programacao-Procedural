using System;

class Ex04
{
    static void Main(string[] args)
    {
        Console.WriteLine("Me informe o total de centavos:");
        int moedas = int.Parse(Console.ReadLine());

        int real = moedas / 100;
        int centavos = moedas % 100;

        Console.WriteLine("O total em dinheiro É: {0} real(is) e {1} centavo(s)", real, centavos);
    }
}