using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite Filomena ou Joselito para saber sua rotina:");
        string nome = Console.ReadLine();

        if (nome == "Filomena")
        {
            Console.WriteLine("\nRotina de Filomena:\n1. Escola das 07h as 12h\n2. Almoço das 12h as 13h\n3. Futebol das 14h as 16h\n4. Dever de casa das 16h as 18h");
        }
        else if (nome == "Joselito")
        {
            Console.WriteLine("\nRotina de Joselito:\n1. Escola das 07h as 12:30h\n2. Almoço das 13h as 14h\n3. Natação das 14h as 16h\n4. Reforço escolar das 16h as 19h");
        }
    }
}
