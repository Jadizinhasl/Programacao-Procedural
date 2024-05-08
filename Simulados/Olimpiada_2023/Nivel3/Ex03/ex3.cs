using System;

class Ex03
{
    static void Main(string[] args)
    {
        string[] vagao = new string[12];
        for (int i = 0; i < 12; i++)
        {
            if(i % 2 == 0 && i < 6)
            {
                vagao[i] = "{leve}";
            }
            if(i % 2 == 0 && i >= 6)
            {
                vagao[i] = "{pesada}";
            }
            if(i % 2 != 0 && i < 6)
            {
                vagao[i] = "{frágil}";
            }
            if(i % 2 != 0 && i > 6)
            {
                vagao[i] = "{perigosa}";
            }
            Console.Write(vagao[i]);
        }
    }
}