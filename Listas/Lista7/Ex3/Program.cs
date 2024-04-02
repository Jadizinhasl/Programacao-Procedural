using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine($"Sua categoria é {ClassificarNadador(idade)}");
    }
    static string ClassificarNadador(int idade)
    {
        if(idade < 12)
        {
            return "Infantil";
        }
        else if(idade >= 12 && idade <= 14)
        {
            return "Juvenil A";
        }
        else if(idade >= 15 && idade <= 17)
        {
            return "Juvenil B";
        }
        else
        {
            return "Adulto";
        }
    }
}
