using System;

class Program
{
    static void Main(string[] args)
    {
        int altura = int.Parse(Console.ReadLine());
        int bAse = int.Parse(Console.ReadLine());

        for (int coluna = 1; coluna <= altura; coluna++)
        {
            for (int linha = 1; linha <= bAse; linha++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
