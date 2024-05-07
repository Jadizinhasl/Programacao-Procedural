using System;

class Ex07
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para saber todos os números pares de 0 até ele:");
        int numero = int.Parse(Console.ReadLine());

        for(int i = 0; i <= numero; i++)
        {
            if(i % 2 == 0)
            {
                Console.Write("{0}, ", i);
            }
        }
    }
}