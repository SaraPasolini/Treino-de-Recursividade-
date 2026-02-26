using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static public void Multiplos(int a, int b)
    {

        if (b == 0) // Condição de parada quando acabar os multiplos, ou seja, chegar a 0 
        {
            Console.Write("");
        }
        else
        {
            Multiplos(a, b - 1);
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Informe os seguintes valores: ");

        Console.Write("Número A: "); // Multiplos desse numero
        int a = int.Parse(Console.ReadLine());

        Console.Write("Número B: "); // Quantos multiplos 
        int b = int.Parse(Console.ReadLine());

        Multiplos(a, b);

    }
}