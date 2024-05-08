using System;

class Ex03
{
    static void Main(string[] args)
    {
        double somatorio = 0;

        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine("Digite a {0}° nota do(a) aluno(a)", i);
            double n = double.Parse(Console.ReadLine());

            somatorio += n;
        }
        double media = somatorio / 4;

        if (media >= 5)
        {
            Console.WriteLine("Aluno(a) aprovado");
        }
        else if (media >= 3 && media < 5)
        {
            Console.WriteLine("Aluno(a) em recuperação");
        }
        else
        {
            Console.WriteLine("Aluno(a) reprovado");
        }
    }
}