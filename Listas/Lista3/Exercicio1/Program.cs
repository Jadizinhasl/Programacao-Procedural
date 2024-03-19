using System;

class Program
{
    static void Main(string[] args)
    {
        const int QT_NUMEROS = 10;
		int positivo = 0;
		int negativo = 0;
		int zero = 0;
			
		for (int contador = 0; contador < QT_NUMEROS; contador++)
		{
			int numero = int.Parse(Console.ReadLine());
			if (numero > 0)
			{
			    positvo++;
			}
			else if(numero < 0)
			{
			    negativo++;
			}
			else
			{
			    zero++;
			}
		}
		Console.WriteLine("Numeros positivos:"+ positivo);
		Console.WriteLine("Numeros negativos:"+ negativo);
		Console.WriteLine("Zero(s):"+ zero);
    }
}