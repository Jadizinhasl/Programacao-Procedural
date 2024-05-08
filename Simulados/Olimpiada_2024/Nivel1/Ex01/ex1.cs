using System;

class Ex01
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua alcunha(apelido):");
        string alcunha = Console.ReadLine();

        Console.WriteLine("{0} mais conhecido como: {1}", nome, alcunha);
    }
}