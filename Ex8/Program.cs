using System;

public struct Livro
{
    // Estrutura de dados (campos privados)
    private string titulo;
    private string autor;
    private string genero;
    private int ano;

   
    public Livro(string titulo, string autor, string genero, int ano)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.genero = genero;
        this.ano = ano;
    }


    public string ObterTitulo()
    {
        return titulo;
    }

    public string ObterAutor()
    {
        return autor;
    }

    public string ObterGenero()
    {
        return genero;
    }

    public int ObterAno()
    {
        return ano;
    }

    public bool EhModernismo()
    {
        return ano >= 1930 && ano <= 1945;
    }

    public bool EhBarroco()
    {
        return ano >= 1601 && ano <= 1768;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Livro livro1 = new Livro("Vidas Secas", "Graciliano Ramos", "Romance", 1938);

        Console.WriteLine("Título: " + livro1.ObterTitulo());
        Console.WriteLine("Autor: " + livro1.ObterAutor());
        Console.WriteLine("Ano: " + livro1.ObterAno());

        Console.WriteLine("É Modernismo? " + livro1.EhModernismo());
        Console.WriteLine("É Barroco? " + livro1.EhBarroco());
    }
}