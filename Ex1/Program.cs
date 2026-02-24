using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static int Calculo(int x, int y) // Função Recursiva 
    {
        // Tratamento de erro por multiplicação em zero 
        if (x == 0 || y == 0) // condição de parada
        {
            return 0;
        }
        else if (y == 1) // se caso meu multiplicador for 1
        {
            return x;
        }
        else
        {
            return x + Calculo(x, y - 1); // 
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor dos seguintes números:");

        Console.Write("X : "); // Numero x representa o multiplicando
        int x = int.Parse(Console.ReadLine());

        Console.Write("Y : "); // Numero y representa o multiplicador
        int y = int.Parse(Console.ReadLine());

        int resposta = Calculo(x, y);
        Console.WriteLine("A resposta é " + resposta);


    }
}

