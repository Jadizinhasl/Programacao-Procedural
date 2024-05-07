using System;

class Ex03
{
    static void Main(string[] args)
    {
        Console.WriteLine("Me informe o período para a busca dos remédios:");
        string periodo = Console.ReadLine();

        if(periodo == "noite" || periodo == "Noite")
        {
            Console.WriteLine("Remédio C");
        }
        if(periodo == "tarde" || periodo == "Tarde")
        {
            Console.WriteLine("Remédio B");
        }
        if(periodo == "manha" || periodo == "Manha")
        {
            Console.WriteLine("Remédio A");
        }
    }
}