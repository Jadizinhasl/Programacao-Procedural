using System;

class Program
{
    static void Main(string[] agrs)
    {
        for (int fator = 1; fator <= 10; fator++)
        {
            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(fator + " X " + contador + " = " + fator * contador);
            }
            Console.WriteLine();
        }
    }
}
