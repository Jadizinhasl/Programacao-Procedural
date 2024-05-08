using System;

class Ex01
{
    static void Main(string[] args)
    {
        double Tc = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:F1}", Fahrenheit(Tc));
    }
    static double Fahrenheit(Double c)
    {
        return ((9.0 / 5.0) * c) + 32;
    }
}