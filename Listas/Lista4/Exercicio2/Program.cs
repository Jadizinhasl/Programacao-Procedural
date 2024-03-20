using System;

class Program
{
    static void Main(string[] args)
    {
        int alturaTriangulo;

        do
        {
            Console.WriteLine("Informe a altura do triângulo retângulo!");
            alturaTriangulo = int.Parse(Console.ReadLine());

            if (alturaTriangulo < 1 || alturaTriangulo > 9)
            {
                Console.WriteLine("Altura invalida, por favor insira uma altura entre 1 e 9!");
            }
        } while (alturaTriangulo < 1 || alturaTriangulo > 9);
    
        for (int linha = 1; linha <= alturaTriangulo; linha++)
        {
            for (int coluna = 1; coluna <= linha; coluna++)
            {
                Console.Write(coluna);
            }
            Console.WriteLine();
        }
    }
}
