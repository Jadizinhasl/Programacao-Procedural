using System;

class Ex01
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome");
        string sobrenome = Console.ReadLine();

        Console.WriteLine("Olá, {0} {1}", sobrenome, nome);
    }
}