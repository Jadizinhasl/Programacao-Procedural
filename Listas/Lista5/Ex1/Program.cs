using System;

class Program
{
    static void Main(string[] args)
    {
        int decrescente = 200;

         for (int crescente = 0; crescente <= 100; crescente += 2)
         {
            Console.WriteLine($"{crescente} - {decrescente}");
            decrescente-= 4;
         } 
    }
}
