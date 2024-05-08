using System;

class Ex03
{
    static void Main(string[] args)
    {
        Console.Write("Digite a altura da pirâmide: ");
        int altura = int.Parse(Console.ReadLine());

        for (int i = 1; i <= altura; i++)
        {
            for (int j = 1; j <= altura - i; j++)
            {
                Console.Write(" ");
            }
            for (int a = 1; a <= 2 * i - 1; a++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}