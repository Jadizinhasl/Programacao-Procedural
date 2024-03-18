using System;

class Program
{
    static void Main(string[] args)
    {
        int Soma = 0;

        do 
        {
            int NuInteiro = int.Parse(Console.ReadLine());

            if (NuInteiro < 0)
            {
                break;
            }
            Soma += NuInteiro;
        }
        while(true);

        Console.WriteLine($"O somatorio de impares eh: {Soma}");
    }
}
