using System;

class Ex08
{
    static void Main(string[] args)
    {
        int somatorio = 0;
        Console.WriteLine("Digite um número para saber a soma de todos os impares de 0 até ele:");
        int numero = int.Parse(Console.ReadLine());

        for(int i = 0; i <= numero; i++)
        {
            if(i % 2 != 0)
            {
                somatorio += i;
            }
        }
        Console.WriteLine("A soma total dos impares de 0 até {0} é: {1}", numero, somatorio);
    }
}