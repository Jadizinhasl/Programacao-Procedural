using System;

class Ex05
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o nome do usúario:");
        string nome = Console.ReadLine();

        Console.WriteLine("Insira a senha de login:");
        int senha = int.Parse(Console.ReadLine());

        if(nome == "admin" && senha == 123)
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Falha no login!");
        }
    }
}