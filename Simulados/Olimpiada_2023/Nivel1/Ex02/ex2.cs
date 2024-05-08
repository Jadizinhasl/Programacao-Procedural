using System;

class Ex02
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a palavra para ficar com eco:");
        string palavra = Console.ReadLine();

        Console.WriteLine("{0}...{1}...{2}...", palavra, palavra, palavra);
    }
}