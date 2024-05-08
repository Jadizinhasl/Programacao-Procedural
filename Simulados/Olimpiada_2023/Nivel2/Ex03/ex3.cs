using System;

class Ex03
{
    static void Main(string[] args)
    {
        double maiorSalario = 0;
        int somatorioFilhos = 0;
        double somatorioSalario = 0;

        for(int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Informe o salário do {0}° habitante:", i);
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de filhos do {0}° habitante:", i);
            int filho = int.Parse(Console.ReadLine());

            somatorioFilhos += filho;
            somatorioSalario += salario;

            if(salario > maiorSalario)
            {
                maiorSalario = salario;
            }
        }
        int mediaFilho = somatorioFilhos / 3;
        double mediaSalario = somatorioSalario / 3;

        Console.WriteLine("Média salarial: R$ {0}", Math.Round(mediaSalario, 2));
        Console.WriteLine("Média do número de filhos por habitante: {0}", mediaFilho);
        Console.WriteLine("Maior salário: R$ {0}", Math.Round(maiorSalario, 2));
    }
}