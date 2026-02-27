using System;

class Program 
{

    public static void Binario (int n) 
    {
        if (n > 0) 
        {
            Binario(n /2); // divide o número por 2 sucessivamente. 
            Console.Write(n % 2); // Escreve o resto da divisão usando a pliha de execução 
        }
       
    }
    static void Main(string[] args)
    {
        Console.Write("Informe um número interio: "); // Pede um valor 
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"O número é em Binário : ");
       
        Binario(n); // Chamo a função 

       
    }
}