using CursoP.Models;

class Program
{
    static void Main(string[] args)
    {
        Curso curso = new Curso("C# Avançado");

        bool rodar = true;

        while (rodar)
        {
            Console.WriteLine("\n--- Menu de Opções ---");
            Console.WriteLine("1. Adicionar Aluno");
            Console.WriteLine("2. Remover Aluno");
            Console.WriteLine("3. Listar Alunos");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            string escolha = Console.ReadLine();

            while (string.IsNullOrEmpty(escolha) || !("1234".Contains(escolha)))
            {
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida (1-4):");
                escolha = Console.ReadLine();
            }

            switch (escolha)
            {
                case "1":
                    AdicionarAluno(curso);
                    break;
                
                case "2":
                    RemoverAluno(curso);
                    break;

                case "3":
                    curso.ListarAlunos();
                    break;

                case "4":
                    rodar = false;
                    Console.WriteLine("Saindo do sistema...");
                    break;
            }
        }
    }
     static void AdicionarAluno(Curso curso)
    {
        Console.WriteLine("Digite o nome do aluno: ");
        string nome = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome não pode ser vazio. Digite o nome do aluno:");
            nome = Console.ReadLine();
        }

        Console.WriteLine("Digite o sobrenome do aluno: ");
        string sobrenome = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(sobrenome))
        {
            Console.WriteLine("Sobrenome não pode ser vazio. Digite o sobrenome do aluno:");
            sobrenome = Console.ReadLine();
        }

        Pessoa aluno = new Pessoa(nome, sobrenome);
        curso.AdicionarAluno(aluno);
    }
    
    static void RemoverAluno(Curso curso)
    {
        Console.WriteLine("Digite o nome completo do aluno que deseja remover: ");
        string nomeCompleto = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(nomeCompleto))
        {
            Console.WriteLine("Nome completo não pode ser vazio. Digite o nome completo do aluno:");
            nomeCompleto = Console.ReadLine();
        }

         Pessoa aluno = curso.BuscarAlunoPorNomeCompleto(nomeCompleto);
        if (aluno != null)
        {
            curso.RemoverAluno(aluno);
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }
    }
}