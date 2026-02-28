using System;

class Program
{
    public class Livro
    {
        public string Titulo { get; set; } = "";
        public string Autor { get; set; } = "";
        public string Genero { get; set; } = "";
        public int Ano { get; set; }

        // Construtor para criar um livro
        public Livro(string titulo, string autor, string genero, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
            Ano = ano;
        }

        // Construtor padrão
        public Livro() { }

       
        public string ObterTitulo() => Titulo;
        public string ObterAutor() => Autor;
        public string ObterGenero() => Genero;
        public int ObterAno() => Ano;

       
        public bool EhModernismo() => Ano >= 1930 && Ano <= 1945;

        
        public bool EhBarroco() => Ano >= 1601 && Ano <= 1768;

        public void Exibir()
        {
            Console.WriteLine($"\nTítulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Estilo: {ObterEstilo()}");
        }

        private string ObterEstilo()
        {
            if (EhModernismo()) return "Modernismo";
            if (EhBarroco()) return "Barroco";
            return "Outro";
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Biblioteca ===\n");

       // Livros de exemplo
        Livro livro1 = new Livro("Grande Sertão: Veredas", "Guimarães Rosa", "Romance", 1956);
        Livro livro2 = new Livro("Morte no Nilo", "Agatha Christie", "Mistério", 1937);
        Livro livro3 = new Livro("Memórias Póstumas de Brás Cubas", "Machado de Assis", "Romance", 1881);
        Livro livro4 = new Livro("Sermão da Sexta-feira da Paixão", "Padre Vieira", "Sermão", 1672);

        
        Livro[] livros = { livro1, livro2, livro3, livro4 };

        
        foreach (var livro in livros)
        {
            Console.WriteLine("\n--- Informações do Livro ---");
            Console.WriteLine($"Título: {livro.ObterTitulo()}");
            Console.WriteLine($"Autor: {livro.ObterAutor()}");
            Console.WriteLine($"Gênero: {livro.ObterGenero()}");
            Console.WriteLine($"Ano: {livro.ObterAno()}");

           
            if (livro.EhModernismo())
                Console.WriteLine("✓ É um livro do Modernismo (1930-1945)");
            if (livro.EhBarroco())
                Console.WriteLine("✓ É um livro do Barroco (1601-1768)");
            if (!livro.EhModernismo() && !livro.EhBarroco())
                Console.WriteLine("✗ Não é Modernismo nem Barroco");
        }

       
        Console.WriteLine("\n\n=== Criar um Novo Livro ===");
        Console.Write("Digite o título: ");
        string titulo = Console.ReadLine() ?? "";

        Console.Write("Digite o autor: ");
        string autor = Console.ReadLine() ?? "";

        Console.Write("Digite o gênero: ");
        string genero = Console.ReadLine() ?? "";

        Console.Write("Digite o ano: ");
        if (int.TryParse(Console.ReadLine(), out int ano))
        {
            Livro novoLivro = new Livro(titulo, autor, genero, ano);
            novoLivro.Exibir();

            if (novoLivro.EhModernismo())
                Console.WriteLine("Este é um livro do Modernismo!");
            else if (novoLivro.EhBarroco())
                Console.WriteLine("Este é um livro do Barroco!");
            else
                Console.WriteLine("Este livro não pertence aos estilos buscados.");
        }
        else
        {
            Console.WriteLine("Ano inválido!");
        }

        Console.WriteLine("\nPressione Enter para sair...");
        Console.ReadLine();
    }
}
