using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número que seja par:");
        int numero = int.Parse(Console.ReadLine());

        if(ehPar(numero))
        {
            Console.WriteLine("Verdadeiro! O número é par");
        }
        else
        {
            Console.WriteLine("Falso! Não é par");
        }
    }

     static bool ehPar(int numero)
    {
        return numero % 2 == 0;
    }
}