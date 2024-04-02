using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vagao = new int[12];

        PreencherVetor(vagao);
        VerificarToneladas(vagao);
    }

    static void PreencherVetor(int[] vagao)
    {
        for(int contador = 0; contador < vagao.Length; contador++)
        {
            vagao[contador] = int.Parse(Console.ReadLine());
        }
    }

    static void VerificarToneladas(int[] vagao)
    {
        for(int contador = 0; contador < vagao.Length; contador++)
        {
            if(vagao[contador] > 50)
            {
                Console.WriteLine($"{contador + 1}° vagão ultrapassou o limite de peso");
            }
        }
    }
}