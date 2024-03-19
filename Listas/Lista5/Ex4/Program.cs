using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;

        do 
        {
            int NuInteiro = int.Parse(Console.ReadLine());

            if (NuInteiro < 0)
            {
                break;
            }
            else if (NuInteiro > 0)
            {
                if (NuInteiro % 2 != 0)
                {
                    soma += NuInteiro;
                }
            }
        }
        while(true);

        Console.WriteLine($"O somatorio de impares eh: {soma}");
    }
}