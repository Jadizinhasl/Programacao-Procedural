using System;

class Ex02
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        for(int i = 0; i < 3; i++)
        {
            Console.Write("{0}...", nome);
        }
    }
}