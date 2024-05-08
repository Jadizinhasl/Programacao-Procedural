using System;

class Ex01
{
    static void Main(string[] args)
    {
        const int TAMANHAO = 8;
        string[,] matriz = new string[TAMANHAO, TAMANHAO];

        for (int i = 0; i < TAMANHAO; i++)
        {
            for (int j = 0; j < TAMANHAO; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    matriz[i,j] = "w";
                }
                else 
                {
                    matriz[i,j] = "b";
                }
            }
        }

        for (int i = 0; i < TAMANHAO; i++)
        {
            for (int j = 0; j < TAMANHAO; j++)
            {
                Console.Write("|{0}", matriz[i,j]);
            }
            Console.WriteLine("|");
        }
    }
}