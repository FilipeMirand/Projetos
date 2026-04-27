using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tareFaExecicio_01.Classes
{
    public class Professor : Pessoa
    {
        public string Especialidade { get; set; }
        public string Departamento { get; set; }
        public double Salario { get; set; }

        public Professor(string especialidade, string departamento, double salario) : base(nome, dataNascimento, telefone)
        {
            Especialidade = especialidade;
            Departamento = departamento;
            Salario = salario;
        }
        public override string ToString()
        {
            return base.ToString() + $" Especialidade: {Especialidade}, Departamento:{Departamento}, Salario:{Salario}";
        }
    }
}
