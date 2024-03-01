using System;

class Program
{
    static void Main(string[] args)
{
    Console.WriteLine("Digite o nome de usuario");
    string nomeUsuario = Console.ReadLine();

    Console.WriteLine("Digite sua senha");
    string senha = Console.ReadLine();

    if (nomeUsuario == "Juca" && senha == "123senha")
    {
        Console.WriteLine("Login realizado com sucesso!");
    } 
    else
    {
        Console.WriteLine("Credenciais inválidas..");
    }
}
}
