using System;

class Ex02
{
    static void Main(string[] args)
    {
        double salarioSemanal = 600.0;

        Console.WriteLine("Informe o total de horas trabalhas:");
        double horas = double.Parse(Console.ReadLine());

        if (horas == 40)
        {
            Console.WriteLine("Você tem para receber: R$ {0}", salarioSemanal);
        }
        else if (horas > 40)
        {
            double valor = (horas - 40) * 25;
            salarioSemanal += valor;

            Console.WriteLine("Você tem para receber: R$ {0}", salarioSemanal);
        }
    }
}