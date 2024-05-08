using System;

class Ex01
{
    static void Main(string[] args)
    {
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());

        Console.WriteLine(FormulaHipotenusa(n1, n2));
    }

    static double FormulaHipotenusa(double n1, double n2)
    {
        return Math.Sqrt(Math.Pow(n1, 2) + Math.Pow(n2, 2));
    }
}