using System;

class Ex02
{
    static void Main(string[] args)
    {
        bool[,] estacionamento = new bool[5, 5];

        PreencherMatriz(estacionamento);

        int vagasDisponiveis = VerificarVagasLivres(estacionamento);
        Console.WriteLine("Existem {0} vagas livres no estacionamento.", vagasDisponiveis);
    }
    static void PreencherMatriz(bool[,] matriz)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = Convert.ToBoolean(Console.ReadLine());
            }
        }
    }
    static int VerificarVagasLivres(bool[,] matriz)
    {
        int vagasLivres = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (!matriz[i, j])
                {
                    vagasLivres++;
                }
            }
        }
        return vagasLivres;
    }
}