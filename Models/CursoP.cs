using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoP.Models
{
   public class Curso
{
    public string NomeCurso { get; set; }
    private List<Pessoa> alunos;

    public Curso(string nomeCurso)
    {
        NomeCurso = nomeCurso;
        alunos = new List<Pessoa>();
    }

    public void AdicionarAluno(Pessoa aluno)
    {
        if (!alunos.Contains(aluno))
        {
            alunos.Add(aluno);
            aluno.Matriculado = true;
            Console.WriteLine($"{aluno.NomeCompleto} foi adicionado ao curso {NomeCurso}.");
        }
        else if (!aluno.Matriculado)
        {
            aluno.Matriculado = true;
            Console.WriteLine($"{aluno.NomeCompleto} foi agora matriculado no curso {NomeCurso}.");
        }
        else
        {
            Console.WriteLine($"{aluno.NomeCompleto} já está matriculado no curso.");
        }
    }

    public void RemoverAluno(Pessoa aluno)
    {
        if (alunos.Contains(aluno))
        {
            alunos.Remove(aluno);
            aluno.Matriculado = false;
            Console.WriteLine($"{aluno.NomeCompleto} foi removido do curso {NomeCurso}.");
        }
        else
        {
            Console.WriteLine($"{aluno.NomeCompleto} não está matriculado no curso.");
        }
    }

    public void ListarAlunos()
    {
        Console.WriteLine($"\nAlunos no curso {NomeCurso}:");
        var alunosMatriculados = alunos.Where(a => a.Matriculado).ToList();
        var alunosNaoMatriculados = alunos.Where(a => !a.Matriculado).ToList();

        if (alunosMatriculados.Any())
        {
            Console.WriteLine("Alunos matriculados:");
            foreach (var aluno in alunosMatriculados)
            {
                Console.WriteLine($"- {aluno.NomeCompleto}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum aluno matriculado.");
        }

        if (alunosNaoMatriculados.Any())
        {
            Console.WriteLine("Alunos não matriculados:");
            foreach (var aluno in alunosNaoMatriculados)
            {
                Console.WriteLine($"- {aluno.NomeCompleto}");
            }
        }
    }

    public Pessoa BuscarAlunoPorNomeCompleto(string nomeCompleto)
    {
        return alunos.FirstOrDefault(a => a.NomeCompleto.Equals(nomeCompleto, StringComparison.OrdinalIgnoreCase));
    }
}

}   
