using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_HABITANTES = 20;
        double SomatorioSalario = 0;
        int SomatorioFilhos = 0;
        double MaiorSalario = 0;

        for (int contador = 1; contador <= NUMERO_HABITANTES; contador++)
        {
            Console.WriteLine("Digite o salário do " + contador + "° habitante:");
            double SalarioHabitanteAtual = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de fihos do " + contador + "° habitante:");
            int FilhosHabAtual = int.Parse(Console.ReadLine());

            SomatorioSalario = SomatorioSalario + SalarioHabitanteAtual;
            SomatorioFilhos = SomatorioFilhos + FilhosHabAtual;

            if (SalarioHabitanteAtual > MaiorSalario)
            {
                MaiorSalario = SalarioHabitanteAtual;
            }
        }
        double MediaSalarial = SomatorioSalario / NUMERO_HABITANTES;
        int MediaFilhos = SomatorioFilhos / NUMERO_HABITANTES;

        Console.WriteLine("A média salarial é: R$ " + Math.Round(MediaSalarial, 2));
        Console.WriteLine("A média do número de filhos por habitante é: " + MediaFilhos);
        Console.WriteLine("O maior salário é de: R$ " + Math.Round(MaiorSalario, 2));
    }
}