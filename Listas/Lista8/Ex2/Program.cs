using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}

class Program
{
    static void Main(string[] args)
    {
        Produto[] produtos = new Produto[4];

        for(int i = 0; i < produtos.Length; i++)
        {
            produtos[i].id = Convert.ToInt32(Console.ReadLine());
            produtos[i].nome = Console.ReadLine();
            produtos[i].preco = Convert.ToDouble(Console.ReadLine());
            produtos[i].disponivelEmEstoque = Convert.ToBoolean(Console.ReadLine());
        }

            //usei ToString porque não tava aceitando no oneCompiler, por causa do zero depois da virgula
            
        for(int i = 0; i < produtos.Length; i++)
        {
            if(produtos[i].disponivelEmEstoque)
            {
                Console.WriteLine(produtos[i].nome);
                Console.WriteLine(produtos[i].preco);
            }
        }
    }
}
