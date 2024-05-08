using System;

class Ex01
{
    static void Main(string[] args)
    {
        int numeroTentativa = 1;
        const int TENTATIVAS = 3;

        do 
        {
            Console.WriteLine("Digite seu usúario:");
            string usuario = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            if (usuario == "admin" && senha == "123")
            {
                Console.WriteLine("Login realizado com sucesso!");
                break;
            }
            numeroTentativa++;
        }
        while (numeroTentativa <= TENTATIVAS);

        if (numeroTentativa > TENTATIVAS)
        {
            Console.WriteLine("Sua conta foi bloqueada");
        }
    }
}