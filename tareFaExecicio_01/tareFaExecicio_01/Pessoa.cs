using System;
using System.Collections.Generic;
using System.Text;

namespace tareFaExecicio_01
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Telefone { get; set; }

        public Pessoa(string nome, string dataNascimento, string telefone)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Telefone = telefone;

        }

        public override string ToString()
        {
            return $"Nome: {Nome}, DataNascimento: {DataNascimento}, Telefone: {Telefone} ";
        }
    }
}
