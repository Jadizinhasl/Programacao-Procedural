using System;

class Program
{
    static void Main(string[] args)
    {
        for (int fator1 = 10; fator1 >= 1; fator1--)
        {
            for (int fator2 = 1; fator2 <= 10; fator2++)
            {
                Console.WriteLine($"{fator1} X {fator2} = {fator1 * fator2}");
            }
            Console.WriteLine();
        }
    }
}