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

        Console.WriteLine("A média do aluno é: " + Math.Round(media, 3));
    }
}
