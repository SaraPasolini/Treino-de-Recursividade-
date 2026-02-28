using System;

class Program
{
    class Vet
    {
        private int[] vetor;

        public Vet(int tamanho)
        {
            if (tamanho <= 0)
                throw new ArgumentException("Tamanho inválido."); // Lança uma exceção se o tamanho for inválido
            vetor = new int[tamanho];
        }

        public void Incluir(int pos, int valor)
        {
            vetor[pos] = valor;
        }

        public int Recuperar(int pos) => vetor[pos];

        public bool Existe(int valor) =>
            Array.Exists(vetor, v => v == valor);

        public int Soma(Func<int, bool> condicao)
        {
            int soma = 0;
            foreach (int v in vetor)
                if (condicao(v)) soma += v;
            return soma;
        }

        public void Listar()
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.WriteLine($"[{i}] = {vetor[i]}");
        }
    }

    static bool VetorCriado(Vet v)
    {
        if (v == null)
        {
            Console.WriteLine("Crie o vetor primeiro (opção 1).");
            return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        Vet vet = null;
        string op;

        do
        {
            Console.WriteLine("\n1-Criar  2-Incluir  3-Recuperar  4-Existe");
            Console.WriteLine("5-Pares  6-Ímpares  7-Total  8-Listar  9-Sair");
            op = Console.ReadLine();

            try
            {
                switch (op)
                {
                    case "1":
                        Console.Write("Tamanho: ");
                        vet = new Vet(int.Parse(Console.ReadLine()));
                        break;

                    case "2":
                        if (!VetorCriado(vet)) break;
                        Console.Write("Posição: ");
                        int p = int.Parse(Console.ReadLine());
                        Console.Write("Valor: ");
                        vet.Incluir(p, int.Parse(Console.ReadLine()));
                        break;

                    case "3":
                        if (!VetorCriado(vet)) break;
                        Console.Write("Posição: ");
                        Console.WriteLine(vet.Recuperar(int.Parse(Console.ReadLine())));
                        break;

                    case "4":
                        if (!VetorCriado(vet)) break;
                        Console.Write("Valor: ");
                        Console.WriteLine(vet.Existe(int.Parse(Console.ReadLine()))
                            ? "Existe"
                            : "Não existe");
                        break;

                    case "5":
                        if (VetorCriado(vet))
                            Console.WriteLine(vet.Soma(v => v % 2 == 0));
                        break;

                    case "6":
                        if (VetorCriado(vet))
                            Console.WriteLine(vet.Soma(v => v % 2 != 0));
                        break;

                    case "7":
                        if (VetorCriado(vet))
                            Console.WriteLine(vet.Soma(v => true));
                        break;

                    case "8":
                        if (VetorCriado(vet))
                            vet.Listar();
                        break;

                }
            }
            catch
            {
                Console.WriteLine("Entrada inválida.");
            }

        } while (op != "9");
    }
}