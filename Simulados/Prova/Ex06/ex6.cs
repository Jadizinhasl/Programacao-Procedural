using System;

class Ex06
{
    static void Main(string[] args)
    {
        double somatorio = 0;
        double maiorAltura = 0;
        for(int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Me infome a altura do {0}° jogador:", i);
            double altura = double.Parse(Console.ReadLine());

            somatorio += altura;
            if(altura > maiorAltura)
            {
                maiorAltura = altura;
            }
        }
        double media = somatorio / 5;
        Console.WriteLine("A altura media do time é: {0}", Math.Round(media, 2));
        Console.WriteLine("A maior altura é: {0}", maiorAltura);
    }
}