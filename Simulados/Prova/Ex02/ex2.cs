using System;

class Ex02
{
    static void Main(string[] args)
    {
        double somatorio = 0;
        for(int i = 1; i <= 4; i++)
        {
            Console.WriteLine("Informe a {0}° nota do aluno(a):", i);
            double nota = double.Parse(Console.ReadLine());

            somatorio += nota;
        }
        double media = somatorio / 4;

        if(media >= 5)
        {
            Console.WriteLine("Aluno está aprovado!");
        }
        else
        {
            Console.WriteLine("Aluno está reprovado.");
        }
    }
}