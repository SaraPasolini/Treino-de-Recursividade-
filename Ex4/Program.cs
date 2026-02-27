using System;
class Program
{

    public static int SomaVetor ( int [] v, int q)
    {
        if(q == 1)
        {
            return v [0];
        }
        else
        {
            return v [q-1] + SomaVetor (v, q -1);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Informe quantos números terão no vetor : "); // Peço a quantidade de numeros que vai ter no vetor
        int quantidade = int.Parse(Console.ReadLine()); 

        int [] V = new int[quantidade];
       
       for (int i = 0; i < V.Length ; i++)
        {
             Console.WriteLine($"Informe o valor {i+1}: "); //Peço quais números terão no vetor 
             V [i] = int.Parse (Console.ReadLine());
        }

        int resposta = SomaVetor(V, quantidade);

        Console.WriteLine($"A soma dos valores do vetor é {resposta}");
    }
}