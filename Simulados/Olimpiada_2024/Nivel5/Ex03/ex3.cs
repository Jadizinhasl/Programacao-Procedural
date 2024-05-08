using System;

class Ex03
{
    static void Main(string[] args)
    {
        char[] palavra = {'K','a','r','p','o','v'};
        Console.WriteLine("Dica: Já foi campeão mundial de Xadrez!");
        
        char[] forca = new char[6];
        InicializarForca(forca);
        ImprimirForca(forca);
        Jogar(palavra, forca);
    }

    static void InicializarForca(char[] forca)
    {
        for (int i = 0; i < forca.Length; i++)
        {
            forca[i] = '_';
        }
    }

    static void Jogar(char[] palavra, char[] forca)
    {
        int erros = 0;
        while (Comparar(palavra, forca))
        {
            Console.Write("Digite uma letra e veja se está na palavra secreta: ");
            char resposta = Convert.ToChar(Console.ReadLine());
            
            bool acertou = VerificarResposta(resposta, palavra);
            if (acertou)
            {
                PreencherForca(palavra, forca, resposta);
            }
            else
            {
                erros++;
            }
        
            ImprimirForca(forca);
            if (erros == 3)
            {
                Console.WriteLine("O número de tentativas foram execedidos. Infelizmente você perdeu...");
                break;
            }
        }
        if (erros < 3)
        {
            Console.WriteLine("Meus parabéns.Você descobriu a palavra secreta!!");
        }
    }

    static bool Comparar(char[] palavra, char[] forca)
    {
        for (int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] != forca[i])
            {
                return true;
            }
        }
        return false;
    }

    static void PreencherForca(char[] palavra, char[] forca, char letra)
    {
        for (int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] == letra)
            {
                forca[i] = letra;
            }
        }
    }

    static void ImprimirForca(char[] forca)
    {
        foreach (char letra in forca)
        {
            Console.Write(letra);
        }
        Console.WriteLine();
    }

    static bool VerificarResposta(char letra, char[] palavra)
    {
        foreach (char c in palavra)
        {
            if (c == letra)
            {
                return true;
            }
        }
        return false;
    }
}
