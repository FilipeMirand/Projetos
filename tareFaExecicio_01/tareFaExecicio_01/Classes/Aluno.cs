using System;
using System.Collections.Generic;
using System.Text;

namespace tareFaExecicio_01.Classes
{
    internal class Aluno:Pessoa
    {
        public int Numero {  get; set; }
        public string Curso { get; set; }
        public double Notas { get; set; }

        public Aluno(string nome, string dataNascimento, string telefone, int numero, string curso, double notas) : base(nome, dataNascimento, telefone)
        {
            Numero = numero;
            Curso = curso;
            Notas = notas;
        }
        public override string ToString()
        {
            return base.ToString() + $" Numero: {Numero}, Curso:{Curso}, Notas:{Notas}";
        }
    }
}
