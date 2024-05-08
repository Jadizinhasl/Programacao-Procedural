using System;

class Ex02
{
    static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine(MaiorNumero(n1,n2));
    }

    static int MaiorNumero(int n1, int n2)
    {
        if(n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
}