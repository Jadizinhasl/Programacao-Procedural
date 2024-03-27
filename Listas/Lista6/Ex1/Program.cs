using System;

class Program
{
    static void Main(string[] args)
    {
        string pesquisado;
        string[] nomes = new string[10];

        for (int contador = 0; contador < 10; contador++)
        {
            nomes[contador] = Console.ReadLine();
        }

        bool temNome = false;
        pesquisado = Console.ReadLine();

        for (int contador = 0; contador < 10; contador++)
        {
            if (nomes[contador] == pesquisado)
            {
                temNome = true;
            }
        }
        if (temNome)
        {
            Console.WriteLine("ACHEI");
        }
        else
        {
            Console.WriteLine("NAO ACHEI");
        }
    }
}