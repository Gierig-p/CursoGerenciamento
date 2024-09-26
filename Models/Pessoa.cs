using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoP.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade { get; set; }
        public bool Matriculado { get; set; }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Matriculado = false;
        }
    }

}