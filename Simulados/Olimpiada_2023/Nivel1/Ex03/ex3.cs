using System;

class Ex03
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua altura:");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu peso:");
        double peso = double.Parse(Console.ReadLine());

        double imc = peso / (altura*altura);

        if(imc < 18.5)
        {
            Console.Write("Magreza");
        }
        if(imc >= 18.5 && imc <= 24.9)
        {
            Console.Write("Normal");
        }
        if(imc >= 25.0 && imc <= 29.9)
        {
            Console.Write("Sobrepeso");
        }
        if(imc >= 30.0 && imc <= 39.9)
        {
            Console.Write("Obesidade");
        }
        if(imc > 40.0)
        {
            Console.Write("Obesidade grave");
        }
    }
}