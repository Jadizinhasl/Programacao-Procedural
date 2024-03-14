using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite algum número que deseja converter para real(is) e centavo(s)");
        int numero = int.Parse(Console.ReadLine());

        int real = numero / 100;
        int centavos = numero % 100;

        Console.WriteLine("O total em dinheiro é: " + real + " real(is) e " + centavos + " centavo(s)");
    }
}