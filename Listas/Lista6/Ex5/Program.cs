using System;

class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        int[] inteiros = new int[10];

        while (contador < 10)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 50)
            {
                inteiros[contador] = numero;
                contador++;
            }
        }
        for (contador = 0; contador < 10; contador++)
        {
            Console.WriteLine(inteiros[contador]);
        }
    }
}
