using System;

class Ex01
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro positivo:");
        int limite = int.Parse(Console.ReadLine());

        if (limite > 0)
        {
            ExibirFibonacci(limite);
        }
        else
        {
            Console.WriteLine("O número deve ser positivo.");
        }
    }
    static void ExibirFibonacci(int limite)
    {
        int a = 0, b = 1, proximo;
        Console.Write(a + " " + b + " ");

        while (b < limite)
        {
            proximo = a + b;
            Console.Write(proximo + " ");
            a = b;
            b = proximo;
        }
    }
}