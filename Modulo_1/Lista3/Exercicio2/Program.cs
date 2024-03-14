using System;

class Program
{
    static void Main(string[] args)
    {
        double PrecoFinal = 0;
        string resposta = "S";

        while (resposta == "S")
        {
            Console.WriteLine("Insira o nome do produto:");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Insira o valor do Produto:");
            double ValorProduto = double.Parse(Console.ReadLine());

            PrecoFinal = PrecoFinal + ValorProduto;
            
             Console.WriteLine("Deseja continuar sua compra?\n[S] - Sim\n[N] - Não");
             resposta = Console.ReadLine();

             Console.WriteLine("O valor total é de: R$" + Math.Round(PrecoFinal, 2));
        }
        if (PrecoFinal > 150)
        {
            Console.WriteLine("Parabéns!! Você ganhou frete grátis em sua compra de valor R$ " + Math.Round(PrecoFinal, 2));
        }
        else 
        {
            Console.WriteLine("A compra não possui frete grátis disponível");
        }
    }
}