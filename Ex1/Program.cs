using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static int Calculo(int x, int y)
    {
        int r = 0;
        if (y < 0) // condição de parada
        {
            return r = x + x;
        }
        return r;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor dos seguintes números:");

        Console.Write("X :"); // Numero x representa o multiplicando
        int x = int.Parse(Console.ReadLine());

        Console.Write("Y :"); // Numero y representa o multiplicador
        int y = int.Parse(Console.ReadLine());

        Calculo(x, y);

    }
}

