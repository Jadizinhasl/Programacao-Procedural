using System;

class Ex02
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite cordenadas do ponto A");
        double ax = double.Parse(Console.ReadLine()); 
        double ay = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite cordenadas do ponto B");
        double bx = double.Parse(Console.ReadLine());
        double by = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Round(Distancia(ax, bx, ay, by), 9));
    }

    static double Distancia(double ax, double ay, double bx, double by)
    {
        return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
    }
}