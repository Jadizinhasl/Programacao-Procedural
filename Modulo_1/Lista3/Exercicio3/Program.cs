using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_MAXIMO_TENTATIVA = 3;
        
        int numeroDeTentativas = 1;

        do
        {
             Console.WriteLine("Digite o nome de usuário:");
             string nomeUsuario = Console.ReadLine();

             Console.WriteLine("Digite sua senha:");
             string senha = Console.ReadLine();
            
             if (nomeUsuario == "admin" && senha == "123senha")
             {
                Console.WriteLine("Login realizado com sucesso!");
                break;
             }
             numeroDeTentativas++;
        }
        while (numeroDeTentativas <= NUMERO_MAXIMO_TENTATIVA);

        if (numeroDeTentativas > NUMERO_MAXIMO_TENTATIVA)
        {
            Console.WriteLine("Sua conta foi bloqueada.");
        }
    }
}
