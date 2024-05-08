using System;

class Ex01
{
    static void Main(string[] args)
    {
        const int TAMANHAO = 5;
        char[,] matriz = new char[TAMANHAO, TAMANHAO];

        for (int i = 0; i < TAMANHAO; i++)
        {
            for (int j = 0; j < TAMANHAO; j++)
            {
                matriz[i,j] = ' ';

                if (j % 2 != 0)
                {
                    matriz[i,j] = 't';
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