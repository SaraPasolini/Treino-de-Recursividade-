using System;

class Program
{

   public static int Fibonacci(int n) // Precisa retornar um valor inteiro
    {
        if (n == 0 || n ==  1) // Condição de parada
        {
           return 1;
        }
        else  // Termo de sequencias
        {
            return Fibonacci (n - 1) + Fibonacci (n - 2);
        }

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Quantos termos da série você deseja calcular : ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Fibonacci com {n} termos : ");

        for (int i = 0; i <+ n; i++) // Mostrar a sequencia
        {
            Console.Write("{0,6}" , Fibonacci (i + 1));
        }
    }

}
