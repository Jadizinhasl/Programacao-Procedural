using System;

class Ex03
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = n; i >= 1; i--)
		{
			for(int j = 1; j <= n - i; j++)
			{
				Console.Write(" ");
			}
			
			for(int j = 1; j <= i; j++)
			{
				Console.Write("*");
			}
			
			Console.WriteLine();
		}
    }
}