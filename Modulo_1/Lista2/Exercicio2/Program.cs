using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a nota de matemática");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota de Biologia");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota de Português");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota de Inglês");
        double nota4 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        if (media >= 5)
        {
            Console.WriteLine("Aluno aprovado");
        }
        else if (media < 5 && media >= 3)
        {
            Console.WriteLine("Aluno em recuperação");
        }
        else
        {
            Console.WriteLine("Aluno Reprovado");
        }
    }
}
   
        