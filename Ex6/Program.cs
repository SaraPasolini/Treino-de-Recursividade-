using System;

class Program
{
    public class Data
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
    }

    public class Departamento
    {
        public string Nome { get; set; } = "";
    }

    public class Funcionario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; } = "";
        public Departamento Departamento { get; set; } = new Departamento();
        public double Salario { get; set; }
        public Data DataAdmissao { get; set; } = new Data();
    }

    static void CadastrarFuncionario(Funcionario f, int indice)
    {
        Console.WriteLine($"\n--- Cadastro do funcionário {indice + 1} ---");

        while (true)
        {
            Console.Write("Matrícula: ");
            if (int.TryParse(Console.ReadLine(), out int mat)) { f.Matricula = mat; break; }
            Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        }

        Console.Write("Nome: ");
        f.Nome = Console.ReadLine();

        Console.Write("Departamento: ");
        f.Departamento.Nome = Console.ReadLine();

        while (true)
        {
            Console.Write("Salário: ");
            if (double.TryParse(Console.ReadLine(), out double sal)) { f.Salario = sal; break; }
            Console.WriteLine("Entrada inválida. Digite um número (ex: 1234.56).");
        }

        Console.WriteLine("Data de admissão:");
        while (true)
        {
            Console.Write("Dia: ");
            if (int.TryParse(Console.ReadLine(), out int d) && d >= 1 && d <= 31) { f.DataAdmissao.Dia = d; break; }
            Console.WriteLine("Dia inválido. Tente novamente.");
        }
        while (true)
        {
            Console.Write("Mês: ");
            if (int.TryParse(Console.ReadLine(), out int m) && m >= 1 && m <= 12) { f.DataAdmissao.Mes = m; break; }
            Console.WriteLine("Mês inválido. Tente novamente.");
        }
        while (true)
        {
            Console.Write("Ano: ");
            if (int.TryParse(Console.ReadLine(), out int a) && a > 1900) { f.DataAdmissao.Ano = a; break; }
            Console.WriteLine("Ano inválido. Tente novamente.");
        }

        Console.WriteLine("Deseja cadastrar outro funcionário? (s/n)"); // Pergunta se o usuário deseja cadastrar outro funcionário
        string resposta = Console.ReadLine()?.Trim().ToLower() ?? "n";
        if (resposta != "s")
        {
            ListarFuncionariosCadastrados(f); 
        } 
    }

    static void ListarFuncionariosCadastrados(Funcionario f)
    {
        Console.WriteLine($"\n--- Funcionário cadastrado ---");
        Console.WriteLine($"Matrícula: {f.Matricula}");
        Console.WriteLine($"Nome: {f.Nome}");
        Console.WriteLine($"Departamento: {f.Departamento.Nome}");
        Console.WriteLine($"Salário: {f.Salario:F2}");
        Console.WriteLine($"Data de Admissão: {f.DataAdmissao.Dia}/{f.DataAdmissao.Mes}/{f.DataAdmissao.Ano}");
    }

    static void CadastrarVetor(Funcionario[] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        {
            vet[i] = new Funcionario();
            CadastrarFuncionario(vet[i], i);
        }
    }

    static void ListarPorDepartamento(Funcionario[] vet, string departamento)
    {
        Console.WriteLine($"\n--- Funcionários do departamento: {departamento} ---");
        bool achou = false;
        foreach (var f in vet)
        {
            if (f != null && string.Equals(f.Departamento.Nome?.Trim(), departamento.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                achou = true;
                Console.WriteLine($"Matrícula: {f.Matricula} | Nome: {f.Nome} | Salário: {f.Salario:F2} | Admissão: {f.DataAdmissao}");
            }
        }
        if (!achou) Console.WriteLine("Nenhum funcionário encontrado nesse departamento.");
    }

    static void Main(string[] args)
    {
        const int TAM = 50;
        var funcionarios = new Funcionario[TAM];

        Console.WriteLine("Cadastro de 50 funcionários.");
        CadastrarVetor(funcionarios);

        Console.WriteLine("\nDigite o nome do departamento para listar os funcionários:");
        string dept = Console.ReadLine() ?? string.Empty;
        ListarPorDepartamento(funcionarios, dept);

        Console.WriteLine("\nFim. Pressione Enter para sair.");
        Console.ReadLine();
    }
}
